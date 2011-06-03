Public Class PathNotFoundException
    Inherits ApplicationException

    Public Sub New(ByVal message As String)
        MyBase.New(message)
        Form1.AddToChatLog("ERROR: Path not found", Color.PaleVioletRed)
        Form1.BtnReady.Enabled = False
        continueGame = False
    End Sub
End Class
