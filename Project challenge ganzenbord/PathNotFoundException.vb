Public Class PathNotFoundException
    Inherits ApplicationException

    Public Sub New(ByVal message As String)
        MyBase.New(message)
        Form1.AddToChatLog("ERROR: Pad niet gevonden", Color.PaleVioletRed)
        continueGame = False
    End Sub
End Class
