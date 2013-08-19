Module Helper
    Sub preventSpecialChar(ByVal e)
        If Not (Asc(e.KeyChar) = 8 Or
               Asc(e.KeyChar) = 13 Or
               (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or
               (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or
               (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122)) Then
            e.Handled = True
        End If
    End Sub

    Function showDateRangeIfExist(ByVal chkTanggal As CheckBox, ByVal dtStart As DateTimePicker, ByVal dtEnd As DateTimePicker, ByVal fallback As String) As String
        If chkTanggal.CheckState = CheckState.Checked Then
            Return String.Format("{0} - {1}",
                dtStart.Value,
                dtEnd.Value)
        Else
            Return fallback
        End If
    End Function

    Sub createIfNotExists()
        Dim sql As String = "USE Master" + vbCrLf + _
            "" + vbCrLf + _
            "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'MarketStore')" + vbCrLf + _
            "BEGIN" + vbCrLf +
            "	CREATE DATABASE Marketstore" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	USE Marketstore" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE TABLE Pemasok (" + vbCrLf + _
            "		kode	VarChar(16) NOT NULL Primary Key," + vbCrLf + _
            "		nama	VarChar(25) NOT NULL UNIQUE," + vbCrLf + _
            "		alamat	VarChar(50)," + vbCrLf + _
            "		kontak	VarChar(15)" + vbCrLf + _
            "	)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE TABLE Pembeli (" + vbCrLf + _
            "		kode	VarChar(16) NOT NULL Primary Key," + vbCrLf + _
            "		nama	VarChar(30) NOT NULL UNIQUE," + vbCrLf + _
            "		alamat	VarChar(50)," + vbCrLf + _
            "		kontak	VarChar(15)" + vbCrLf + _
            "	)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE TABLE FakturBeli (" + vbCrLf + _
            "		kode			VarChar(16) NOT NULL Primary Key," + vbCrLf + _
            "		tanggal			DateTime NOT NULL" + vbCrLf + _
            "	)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE TABLE FakturJual (" + vbCrLf + _
            "		kode			VarChar(16) NOT NULL Primary Key," + vbCrLf + _
            "		tanggal			DateTime NOT NULL," + vbCrLf + _
            "		diskon			TinyInt NOT NULL Check (diskon Between 0 And 100)," + vbCrLf + _
            "		kode_pembeli	VarChar(16) NOT NULL Foreign Key References Pembeli (kode)" + vbCrLf + _
            "	)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE TABLE Barang (" + vbCrLf + _
            "		kode			VarChar(16) NOT NULL Primary Key," + vbCrLf + _
            "		nama			VarChar(30) NOT NULL UNIQUE," + vbCrLf + _
            "		stok			SmallInt Default (0)," + vbCrLf + _
            "		kode_pemasok 	VarChar(16) NOT NULL Foreign Key References Pemasok (kode)" + vbCrLf + _
            "	)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE TABLE HargaBarang (" + vbCrLf + _
            "		tanggal		DateTime NOT NULL Primary Key," + vbCrLf + _
            "		kode_barang	VarChar(16) NOT NULL Foreign Key References Barang (kode)," + vbCrLf + _
            "		harga_beli	Int NOT NULL," + vbCrLf + _
            "		harga_jual	Int NOT NULL" + vbCrLf + _
            "	)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE TABLE DetailFakturBeli (" + vbCrLf + _
            "		kode_faktur		VarChar(16) NOT NULL Foreign Key References FakturBeli (kode)," + vbCrLf + _
            "		kode_barang		VarChar(16) NOT NULL Foreign Key References Barang (kode)," + vbCrLf + _
            "		jumlah_terbeli	TinyInt NOT NULL," + vbCrLf + _
            "" + vbCrLf + _
            "		Primary Key (kode_faktur, kode_barang)" + vbCrLf + _
            "	)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE TABLE DetailFakturJual (" + vbCrLf + _
            "		kode_faktur		VarChar(16) NOT NULL Foreign Key References FakturJual (kode)," + vbCrLf + _
            "		kode_barang		VarChar(16) NOT NULL Foreign Key References Barang (kode)," + vbCrLf + _
            "		jumlah_terjual	TinyInt NOT NULL," + vbCrLf + _
            "" + vbCrLf + _
            "		Primary Key (kode_faktur, kode_barang)" + vbCrLf + _
            "	)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- create fixture" + vbCrLf + _
            "	EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'" + vbCrLf + _
            "	GO" + vbCrLf + _
            "	EXEC sp_MSForEachTable 'DELETE FROM ?'" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Pemasok" + vbCrLf + _
            "	INSERT INTO Pemasok VALUES ('P0001', 'Makmur Jaya', 'Jl Desa Makmur No. 22', '08132323')" + vbCrLf + _
            "	INSERT INTO Pemasok VALUES ('P0002', 'Sekip Jaya', 'Jl Kota Baru No. 1', '021232323')" + vbCrLf + _
            "	INSERT INTO Pemasok VALUES ('P0003', 'Tunas Bangsa', 'Jl Cendrawasih No. 321', '0711432423')" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Pembeli" + vbCrLf + _
            "	INSERT INTO Pembeli VALUES ('B0001', 'Ryan', 'Jl Jalanan No. 123', '0852525')" + vbCrLf + _
            "	INSERT INTO Pembeli VALUES ('B0002', 'Rudi', 'Jl Polisi No. 545', '')" + vbCrLf + _
            "	INSERT INTO Pembeli VALUES ('B0003', 'Rar', 'Jl Kembang No. 321', '')" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Barang" + vbCrLf + _
            "	INSERT INTO Barang VALUES ('I0001', 'Jam tangan CASIO', 22, 'P0001')" + vbCrLf + _
            "	INSERT INTO Barang VALUES ('I0002', 'Binder Sinar Dunia', 55, 'P0002')" + vbCrLf + _
            "	INSERT INTO Barang VALUES ('I0003', 'Flash Disk Kingstone 2GB', 12, 'P0003')" + vbCrLf + _
            "	INSERT INTO Barang VALUES ('I0004', 'Mouse Razor', 4, 'P0001')" + vbCrLf + _
            "	INSERT INTO Barang VALUES ('I0005', 'Keyboard Logitech', 7, 'P0002')" + vbCrLf + _
            "" + vbCrLf + _
            "	-- HargaBarang" + vbCrLf + _
            "	INSERT INTO HargaBarang VALUES (GetDate(), 'I0001', 25000, 35000)" + vbCrLf + _
            "	WAITFOR DELAY '00:00:01'" + vbCrLf + _
            "	INSERT INTO HargaBarang VALUES (GetDate(), 'I0002', 15000, 25000)" + vbCrLf + _
            "	WAITFOR DELAY '00:00:01'" + vbCrLf + _
            "	INSERT INTO HargaBarang VALUES (GetDate(), 'I0003', 75000, 80000)" + vbCrLf + _
            "	WAITFOR DELAY '00:00:01'" + vbCrLf + _
            "	INSERT INTO HargaBarang VALUES (GetDate(), 'I0004', 40000, 55000)" + vbCrLf + _
            "	WAITFOR DELAY '00:00:01'" + vbCrLf + _
            "	INSERT INTO HargaBarang VALUES (GetDate(), 'I0005', 30000, 35000)" + vbCrLf + _
            "" + vbCrLf + _
            "	-- FakturBeli" + vbCrLf + _
            "	INSERT INTO FakturBeli VALUES ('FB001', GetDate())" + vbCrLf + _
            "	INSERT INTO FakturBeli VALUES ('FB002', GetDate())" + vbCrLf + _
            "" + vbCrLf + _
            "	-- FakturJual" + vbCrLf + _
            "	INSERT INTO FakturJual VALUES ('FJ001', GetDate(), 5, 'B0001')" + vbCrLf + _
            "	INSERT INTO FakturJual VALUES ('FJ002', GetDate(), 0, 'B0002')" + vbCrLf + _
            "" + vbCrLf + _
            "	-- DetailFakturBeli" + vbCrLf + _
            "	INSERT INTO DetailFakturBeli VALUES ('FB001', 'I0001', 5)" + vbCrLf + _
            "	INSERT INTO DetailFakturBeli VALUES ('FB001', 'I0004', 6)" + vbCrLf + _
            "	INSERT INTO DetailFakturBeli VALUES ('FB002', 'I0002', 12)" + vbCrLf + _
            "	INSERT INTO DetailFakturBeli VALUES ('FB002', 'I0005', 7)" + vbCrLf + _
            "" + vbCrLf + _
            "	-- DetailFakturJual" + vbCrLf + _
            "	INSERT INTO DetailFakturJual VALUES ('FJ001', 'I0001', 3)" + vbCrLf + _
            "	INSERT INTO DetailFakturJual VALUES ('FJ001', 'I0002', 5)" + vbCrLf + _
            "	INSERT INTO DetailFakturJual VALUES ('FJ001', 'I0003', 6)" + vbCrLf + _
            "	INSERT INTO DetailFakturJual VALUES ('FJ002', 'I0004', 4)" + vbCrLf + _
            "	INSERT INTO DetailFakturJual VALUES ('FJ002', 'I0005', 6)" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- HelperBarang" + vbCrLf + _
            "	CREATE VIEW ShowAllItems AS" + vbCrLf + _
            "		SELECT Barang.kode, Barang.nama, Barang.stok, Pemasok.kode as kode_pemasok, Pemasok.nama as nama_pemasok, HargaBarang.harga_beli, HargaBarang.harga_jual, Convert(VarChar, BarangTerkini.tanggal_terakhir, 113) AS tanggal_terakhir --BarangTerkini.tanggal_terakhir" + vbCrLf + _
            "		FROM Barang INNER JOIN Pemasok ON Barang.kode_pemasok = Pemasok.kode INNER JOIN HargaBarang ON Barang.kode = HargaBarang.kode_barang INNER JOIN (" + vbCrLf + _
            "			SELECT Barang.kode, Max(HargaBarang.tanggal) AS tanggal_terakhir" + vbCrLf + _
            "			FROM Barang INNER JOIN Pemasok ON Barang.kode_pemasok = Pemasok.kode INNER JOIN HargaBarang ON Barang.kode = HargaBarang.kode_barang" + vbCrLf + _
            "			GROUP BY Barang.kode" + vbCrLf + _
            "		) BarangTerkini ON Barang.kode = BarangTerkini.kode" + vbCrLf + _
            "		AND BarangTerkini.tanggal_terakhir = HargaBarang.tanggal" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE PROCEDURE AddNewItems (@kode_barang VarChar(16), @nama_barang VarChar(30), @kode_pemasok Char(5), @harga_beli Int, @harga_jual Int) AS" + vbCrLf + _
            "		BEGIN TRANSACTION" + vbCrLf + _
            "			INSERT INTO Barang VALUES(@kode_barang, @nama_barang, 0, @kode_pemasok)" + vbCrLf + _
            "			INSERT INTO HargaBarang VALUES(GetDate(), @kode_barang, @harga_beli, @harga_jual)" + vbCrLf + _
            "		COMMIT" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE PROCEDURE AlterSelectedItem (@kode_barang VarChar(16), @nama_barang VarChar(30), @stok SmallInt, @kode_pemasok Char(5), @harga_beli Int, @harga_jual Int) AS" + vbCrLf + _
            "		BEGIN TRANSACTION" + vbCrLf + _
            "			UPDATE Barang SET nama = @nama_barang, stok = @stok, kode_pemasok = @kode_pemasok WHERE kode = @kode_barang" + vbCrLf + _
            "			INSERT INTO HargaBarang VALUES(GetDate(), @kode_barang, @harga_beli, @harga_jual)" + vbCrLf + _
            "		COMMIT" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE VIEW BarangTersedia AS" + vbCrLf + _
            "		SELECT Barang.kode, Barang.nama, HargaBarang.harga_beli, HargaBarang.harga_jual, HargaBarang.tanggal" + vbCrLf + _
            "		FROM Barang" + vbCrLf + _
            "		INNER JOIN HargaBarang ON Barang.kode = Hargabarang.kode_barang" + vbCrLf + _
            "		INNER JOIN (" + vbCrLf + _
            "			SELECT Barang.kode, Max(HargaBarang.tanggal) AS tanggal" + vbCrLf + _
            "			FROM Barang	INNER JOIN HargaBarang ON Barang.kode = Hargabarang.kode_barang" + vbCrLf + _
            "			GROUP BY Barang.kode" + vbCrLf + _
            "		) HargaBarangTerakhir" + vbCrLf + _
            "		ON Barang.kode = HargaBarangTerakhir.kode" + vbCrLf + _
            "		AND HargaBarang.tanggal = HargaBarangTerakhir.tanggal" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- HelperBarangDestroy" + vbCrLf + _
            "	CREATE FUNCTION ExtractKodeBarang (@kode VarChar(16)) Returns VarChar(16) AS BEGIN" + vbCrLf + _
            "		DECLARE @extracted_kode VarChar(16)" + vbCrLf + _
            "		" + vbCrLf + _
            "		IF CharIndex('_deleted', @kode) > 0" + vbCrLf + _
            "			SET @extracted_kode = Left(@kode, CharIndex('_deleted', @kode) - 1)" + vbCrLf + _
            "		ELSE" + vbCrLf + _
            "			SET @extracted_kode = @kode" + vbCrLf + _
            "			" + vbCrLf + _
            "		RETURN @extracted_kode" + vbCrLf + _
            "	END" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE FUNCTION GetLatestDeleteID (@kode VarChar(16)) Returns SmallInt AS BEGIN" + vbCrLf + _
            "		DECLARE @delete_id SmallInt" + vbCrLf + _
            "		" + vbCrLf + _
            "		IF ( SELECT COUNT(*) FROM Barang WHERE kode LIKE @kode + '_deleted%' ) > 0 BEGIN" + vbCrLf + _
            "			SET @delete_id = (" + vbCrLf + _
            "				SELECT TOP 1 Convert(INT, Right(kode, 3))" + vbCrLf + _
            "				FROM Barang" + vbCrLf + _
            "				WHERE kode LIKE '12345_deleted%'" + vbCrLf + _
            "				ORDER BY kode DESC" + vbCrLf + _
            "			)" + vbCrLf + _
            "		END ELSE BEGIN" + vbCrLf + _
            "			SET @delete_id = -1" + vbCrLf + _
            "		END" + vbCrLf + _
            "		" + vbCrLf + _
            "		RETURN @delete_id" + vbCrLf + _
            "	END" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE FUNCTION GenerateNewDeleteID (@kode VarChar(16)) Returns VarChar(16) AS BEGIN" + vbCrLf + _
            "		DECLARE @new_id SmallInt" + vbCrLf + _
            "		SET @new_id = dbo.GetLatestDeleteID(@kode) + 1" + vbCrLf + _
            "		Return Concat(@kode, '_deleted', Replicate('0', 3 - Len(@new_id)), @new_id)" + vbCrLf + _
            "	END" + vbCrLf + _
            "	GO	" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE PROCEDURE SafelyDeleteItem (@kode_barang VarChar(16)) AS" + vbCrLf + _
            "		BEGIN TRANSACTION" + vbCrLf + _
            "			DECLARE @new_kode VarChar(16)" + vbCrLf + _
            "			SET @new_kode = dbo.GenerateNewDeleteID(@kode_barang)" + vbCrLf + _
            "			" + vbCrLf + _
            "			UPDATE Barang SET kode = @new_kode WHERE kode = @kode_barang" + vbCrLf + _
            "			UPDATE HargaBarang SET kode_barang = @new_kode WHERE kode_barang = @kode_barang" + vbCrLf + _
            "			UPDATE DetailFakturBeli SET kode_barang = @new_kode WHERE kode_barang = @kode_barang" + vbCrLf + _
            "			UPDATE DetailFakturJual SET kode_barang = @new_kode WHERE kode_barang = @kode_barang" + vbCrLf + _
            "		COMMIT" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- HelperPembelian" + vbCrLf + _
            "	CREATE VIEW DetailFakturPembelian AS" + vbCrLf + _
            "		SELECT DISTINCT" + vbCrLf + _
            "			   FakturBeli.kode		AS kode_faktur," + vbCrLf + _
            "			   FakturBeli.tanggal	AS tanggal_faktur," + vbCrLf + _
            "			   HargaBarang.tanggal	AS tanggal_barang," + vbCrLf + _
            "			   Barang.kode			AS kode_barang," + vbCrLf + _
            "			   Barang.nama			AS nama_barang," + vbCrLf + _
            "			   DetailFakturBeli.jumlah_terbeli," + vbCrLf + _
            "			   Barang.kode_pemasok," + vbCrLf + _
            "			   HargaBarang.harga_beli," + vbCrLf + _
            "			   DetailFakturBeli.jumlah_terbeli * HargaBarang.harga_beli AS total_harga," + vbCrLf + _
            "			   Pemasok.nama			AS nama_pemasok" + vbCrLf + _
            "		FROM FakturBeli" + vbCrLf + _
            "		INNER JOIN DetailFakturBeli	ON FakturBeli.kode = DetailFakturBeli.kode_faktur" + vbCrLf + _
            "		INNER JOIN Barang			ON Barang.kode = DetailFakturBeli.kode_barang" + vbCrLf + _
            "		INNER JOIN HargaBarang		ON Barang.kode = HargaBarang.kode_barang" + vbCrLf + _
            "		INNER JOIN Pemasok			ON Barang.kode_pemasok = Pemasok.kode" + vbCrLf + _
            "		INNER JOIN (" + vbCrLf + _
            "			SELECT FakturBeli.kode, Barang.kode as kode_barang, FakturBeli.tanggal AS tanggal_faktur, MAX(HargaBarang.tanggal) AS tanggal_barang" + vbCrLf + _
            "			FROM FakturBeli" + vbCrLf + _
            "			INNER JOIN DetailFakturBeli	ON FakturBeli.kode = DetailFakturBeli.kode_faktur" + vbCrLf + _
            "			INNER JOIN Barang			ON Barang.kode = DetailFakturBeli.kode_barang" + vbCrLf + _
            "			INNER JOIN HargaBarang		ON Barang.kode = HargaBarang.kode_barang" + vbCrLf + _
            "			WHERE HargaBarang.tanggal < FakturBeli.tanggal" + vbCrLf + _
            "			GROUP BY FakturBeli.kode, Barang.kode, FakturBeli.tanggal" + vbCrLf + _
            "		) HargaFaktur" + vbCrLf + _
            "		ON HargaBarang.tanggal = HargaFaktur.tanggal_barang" + vbCrLf + _
            "		AND FakturBeli.kode = HargaFaktur.kode" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Total Item" + vbCrLf + _
            "	CREATE VIEW TotalItemTerbeliPerFaktur AS" + vbCrLf + _
            "		SELECT kode_faktur, Sum(jumlah_terbeli) AS total_barang" + vbCrLf + _
            "		FROM DetailFakturBeli" + vbCrLf + _
            "		GROUP BY kode_faktur" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE VIEW TotalItemTerbeliPerPemasok AS" + vbCrLf + _
            "		SELECT nama_pemasok, Sum(jumlah_terbeli) AS total_barang" + vbCrLf + _
            "		FROM DetailFakturPembelian" + vbCrLf + _
            "		GROUP BY nama_pemasok" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE VIEW TotalItemTerbeliPerBulan AS" + vbCrLf + _
            "		SELECT Concat(Year(tanggal_faktur), '-', Month(tanggal_faktur), '-1') AS tanggal_faktur," + vbCrLf + _
            "			   Sum(jumlah_terbeli) AS total_barang" + vbCrLf + _
            "		FROM DetailFakturPembelian" + vbCrLf + _
            "		GROUP BY Concat(Year(tanggal_faktur), '-', Month(tanggal_faktur), '-1')" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Total Harga" + vbCrLf + _
            "	CREATE VIEW TotalHargaPembelianPerFaktur AS" + vbCrLf + _
            "		SELECT kode_faktur, Sum(total_harga) AS harga" + vbCrLf + _
            "		FROM DetailFakturPembelian" + vbCrLf + _
            "		GROUP BY kode_faktur" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE VIEW TotalHargaPembelianPerPemasok AS" + vbCrLf + _
            "		SELECT nama_pemasok, Sum(total_harga) AS harga" + vbCrLf + _
            "		FROM DetailFakturPembelian" + vbCrLf + _
            "		GROUP BY nama_pemasok" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE VIEW TotalHargaPembelianPerBulan AS" + vbCrLf + _
            "		SELECT Concat(Year(tanggal_faktur), '-', Month(tanggal_faktur), '-1') AS tanggal_faktur," + vbCrLf + _
            "			   Sum(total_harga) AS harga" + vbCrLf + _
            "		FROM DetailFakturPembelian" + vbCrLf + _
            "		GROUP BY Concat(Year(tanggal_faktur), '-', Month(tanggal_faktur), '-1')" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Hapus faktur" + vbCrLf + _
            "	CREATE PROCEDURE HapusFakturBeli (@kode VarChar(16), @stok_ikut_berkurang Bit) AS" + vbCrLf + _
            "		BEGIN TRANSACTION" + vbCrLf + _
            "			IF @stok_ikut_berkurang = 1 BEGIN" + vbCrLf + _
            "				UPDATE B" + vbCrLf + _
            "				SET B.stok = B.stok - DFB.jumlah_terbeli" + vbCrLf + _
            "				FROM dbo.Barang AS B INNER JOIN dbo.DetailFakturBeli as DFB" + vbCrLf + _
            "				ON B.kode = DFB.kode_barang" + vbCrLf + _
            "				WHERE DFB.kode_faktur = @kode" + vbCrLf + _
            "			END" + vbCrLf + _
            "			" + vbCrLf + _
            "			DELETE FROM DetailFakturBeli WHERE kode_faktur = @kode" + vbCrLf + _
            "			DELETE FROM FakturBeli WHERE kode = @kode" + vbCrLf + _
            "		COMMIT" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE PROCEDURE HapusSemuaFakturBeli (@stok_ikut_berkurang Bit) AS" + vbCrLf + _
            "		BEGIN TRANSACTION" + vbCrLf + _
            "			IF @stok_ikut_berkurang = 1 BEGIN" + vbCrLf + _
            "				UPDATE B" + vbCrLf + _
            "				SET B.stok = B.stok - DFB.jumlah_terbeli" + vbCrLf + _
            "				FROM dbo.Barang AS B INNER JOIN dbo.DetailFakturBeli as DFB" + vbCrLf + _
            "				ON B.kode = DFB.kode_barang" + vbCrLf + _
            "			END" + vbCrLf + _
            "			" + vbCrLf + _
            "			DELETE FROM DetailFakturBeli" + vbCrLf + _
            "			DELETE FROM FakturBeli" + vbCrLf + _
            "		COMMIT" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- HelperPenjualan" + vbCrLf + _
            "	CREATE VIEW DetailFakturPenjualan AS" + vbCrLf + _
            "		SELECT DISTINCT" + vbCrLf + _
            "			   FakturJual.kode		AS kode_faktur," + vbCrLf + _
            "			   FakturJual.tanggal	AS tanggal_faktur," + vbCrLf + _
            "			   FakturJual.diskon," + vbCrLf + _
            "			   HargaBarang.tanggal	AS tanggal_barang," + vbCrLf + _
            "			   Barang.kode			AS kode_barang," + vbCrLf + _
            "			   Barang.nama			AS nama_barang," + vbCrLf + _
            "			   DetailFakturJual.jumlah_terjual," + vbCrLf + _
            "			   HargaBarang.harga_jual," + vbCrLf + _
            "			   DetailFakturJual.jumlah_terjual * HargaBarang.harga_jual AS total_harga," + vbCrLf + _
            "			   Pembeli.nama			AS nama_pembeli" + vbCrLf + _
            "		FROM FakturJual" + vbCrLf + _
            "		INNER JOIN DetailFakturJual	ON FakturJual.kode = DetailFakturJual.kode_faktur" + vbCrLf + _
            "		INNER JOIN Pembeli			ON FakturJual.kode_pembeli = Pembeli.kode" + vbCrLf + _
            "		INNER JOIN Barang			ON Barang.kode = DetailFakturJual.kode_barang" + vbCrLf + _
            "		INNER JOIN HargaBarang		ON Barang.kode = HargaBarang.kode_barang" + vbCrLf + _
            "		INNER JOIN (" + vbCrLf + _
            "			SELECT FakturJual.kode, Barang.kode as kode_barang, FakturJual.tanggal AS tanggal_faktur, MAX(HargaBarang.tanggal) AS tanggal_barang" + vbCrLf + _
            "			FROM FakturJual" + vbCrLf + _
            "			INNER JOIN DetailFakturJual	ON FakturJual.kode = DetailFakturJual.kode_faktur" + vbCrLf + _
            "			INNER JOIN Barang			ON Barang.kode = DetailFakturJual.kode_barang" + vbCrLf + _
            "			INNER JOIN HargaBarang		ON Barang.kode = HargaBarang.kode_barang" + vbCrLf + _
            "			WHERE HargaBarang.tanggal < FakturJual.tanggal" + vbCrLf + _
            "			GROUP BY FakturJual.kode, Barang.kode, FakturJual.tanggal" + vbCrLf + _
            "		) HargaFaktur" + vbCrLf + _
            "		ON HargaBarang.tanggal = HargaFaktur.tanggal_barang" + vbCrLf + _
            "		AND FakturJual.kode = HargaFaktur.kode" + vbCrLf + _
            "		AND Barang.kode = HargaFaktur.kode_barang" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Total Item" + vbCrLf + _
            "	CREATE VIEW TotalItemTerjualPerFaktur AS" + vbCrLf + _
            "		SELECT kode_faktur, Sum(jumlah_terjual) AS total_barang" + vbCrLf + _
            "		FROM DetailFakturJual" + vbCrLf + _
            "		GROUP BY kode_faktur" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE VIEW TotalItemTerjualPerPemasok AS" + vbCrLf + _
            "		SELECT nama_pembeli, Sum(jumlah_terjual) AS total_barang" + vbCrLf + _
            "		FROM DetailFakturPenjualan" + vbCrLf + _
            "		GROUP BY nama_pembeli" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE VIEW TotalItemTerjualPerBulan AS" + vbCrLf + _
            "		SELECT Concat(Year(tanggal_faktur), '-', Month(tanggal_faktur), '-1') AS tanggal_faktur," + vbCrLf + _
            "			   Sum(jumlah_terjual) AS total_barang" + vbCrLf + _
            "		FROM DetailFakturPenjualan" + vbCrLf + _
            "		GROUP BY Concat(Year(tanggal_faktur), '-', Month(tanggal_faktur), '-1')" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Total Harga" + vbCrLf + _
            "	CREATE VIEW TotalHargaPenjualanPerFaktur AS" + vbCrLf + _
            "		SELECT kode_faktur, diskon, CONVERT(Int, Sum(total_harga) * (1 - (1 * diskon / 100.0))) AS harga" + vbCrLf + _
            "		FROM DetailFakturPenjualan" + vbCrLf + _
            "		GROUP BY kode_faktur, diskon" + vbCrLf + _
            "	GO" + vbCrLf + _
            "		" + vbCrLf + _
            "	CREATE VIEW TotalHargaPenjualanPerPemasok AS" + vbCrLf + _
            "		SELECT nama_pembeli, Sum(total_harga) AS harga" + vbCrLf + _
            "		FROM DetailFakturPenjualan" + vbCrLf + _
            "		GROUP BY nama_pembeli" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE VIEW TotalHargaPenjualanPerBulan AS" + vbCrLf + _
            "		SELECT Concat(Year(tanggal_faktur), '-', Month(tanggal_faktur), '-1') AS tanggal_faktur," + vbCrLf + _
            "			   Sum(total_harga) AS harga" + vbCrLf + _
            "		FROM DetailFakturPenjualan" + vbCrLf + _
            "		GROUP BY Concat(Year(tanggal_faktur), '-', Month(tanggal_faktur), '-1')" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	-- Hapus faktur" + vbCrLf + _
            "	CREATE PROCEDURE HapusFakturJual (@kode VarChar(16), @stok_ikut_berkurang Bit) AS" + vbCrLf + _
            "		BEGIN TRANSACTION" + vbCrLf + _
            "			IF @stok_ikut_berkurang = 1 BEGIN" + vbCrLf + _
            "				UPDATE B" + vbCrLf + _
            "				SET B.stok = B.stok + DFJ.jumlah_terjual" + vbCrLf + _
            "				FROM dbo.Barang AS B INNER JOIN dbo.DetailFakturJual as DFJ" + vbCrLf + _
            "				ON B.kode = DFJ.kode_barang" + vbCrLf + _
            "				WHERE DFJ.kode_faktur = @kode" + vbCrLf + _
            "			END" + vbCrLf + _
            "			" + vbCrLf + _
            "			DELETE FROM DetailFakturJual WHERE kode_faktur = @kode" + vbCrLf + _
            "			DELETE FROM FakturJual WHERE kode = @kode" + vbCrLf + _
            "		COMMIT" + vbCrLf + _
            "	GO" + vbCrLf + _
            "" + vbCrLf + _
            "	CREATE PROCEDURE HapusSemuaFakturJual (@stok_ikut_berkurang Bit) AS" + vbCrLf + _
            "		BEGIN TRANSACTION" + vbCrLf + _
            "			IF @stok_ikut_berkurang = 1 BEGIN" + vbCrLf + _
            "				UPDATE B" + vbCrLf + _
            "				SET B.stok = B.stok + DFJ.jumlah_terjual" + vbCrLf + _
            "				FROM dbo.Barang AS B INNER JOIN dbo.DetailFakturJual as DFJ" + vbCrLf + _
            "				ON B.kode = DFJ.kode_barang" + vbCrLf + _
            "			END" + vbCrLf + _
            "			" + vbCrLf + _
            "			DELETE FROM DetailFakturJual" + vbCrLf + _
            "			DELETE FROM FakturJual" + vbCrLf + _
            "		COMMIT" + vbCrLf + _
            "	GO"

        If exec(sql) = False Then
            MsgBox("Gagal menginisialisasi database")
        End If
    End Sub

End Module
