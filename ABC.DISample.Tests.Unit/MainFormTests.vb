Imports System.Text
Imports ABC.Clients
Imports ABC.DAL
Imports ABC.Sample
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Moq
Imports System.Windows.Forms

<TestClass()> Public Class MainFormTests

    <TestMethod()>
    Public Sub SubFormButtonClicked()

        ' mock the SubForm
        Dim mockSubForm As New Mock(Of ISubForm)
        ' mock the factory that creates the mocked form
        Dim formFactory As New Mock(Of IFormFactory)
        formFactory.Setup(Function(x) x.Create(Of ISubForm)).Returns(mockSubForm.Object)
        Dim mockMessageService As New Mock(Of IMessageBoxService)

        Dim dal As New Mock(Of IDataFunctions)
        Dim clientEng As New Mock(Of IClientEngine)

        ' create the form
        Dim mainForm As New MainForm(formFactory.Object, dal.Object, clientEng.Object, mockMessageService.Object)

        ' call button click's public method
        mainForm.ShowSubFormButtonClicked()

        formFactory.Verify(Function(x) x.Create(Of ISubForm), Times.Once) ' verify the correct form was created
        mockSubForm.Verify(Sub(x) x.ShowDialog(), Times.Once) ' verify that the form was shown

    End Sub

    <TestMethod()>
    Public Sub GetDataButtonClicked()
        Dim dal As New Mock(Of IDataFunctions)
        Dim clientEng As New Mock(Of IClientEngine)
        Dim formFactory As New Mock(Of IFormFactory)
        Dim mockMessageService As New Mock(Of IMessageBoxService)

        dal.Setup(Function(x) x.GetData()).Returns("Expected data")

        ' create the form
        Dim mainForm As New MainForm(formFactory.Object, dal.Object, clientEng.Object, mockMessageService.Object)

        ' call button click's public method
        mainForm.GetDataButtonClicked()

        ' verify that the GetData function was called
        dal.Verify(Function(x) x.GetData(), Times.Once)
        ' verify that the message displayed the expected values
        mockMessageService.Verify(Sub(x) x.Alert("Expected data", "Simple Test", MessageBoxButtons.OK, MessageBoxIcon.None), Times.Once)
    End Sub

    <TestMethod()>
    Public Sub GetClientsButtonClicked()
        Dim clientEng As Mock(Of IClientEngine) = MockClientEngine()

        Dim mainForm As MainForm = CreateMainFormForClientTests(clientEng, New Mock(Of IMessageBoxService))

        ' call button click's public method
        mainForm.GetClientsButtonClicked()

        ' verify that the client engine was called
        clientEng.Verify(Function(x) x.GetClients(), Times.Once)

        Assert.AreEqual(2, mainForm.ClientsList.Count)
    End Sub

    Private Shared Function MockClientEngine() As Mock(Of IClientEngine)
        Dim clientEng As New Mock(Of IClientEngine)

        Dim testclientList = New List(Of Client)
        testclientList.Add(New Client() With {.Code = "JIM", .Name = "Jim Comiskey"})
        testclientList.Add(New Client() With {.Code = "TST", .Name = "Test Client"})

        clientEng.Setup(Function(x) x.GetClients()).Returns(testclientList)
        Return clientEng
    End Function

    <TestMethod()>
    Public Sub DeleteClientAndConfirm()
        Dim mockMessageService = New Mock(Of IMessageBoxService)
        mockMessageService.Setup(Function(x) x.Confirm(It.IsAny(Of String), "Delete Client?")).Returns(DialogResult.Yes)

        Dim mainForm As MainForm = CreateMainFormForClientTests(MockClientEngine(), mockMessageService)

        ' call button click's public method
        mainForm.GetClientsButtonClicked()

        Dim clientToDelete = mainForm.ClientsList.First()

        mainForm.SelectClient(clientToDelete)

        Dim oldClientsListCount = mainForm.ClientsList.Count

        mainForm.DeleteClientButtonClicked()

        Assert.AreEqual(oldClientsListCount - 1, mainForm.ClientsList.Count)
    End Sub

    <TestMethod()>
    Public Sub DeleteClientButCancel()
        Dim mockMessageService = New Mock(Of IMessageBoxService)
        mockMessageService.Setup(Function(x) x.Confirm(It.IsAny(Of String), "Delete Client?")).Returns(DialogResult.No)

        Dim mainForm As MainForm = CreateMainFormForClientTests(MockClientEngine(), mockMessageService)

        ' call button click's public method
        mainForm.GetClientsButtonClicked()

        Dim clientToDelete = mainForm.ClientsList.First()

        mainForm.SelectClient(clientToDelete)

        Dim oldClientsListCount = mainForm.ClientsList.Count

        mainForm.DeleteClientButtonClicked()

        ' user cancelled, list should stay the same
        Assert.AreEqual(oldClientsListCount, mainForm.ClientsList.Count)
    End Sub

    Private Function CreateMainFormForClientTests(clientEng As Mock(Of IClientEngine), mockMessageService As Mock(Of IMessageBoxService)) As MainForm
        Dim dal As New Mock(Of IDataFunctions)

        Dim formFactory As New Mock(Of IFormFactory)


        ' create the form
        Dim mainForm As New MainForm(formFactory.Object, dal.Object, clientEng.Object, mockMessageService.Object)
        Return mainForm
    End Function
End Class