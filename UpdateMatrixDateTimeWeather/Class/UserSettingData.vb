Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

<Serializable>
Public Structure UserSettingData

    Public ReadOnly Property Instance As UserSettingData
        Get
            Return ReadFromBinFile()
        End Get
    End Property

    <XmlIgnore>
    Public Property FileName() As String

    'Public DateTimeFormat As String
    'Public CustomText As String
    Public Latitude As String
    Public Longitude As String
    Public MatrixWidth As Integer
    Public AutoStart As Boolean
    Public StartMinimized As Boolean
    Public IPAddresses As String
    Public ToggleOnOnStart As Boolean
    Public ToggleOffOnClose As Boolean

    Public Data As List(Of TextStyles)

    Public Sub New(filename As String)
        Me.FileName = filename
    End Sub

    Public Sub Save()
        Using fs As FileStream = File.Create(FileName)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, Me)
        End Using

        MsgBox($"Settings successfully saved.", MsgBoxStyle.Information, "Build")
    End Sub

    Public Sub SaveSilent()
        Using fs As FileStream = File.Create(FileName)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, Me)
        End Using
    End Sub

    Public Function ReadFromFile() As UserSettingData
        If Not File.Exists(FileName) Then
            Return New UserSettingData(FileName)
        End If

        Try
            Dim ser = New XmlSerializer(GetType(UserSettingData))
            Dim reader As TextReader = New StreamReader(FileName)
            Dim instance = CType(ser.Deserialize(reader), UserSettingData)
            reader.Close()
            Return instance
        Catch ex As Exception
            Return New UserSettingData(FileName)
        End Try
    End Function

    Public Function ReadFromBinFile() As UserSettingData
        If Not File.Exists(FileName) Then
            Return New UserSettingData(FileName)
        End If

        Try
            Using fs As FileStream = File.OpenRead(FileName)
                Dim formatter As New BinaryFormatter
                Dim instance = CType(formatter.Deserialize(fs), UserSettingData)
                Return instance
            End Using
        Catch ex As Exception
            Return New UserSettingData(FileName)
        End Try
    End Function

End Structure

<Serializable>
Public Structure TextStyles

    Public TextType As TextType
    Public TextString As String
    Public Interval As Integer
    Public DateTime As Date

End Structure

Public Enum TextType
    Datetime
    Weather
    CustomText
    Countdown
End Enum