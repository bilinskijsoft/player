Public Class Vars
    ''' <summary>
    ''' Список файлів
    ''' </summary>
    Public Files As New List(Of String)()

    ''' <summary>
    ''' Список файлів реклами
    ''' </summary>
    Public ComercialFiles As New List(Of String)()


    ''' <summary>
    ''' Видобути ім'я файлу
    ''' </summary>
    ''' <param name="File"></param>
    ''' <returns></returns>
    Public Function GetFileName(File As String)
        Dim tmp() As String
        tmp = File.Split("\")
        Return tmp(tmp.Length - 1)
    End Function


End Class
