Public Class MessageBoxService
    Implements IMessageBoxService
    Public Function Confirm(confirmText As String, confirmCaption As String) As DialogResult Implements IMessageBoxService.Confirm
        Return MessageBox.Show(text:=confirmText, caption:=confirmCaption, buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Question)
    End Function
    Public Sub Alert(text As String, caption As String, Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.None) Implements IMessageBoxService.Alert
        MessageBox.Show(text, caption, buttons, icon)
    End Sub

End Class
