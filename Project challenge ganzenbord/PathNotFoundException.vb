Public Class PathNotFoundException
    Inherits ApplicationException
    'Door Joeri
    'de exception class
    'vrijdag 2 juni 13.00
    Public Sub New(ByVal message As String)
        MyBase.New(message)
        Form1.AddToChatLog("ERROR: Path not found", Color.PaleVioletRed)
        Form1.BtnReady.Enabled = False
        continueGame = False
    End Sub
End Class
