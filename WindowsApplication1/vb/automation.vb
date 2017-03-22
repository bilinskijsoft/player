Public Class Automation
    ''' <summary>
    ''' Інтервал Програвання Реклами
    ''' </summary>
    Public CommercialInterval As Integer

    ''' <summary>
    ''' Чи програвалась рекама(для автоматизації)
    ''' </summary>
    Public CommercialPlayed As Boolean

    Public CurrentTrackNum As Integer

    Public PlayingCommercial As Boolean

    Public CurrentCommercialTrackNum As Integer

    ''' <summary>
    ''' Функція повертая істину якщо потрібно програти рекламу
    ''' </summary>
    ''' <returns></returns>
    Public Function NeedToPlayCommercial() As Boolean
        Return (CurrentTrackNum Mod CommercialInterval = 0) And (CommercialPlayed = False) And (CurrentTrackNum <> 0)
    End Function




End Class
