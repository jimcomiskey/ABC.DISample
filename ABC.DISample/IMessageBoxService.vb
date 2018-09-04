Public Interface IMessageBoxService
    Sub Alert(text As String, caption As String, Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.None)
    Function Confirm(confirmText As String, confirmCaption As String) As DialogResult
End Interface
