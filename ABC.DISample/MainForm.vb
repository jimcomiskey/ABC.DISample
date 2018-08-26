Imports ABC.Clients
Imports ABC.DAL

Public Class MainForm
    Private ReadOnly m_FormFactory As IFormFactory
    Private ReadOnly m_DAL As IDataFunctions
    Private ReadOnly m_ClientEngine As IClientEngine

    Public Sub New(formFactory As IFormFactory, dal As IDataFunctions, clientEng As IClientEngine)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.m_FormFactory = formFactory
        Me.m_DAL = dal
        Me.m_ClientEngine = clientEng
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim subForm = m_FormFactory.Create(Of SubForm)
        subForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(m_DAL.GetData())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClientBindingSource.DataSource = m_ClientEngine.GetClients()
    End Sub
End Class
