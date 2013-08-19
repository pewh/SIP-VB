USE Master

DROP DATABASE MarketStore
GO

-- build schema
CREATE DATABASE MarketStore
GO

USE Marketstore
GO

CREATE TABLE Pemasok (
	kode	VarChar(16) NOT NULL Primary Key,
	nama	VarChar(25) NOT NULL UNIQUE,
	alamat	VarChar(50),
	kontak	VarChar(15)
)
GO

CREATE TABLE Pembeli (
	kode	VarChar(16) NOT NULL Primary Key,
	nama	VarChar(30) NOT NULL UNIQUE,
	alamat	VarChar(50),
	kontak	VarChar(15)
)
GO

CREATE TABLE FakturBeli (
	kode			VarChar(16) NOT NULL Primary Key,
	tanggal			DateTime NOT NULL,
	lunas			Bit Default(0)
)
GO

CREATE TABLE FakturJual (
	kode			VarChar(16) NOT NULL Primary Key,
	tanggal			DateTime NOT NULL,
	diskon			TinyInt NOT NULL Check (diskon Between 0 And 100),
	lunas			Bit Default(0),
	kode_pembeli	VarChar(16) NOT NULL Foreign Key References Pembeli (kode)
)
GO

CREATE TABLE Barang (
	kode			VarChar(16) NOT NULL Primary Key,
	nama			VarChar(30) NOT NULL UNIQUE,
	stok			SmallInt Default (0),
	kode_pemasok 	VarChar(16) NOT NULL Foreign Key References Pemasok (kode)
)
GO

CREATE TABLE HargaBarang (
	tanggal		DateTime NOT NULL Primary Key,
	kode_barang	VarChar(16) NOT NULL Foreign Key References Barang (kode),
	harga_beli	Int NOT NULL,
	harga_jual	Int NOT NULL
)
GO

CREATE TABLE DetailFakturBeli (
	kode_faktur		VarChar(16) NOT NULL Foreign Key References FakturBeli (kode),
	kode_barang		VarChar(16) NOT NULL Foreign Key References Barang (kode),
	jumlah_terbeli	TinyInt NOT NULL,

	Primary Key (kode_faktur, kode_barang)
)
GO

CREATE TABLE DetailFakturJual (
	kode_faktur		VarChar(16) NOT NULL Foreign Key References FakturJual (kode),
	kode_barang		VarChar(16) NOT NULL Foreign Key References Barang (kode),
	jumlah_terjual	TinyInt NOT NULL,

	Primary Key (kode_faktur, kode_barang)
)
GO

-- create fixture
EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
GO
EXEC sp_MSForEachTable 'DELETE FROM ?'
GO

-- Pemasok
INSERT INTO Pemasok VALUES ('P0001', 'Makmur Jaya', 'Jl Desa Makmur No. 22', '08132323')
INSERT INTO Pemasok VALUES ('P0002', 'Sekip Jaya', 'Jl Kota Baru No. 1', '021232323')
INSERT INTO Pemasok VALUES ('P0003', 'Tunas Bangsa', 'Jl Cendrawasih No. 321', '0711432423')

-- Pembeli
INSERT INTO Pembeli VALUES ('B0001', 'Ryan', 'Jl Jalanan No. 123', '0852525')
INSERT INTO Pembeli VALUES ('B0002', 'Rudi', 'Jl Polisi No. 545', '')
INSERT INTO Pembeli VALUES ('B0003', 'Rar', 'Jl Kembang No. 321', '')

-- Barang
INSERT INTO Barang VALUES ('I0001', 'Jam tangan CASIO', 22, 'P0001')
INSERT INTO Barang VALUES ('I0002', 'Binder Sinar Dunia', 55, 'P0002')
INSERT INTO Barang VALUES ('I0003', 'Flash Disk Kingstone 2GB', 12, 'P0003')
INSERT INTO Barang VALUES ('I0004', 'Mouse Razor', 4, 'P0001')
INSERT INTO Barang VALUES ('I0005', 'Keyboard Logitech', 7, 'P0002')

-- HargaBarang
INSERT INTO HargaBarang VALUES (GetDate(), 'I0001', 25000, 35000)
WAITFOR DELAY '00:00:01'
INSERT INTO HargaBarang VALUES (GetDate(), 'I0002', 15000, 25000)
WAITFOR DELAY '00:00:01'
INSERT INTO HargaBarang VALUES (GetDate(), 'I0003', 75000, 80000)
WAITFOR DELAY '00:00:01'
INSERT INTO HargaBarang VALUES (GetDate(), 'I0004', 40000, 55000)
WAITFOR DELAY '00:00:01'
INSERT INTO HargaBarang VALUES (GetDate(), 'I0005', 30000, 35000)

-- FakturBeli
INSERT INTO FakturBeli VALUES ('FB001', GetDate(), 1)
INSERT INTO FakturBeli VALUES ('FB002', GetDate(), 1)

-- FakturJual
INSERT INTO FakturJual VALUES ('FJ001', GetDate(), 1, 5, 'B0001')
INSERT INTO FakturJual VALUES ('FJ002', GetDate(), 0, 0, 'B0002')

-- DetailFakturBeli
INSERT INTO DetailFakturBeli VALUES ('FB001', 'I0001', 5)
INSERT INTO DetailFakturBeli VALUES ('FB001', 'I0004', 6)
INSERT INTO DetailFakturBeli VALUES ('FB002', 'I0002', 12)
INSERT INTO DetailFakturBeli VALUES ('FB002', 'I0005', 7)

-- DetailFakturJual
INSERT INTO DetailFakturJual VALUES ('FJ001', 'I0001', 3)
INSERT INTO DetailFakturJual VALUES ('FJ001', 'I0002', 5)
INSERT INTO DetailFakturJual VALUES ('FJ001', 'I0003', 6)
INSERT INTO DetailFakturJual VALUES ('FJ002', 'I0004', 4)
INSERT INTO DetailFakturJual VALUES ('FJ002', 'I0005', 6)
GO

-- HelperBarang
CREATE VIEW ShowAllItems AS
	SELECT Barang.kode, Barang.nama, Barang.stok, Pemasok.kode as kode_pemasok, Pemasok.nama as nama_pemasok, HargaBarang.harga_beli, HargaBarang.harga_jual, Convert(VarChar, BarangTerkini.tanggal_terakhir, 113) AS tanggal_terakhir --BarangTerkini.tanggal_terakhir
	FROM Barang INNER JOIN Pemasok ON Barang.kode_pemasok = Pemasok.kode INNER JOIN HargaBarang ON Barang.kode = HargaBarang.kode_barang INNER JOIN (
		SELECT Barang.kode, Max(HargaBarang.tanggal) AS tanggal_terakhir
		FROM Barang INNER JOIN Pemasok ON Barang.kode_pemasok = Pemasok.kode INNER JOIN HargaBarang ON Barang.kode = HargaBarang.kode_barang
		GROUP BY Barang.kode
	) BarangTerkini ON Barang.kode = BarangTerkini.kode
	AND BarangTerkini.tanggal_terakhir = HargaBarang.tanggal
GO

CREATE PROCEDURE AddNewItems (@kode_barang VarChar(16), @nama_barang VarChar(30), @kode_pemasok Char(5), @harga_beli Int, @harga_jual Int) AS
	BEGIN TRANSACTION
		INSERT INTO Barang VALUES(@kode_barang, @nama_barang, 0, @kode_pemasok)
		INSERT INTO HargaBarang VALUES(GetDate(), @kode_barang, @harga_beli, @harga_jual)
	COMMIT
GO

CREATE PROCEDURE AlterSelectedItem (@kode_barang VarChar(16), @nama_barang VarChar(30), @stok SmallInt, @kode_pemasok Char(5), @harga_beli Int, @harga_jual Int) AS
	BEGIN TRANSACTION
		UPDATE Barang SET nama = @nama_barang, stok = @stok, kode_pemasok = @kode_pemasok WHERE kode = @kode_barang
		INSERT INTO HargaBarang VALUES(GetDate(), @kode_barang, @harga_beli, @harga_jual)
	COMMIT
GO

CREATE VIEW BarangTersedia AS
	SELECT Barang.kode, Barang.nama, HargaBarang.harga_beli, HargaBarang.harga_jual, HargaBarang.tanggal
	FROM Barang
	INNER JOIN HargaBarang ON Barang.kode = Hargabarang.kode_barang
	INNER JOIN (
		SELECT Barang.kode, Max(HargaBarang.tanggal) AS tanggal
		FROM Barang	INNER JOIN HargaBarang ON Barang.kode = Hargabarang.kode_barang
		GROUP BY Barang.kode
	) HargaBarangTerakhir
	ON Barang.kode = HargaBarangTerakhir.kode
	AND HargaBarang.tanggal = HargaBarangTerakhir.tanggal
GO

-- HelperBarangDestroy
CREATE FUNCTION ExtractKodeBarang (@kode VarChar(16)) Returns VarChar(16) AS BEGIN
	DECLARE @extracted_kode VarChar(16)
	
	IF CharIndex('_deleted', @kode) > 0
		SET @extracted_kode = Left(@kode, CharIndex('_deleted', @kode) - 1)
	ELSE
		SET @extracted_kode = @kode
		
	RETURN @extracted_kode
END
GO

CREATE FUNCTION GetLatestDeleteID (@kode VarChar(16)) Returns SmallInt AS BEGIN
	DECLARE @delete_id SmallInt
	
	IF ( SELECT COUNT(*) FROM Barang WHERE kode LIKE @kode + '_deleted%' ) > 0 BEGIN
		SET @delete_id = (
			SELECT TOP 1 Convert(INT, Right(kode, 3))
			FROM Barang
			WHERE kode LIKE '12345_deleted%'
			ORDER BY kode DESC
		)
	END ELSE BEGIN
		SET @delete_id = -1
	END
	
	RETURN @delete_id
END
GO

CREATE FUNCTION GenerateNewDeleteID (@kode VarChar(16)) Returns VarChar(16) AS BEGIN
	DECLARE @new_id SmallInt
	SET @new_id = dbo.GetLatestDeleteID(@kode) + 1
	Return @kode + '_deleted' + Replicate('0', 3 - Len(@new_id)) + @new_id
END
GO	

CREATE PROCEDURE SafelyDeleteItem (@kode_barang VarChar(16)) AS
	BEGIN TRANSACTION
		DECLARE @new_kode VarChar(16)
		SET @new_kode = dbo.GenerateNewDeleteID(@kode_barang)
		
		UPDATE Barang SET kode = @new_kode WHERE kode = @kode_barang
		UPDATE HargaBarang SET kode_barang = @new_kode WHERE kode_barang = @kode_barang
		UPDATE DetailFakturBeli SET kode_barang = @new_kode WHERE kode_barang = @kode_barang
		UPDATE DetailFakturJual SET kode_barang = @new_kode WHERE kode_barang = @kode_barang
	COMMIT
GO

-- HelperPembelian
CREATE VIEW DetailFakturPembelian AS
	SELECT DISTINCT
		   FakturBeli.kode		AS kode_faktur,
		   FakturBeli.tanggal	AS tanggal_faktur,
		   HargaBarang.tanggal	AS tanggal_barang,
		   Barang.kode			AS kode_barang,
		   Barang.nama			AS nama_barang,
		   DetailFakturBeli.jumlah_terbeli,
		   Barang.kode_pemasok,
		   HargaBarang.harga_beli,
		   DetailFakturBeli.jumlah_terbeli * HargaBarang.harga_beli AS total_harga,
		   Pemasok.nama			AS nama_pemasok
	FROM FakturBeli
	INNER JOIN DetailFakturBeli	ON FakturBeli.kode = DetailFakturBeli.kode_faktur
	INNER JOIN Barang			ON Barang.kode = DetailFakturBeli.kode_barang
	INNER JOIN HargaBarang		ON Barang.kode = HargaBarang.kode_barang
	INNER JOIN Pemasok			ON Barang.kode_pemasok = Pemasok.kode
	INNER JOIN (
		SELECT FakturBeli.kode, Barang.kode as kode_barang, FakturBeli.tanggal AS tanggal_faktur, MAX(HargaBarang.tanggal) AS tanggal_barang
		FROM FakturBeli
		INNER JOIN DetailFakturBeli	ON FakturBeli.kode = DetailFakturBeli.kode_faktur
		INNER JOIN Barang			ON Barang.kode = DetailFakturBeli.kode_barang
		INNER JOIN HargaBarang		ON Barang.kode = HargaBarang.kode_barang
		WHERE HargaBarang.tanggal < FakturBeli.tanggal
		GROUP BY FakturBeli.kode, Barang.kode, FakturBeli.tanggal
	) HargaFaktur
	ON HargaBarang.tanggal = HargaFaktur.tanggal_barang
	AND FakturBeli.kode = HargaFaktur.kode
GO

-- Total Item
CREATE VIEW TotalItemTerbeliPerFaktur AS
	SELECT kode_faktur, Sum(jumlah_terbeli) AS total_barang
	FROM DetailFakturBeli
	GROUP BY kode_faktur
GO

CREATE VIEW TotalItemTerbeliPerPemasok AS
	SELECT nama_pemasok, Sum(jumlah_terbeli) AS total_barang
	FROM DetailFakturPembelian
	GROUP BY nama_pemasok
GO

CREATE VIEW TotalItemTerbeliPerBulan AS
	SELECT Cast(Year(tanggal_faktur) AS VarChar) + '-' + Cast(Month(tanggal_faktur) AS VarChar) + '-1' AS tanggal_faktur,
		   Sum(jumlah_terbeli) AS total_barang
	FROM DetailFakturPembelian
	GROUP BY Cast(Year(tanggal_faktur) AS VarChar) + '-' + Cast(Month(tanggal_faktur) AS VarChar) + '-1'
GO

-- Total Harga
CREATE VIEW TotalHargaPembelianPerFaktur AS
	SELECT kode_faktur, Sum(total_harga) AS harga
	FROM DetailFakturPembelian
	GROUP BY kode_faktur
GO

CREATE VIEW TotalHargaPembelianPerPemasok AS
	SELECT nama_pemasok, Sum(total_harga) AS harga
	FROM DetailFakturPembelian
	GROUP BY nama_pemasok
GO

CREATE VIEW TotalHargaPembelianPerBulan AS
	SELECT Cast(Year(tanggal_faktur) AS VarChar) + '-' + Cast(Month(tanggal_faktur) AS VarChar) + '-1' AS tanggal_faktur,
		   Sum(total_harga) AS harga
	FROM DetailFakturPembelian
	GROUP BY Cast(Year(tanggal_faktur) AS VarChar) + '-' + Cast(Month(tanggal_faktur) AS VarChar) + '-1'
GO

-- Hapus faktur
CREATE PROCEDURE HapusFakturBeli (@kode VarChar(16), @stok_ikut_berkurang Bit) AS
	BEGIN TRANSACTION
		IF @stok_ikut_berkurang = 1 BEGIN
			UPDATE B
			SET B.stok = B.stok - DFB.jumlah_terbeli
			FROM dbo.Barang AS B INNER JOIN dbo.DetailFakturBeli as DFB
			ON B.kode = DFB.kode_barang
			WHERE DFB.kode_faktur = @kode
		END
		
		DELETE FROM DetailFakturBeli WHERE kode_faktur = @kode
		DELETE FROM FakturBeli WHERE kode = @kode
	COMMIT
GO

CREATE PROCEDURE HapusSemuaFakturBeli (@stok_ikut_berkurang Bit) AS
	BEGIN TRANSACTION
		IF @stok_ikut_berkurang = 1 BEGIN
			UPDATE B
			SET B.stok = B.stok - DFB.jumlah_terbeli
			FROM dbo.Barang AS B INNER JOIN dbo.DetailFakturBeli as DFB
			ON B.kode = DFB.kode_barang
		END
		
		DELETE FROM DetailFakturBeli
		DELETE FROM FakturBeli
	COMMIT
GO

-- HelperPenjualan
CREATE VIEW DetailFakturPenjualan AS
	SELECT DISTINCT
		   FakturJual.kode		AS kode_faktur,
		   FakturJual.tanggal	AS tanggal_faktur,
		   FakturJual.diskon,
		   HargaBarang.tanggal	AS tanggal_barang,
		   Barang.kode			AS kode_barang,
		   Barang.nama			AS nama_barang,
		   DetailFakturJual.jumlah_terjual,
		   HargaBarang.harga_jual,
		   DetailFakturJual.jumlah_terjual * HargaBarang.harga_jual AS total_harga,
		   Pembeli.nama			AS nama_pembeli
	FROM FakturJual
	INNER JOIN DetailFakturJual	ON FakturJual.kode = DetailFakturJual.kode_faktur
	INNER JOIN Pembeli			ON FakturJual.kode_pembeli = Pembeli.kode
	INNER JOIN Barang			ON Barang.kode = DetailFakturJual.kode_barang
	INNER JOIN HargaBarang		ON Barang.kode = HargaBarang.kode_barang
	INNER JOIN (
		SELECT FakturJual.kode, Barang.kode as kode_barang, FakturJual.tanggal AS tanggal_faktur, MAX(HargaBarang.tanggal) AS tanggal_barang
		FROM FakturJual
		INNER JOIN DetailFakturJual	ON FakturJual.kode = DetailFakturJual.kode_faktur
		INNER JOIN Barang			ON Barang.kode = DetailFakturJual.kode_barang
		INNER JOIN HargaBarang		ON Barang.kode = HargaBarang.kode_barang
		WHERE HargaBarang.tanggal < FakturJual.tanggal
		GROUP BY FakturJual.kode, Barang.kode, FakturJual.tanggal
	) HargaFaktur
	ON HargaBarang.tanggal = HargaFaktur.tanggal_barang
	AND FakturJual.kode = HargaFaktur.kode
	AND Barang.kode = HargaFaktur.kode_barang
GO

-- Total Item
CREATE VIEW TotalItemTerjualPerFaktur AS
	SELECT kode_faktur, Sum(jumlah_terjual) AS total_barang
	FROM DetailFakturJual
	GROUP BY kode_faktur
GO

CREATE VIEW TotalItemTerjualPerPemasok AS
	SELECT nama_pembeli, Sum(jumlah_terjual) AS total_barang
	FROM DetailFakturPenjualan
	GROUP BY nama_pembeli
GO

CREATE VIEW TotalItemTerjualPerBulan AS
	SELECT Cast(Year(tanggal_faktur) AS VarChar) + '-' + Cast(Month(tanggal_faktur) AS VarChar) + '-1' AS tanggal_faktur,
		   Sum(jumlah_terjual) AS total_barang
	FROM DetailFakturPenjualan
	GROUP BY Cast(Year(tanggal_faktur) AS VarChar) + '-' + Cast(Month(tanggal_faktur) AS VarChar) + '-1'
GO

-- Total Harga
CREATE VIEW TotalHargaPenjualanPerFaktur AS
	SELECT kode_faktur, diskon, CONVERT(Int, Sum(total_harga) * (1 - (1 * diskon / 100.0))) AS harga
	FROM DetailFakturPenjualan
	GROUP BY kode_faktur, diskon
GO
	
CREATE VIEW TotalHargaPenjualanPerPemasok AS
	SELECT nama_pembeli, Sum(total_harga) AS harga
	FROM DetailFakturPenjualan
	GROUP BY nama_pembeli
GO

CREATE VIEW TotalHargaPenjualanPerBulan AS
	SELECT Cast(Year(tanggal_faktur) AS VarChar) + '-' + Cast(Month(tanggal_faktur) AS VarChar) + '-1' AS tanggal_faktur,
		   Sum(total_harga) AS harga
	FROM DetailFakturPenjualan
	GROUP BY Cast(Year(tanggal_faktur) AS VarChar) + '-' + Cast(Month(tanggal_faktur) AS VarChar) + '-1'
GO

-- Hapus faktur
CREATE PROCEDURE HapusFakturJual (@kode VarChar(16), @stok_ikut_berkurang Bit) AS
	BEGIN TRANSACTION
		IF @stok_ikut_berkurang = 1 BEGIN
			UPDATE B
			SET B.stok = B.stok + DFJ.jumlah_terjual
			FROM dbo.Barang AS B INNER JOIN dbo.DetailFakturJual as DFJ
			ON B.kode = DFJ.kode_barang
			WHERE DFJ.kode_faktur = @kode
		END
		
		DELETE FROM DetailFakturJual WHERE kode_faktur = @kode
		DELETE FROM FakturJual WHERE kode = @kode
	COMMIT
GO

CREATE PROCEDURE HapusSemuaFakturJual (@stok_ikut_berkurang Bit) AS
	BEGIN TRANSACTION
		IF @stok_ikut_berkurang = 1 BEGIN
			UPDATE B
			SET B.stok = B.stok + DFJ.jumlah_terjual
			FROM dbo.Barang AS B INNER JOIN dbo.DetailFakturJual as DFJ
			ON B.kode = DFJ.kode_barang
		END
		
		DELETE FROM DetailFakturJual
		DELETE FROM FakturJual
	COMMIT
GO