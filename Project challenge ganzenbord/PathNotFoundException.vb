Public Class PathNotFoundException
    Inherits ApplicationException

    Public Sub New(ByVal message As String)
        MyBase.New(message)
        Form1.AddToChatLog("ERROR: Path not found", Color.PaleVioletRed)
        Form1.BtnReady.Enabled = False
        MsgBox("Give in another map this one doesn't qualify")
        continueGame = False
    End Sub
End Class
