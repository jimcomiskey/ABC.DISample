Imports ABC.DAL

Public Class SubForm
    Private m_DAL As IDataFunctions
    Public Sub New(dal As IDataFunctions)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_DAL = dal

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(m_DAL.GetData())
    End Sub
End Class