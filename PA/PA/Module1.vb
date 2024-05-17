Imports MySql.Data.MySqlClient
Public Module Module1
    Public idxUbah As Integer
    Public idxBuat As Integer
    Public idxSurat As Integer
    Public Function getLastNoSurat() As Integer
        CMD = New MySqlCommand("Select no_surat from tb_surat", CONN)
        RD = CMD.ExecuteReader
        Dim noSuratList As New List(Of Integer)
        While RD.Read()
            noSuratList.Add(RD("no_surat"))
        End While
        RD.Close()
        If noSuratList.Count = 0 Then
            Return 0
        Else
            Dim maxNoSurat As Integer = noSuratList.Max()
            Return maxNoSurat
        End If
    End Function
End Module
