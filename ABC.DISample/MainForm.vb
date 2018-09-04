Imports System.ComponentModel
Imports ABC.Clients
Imports ABC.DAL
Imports ABC.Sample

Public Class MainForm
    Private ReadOnly m_FormFactory As IFormFactory
    Private ReadOnly m_DAL As IDataFunctions
    Private ReadOnly m_ClientEngine As IClientEngine
    Private ReadOnly m_MessageBoxService As IMessageBoxService

    Private m_ClientsList As BindingList(Of Client)
    Public ReadOnly Property ClientsList As BindingList(Of Client)
        Get
            Return m_ClientsList
        End Get
    End Property

    Public Sub New(formFactory As IFormFactory, dal As IDataFunctions, clientEng As IClientEngine, messageBoxService As IMessageBoxService)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.m_FormFactory = formFactory
        Me.m_DAL = dal
        Me.m_ClientEngine = clientEng
        Me.m_MessageBoxService = messageBoxService
    End Sub
    Private Sub btnShowSubform_Click(sender As Object, e As EventArgs) Handles btnShowSubform.Click
        ShowSubFormButtonClicked()
    End Sub
    ' public method exposes the button click behavior as a public behavior of the form.
    ' this could be moved to a Presenter using the Model View Presenter pattern,
    ' making the Presenter the surface for a testable API.
    Public Sub ShowSubFormButtonClicked()
        Dim subForm = m_FormFactory.Create(Of ISubForm)
        subForm.ShowDialog()
    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        GetDataButtonClicked()
    End Sub
    Public Sub GetDataButtonClicked()
        m_MessageBoxService.Alert(m_DAL.GetData(), "Simple Test")
    End Sub

    Private Sub btnGetClients_Click(sender As Object, e As EventArgs) Handles btnGetClients.Click
        GetClientsButtonClicked()
    End Sub
    Public Sub GetClientsButtonClicked()
        m_ClientsList = New BindingList(Of Client)(m_ClientEngine.GetClients())
        ClientBindingSource.DataSource = m_ClientsList
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteClientButtonClicked()
    End Sub
    Public Sub DeleteClientButtonClicked()
        If m_MessageBoxService.Confirm($"Are you sure you want to delete client ", "Delete Client?") = DialogResult.Yes Then
            m_ClientsList.Remove(ClientBindingSource.Current)
        End If
    End Sub

    Public Sub SelectClient(client As Client)
        ClientBindingSource.Position = m_ClientsList.IndexOf(client)
    End Sub

    Private Sub btnSelectLastItem_Click(sender As Object, e As EventArgs) Handles btnSelectLastItem.Click
        SelectClient(m_ClientsList.Last)
    End Sub
End Class
