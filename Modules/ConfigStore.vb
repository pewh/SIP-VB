Module ConfigStore

    Public defaultRegistryPath As String

    Function getConfigValue(ByVal keyword As String) As String
        Return My.Computer.Registry.GetValue(defaultRegistryPath, keyword, "")
    End Function

    Sub setConfigValue(ByVal valueName As String, ByVal value As String)
        My.Computer.Registry.SetValue(defaultRegistryPath, valueName, value)
    End Sub

    Sub storeNewConfigIfNotExists(ByVal configs As Dictionary(Of String, String))
        For Each config In configs
            If getConfigValue(config.Key) = "" Then
                setConfigValue(config.Key, config.Value)
            End If
        Next

    End Sub

End Module

'Public defaultConfigs As New Dictionary(Of String, String)
'ConfigStore.defaultRegistryPath = "HKEY_CURRENT_USER\Software\SMA Arinda\Bimbingan Konseling\database"