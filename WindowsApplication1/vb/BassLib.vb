Imports System.Runtime.InteropServices
Imports Un4seen.Bass

Public Class BassLib
    ''' <summary>
    ''' Частота дискретизайії
    ''' </summary>
    Private SampleRate As Integer = 44100
    ''' <summary>
    ''' Стан ініціалізації бібліотеки
    ''' </summary>
    Private InitDefaultDevice As Boolean
    ''' <summary>
    ''' Канал
    ''' </summary>
    Public Stream As Integer
    ''' <summary>
    ''' Гучність
    ''' </summary>
    Public Volume As Integer = 100

    Private _myDownloadProc As DOWNLOADPROC
    Private _data() As Byte

    Public lenght1 As Integer
    Public buffer1, user1 As String

    ''' <summary>
    ''' Ініціалізації бібліотеки Bass.dll
    ''' </summary>
    ''' <param name="SampleRate"></param>
    ''' <returns></returns>
    Private Function InitBass(SampleRate As Integer) As Boolean
        If (Not InitDefaultDevice) Then
            InitDefaultDevice = Bass.BASS_Init(-1, SampleRate, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)
        End If
        Return InitDefaultDevice
    End Function

    ''' <summary>
    ''' Програвання файлу
    ''' </summary>
    ''' <param name="FileName"></param>
    ''' <param name="Vol"></param>
    Public Sub Play_Stream(FileName As String, Vol As Integer)
        Stop_Stream()
        If (InitBass(SampleRate)) Then
            Stream = Bass.BASS_StreamCreateFile(FileName, 0, 0, BASSFlag.BASS_DEFAULT)
            If (Stream <> 0) Then
                Volume = Vol
                Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100)
                Bass.BASS_ChannelPlay(Stream, False)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Програвання URL
    ''' </summary>
    ''' <param name="URL"></param>
    ''' <param name="Vol"></param>
    Public Sub Play_URL(URL As String, Vol As Integer)
        If (Bass.BASS_ChannelIsActive(Stream) = BASSActive.BASS_ACTIVE_PAUSED) Then
            Bass.BASS_ChannelPlay(Stream, False)
        Else
            Stop_Stream()
            If (InitBass(SampleRate)) Then
                Stream = Bass.BASS_StreamCreateURL(URL, 0, BASSFlag.BASS_DEFAULT, Nothing, IntPtr.Zero)
                If (Stream <> 0) Then
                    Volume = Vol
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100)
                    Bass.BASS_ChannelPlay(Stream, False)
                End If
            End If
        End If
    End Sub

    Public Sub Pause_Stream()
        If (Bass.BASS_ChannelIsActive(Stream) = BASSActive.BASS_ACTIVE_PLAYING) Then
            Bass.BASS_ChannelPause(Stream)
        End If
    End Sub

    ''' <summary>
    ''' Зупинити програвання
    ''' </summary>
    Public Sub Stop_Stream()
        Bass.BASS_ChannelStop(Stream)
        Bass.BASS_StreamFree(Stream)
    End Sub

    ''' <summary>
    ''' Видобути довжину файлу в секундах
    ''' </summary>
    ''' <param name="Stream"></param>
    ''' <returns></returns>
    Public Function GetTimeOfStrem(Stream As Integer) As Integer
        Dim TimeBytes As Long = Bass.BASS_ChannelGetLength(Stream)
        Dim Time As Double = Bass.BASS_ChannelBytes2Seconds(Stream, TimeBytes)
        Return Int(Time)
    End Function

    ''' <summary>
    ''' Видобути позицію програвання файлу
    ''' </summary>
    ''' <param name="Stream"></param>
    ''' <returns></returns>
    Public Function GetPosOfStream(Stream As Integer) As Integer
        Dim PositionBytes As Long = Bass.BASS_ChannelGetPosition(Stream)
        Dim Position As Double = Bass.BASS_ChannelBytes2Seconds(Stream, PositionBytes)
        Return Int(Position)
    End Function

    ''' <summary>
    ''' Встановити позицію програвання
    ''' </summary>
    ''' <param name="Stream"></param>
    ''' <param name="Position"></param>
    Public Sub SetPosOfScroll(Stream As Integer, Position As Integer)
        Dim pos As Double = Position
        Bass.BASS_ChannelSetPosition(Stream, pos)
    End Sub

    ''' <summary>
    ''' Встановлення гучності
    ''' </summary>
    ''' <param name="Stream"></param>
    ''' <param name="Vol"></param>
    Public Sub SetVolumeToStream(Stream As Integer, Vol As Integer)
        Volume = Vol
        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100)
    End Sub

    ''' <summary>
    ''' Видобути відсоток завантаження файлу
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDownloadProgress(Stream) As Integer
        Dim progress As Single
        ' file length
        Dim len As Integer = Bass.BASS_StreamGetFilePosition(Stream, BASSStreamFilePosition.BASS_FILEPOS_END)
        ' download progress
        Dim down As Integer = Bass.BASS_StreamGetFilePosition(Stream, BASSStreamFilePosition.BASS_FILEPOS_DOWNLOAD)
        ' get channel info
        Dim info As BASS_CHANNELINFO = Bass.BASS_ChannelGetInfo(Stream)
        ' streaming in blocks?
        If info.flags And BASSFlag.BASS_STREAM_BLOCK <> BASSFlag.BASS_DEFAULT Then
            ' decode position
            Dim dec As Integer = Bass.BASS_StreamGetFilePosition(Stream, BASSStreamFilePosition.BASS_FILEPOS_CURRENT)
            ' percentage of buffer used
            progress = (down) * 100.0F / len
            If progress > 100 Then
                progress = 100 ' restrict to 100 (can be higher)
            End If
        Else
            ' percentage of file downloaded
            progress = down * 100.0F / len
        End If
        Return progress
    End Function
End Class
