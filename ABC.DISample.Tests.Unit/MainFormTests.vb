Imports System.Text
Imports ABC.Clients
Imports ABC.DAL
Imports ABC.Sample
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Moq

<TestClass()> Public Class MainFormTests

    <TestMethod()>
    Public Sub WhenButtonIsClickedSubFormShouldBeDisplayed()

        ' mock the SubForm
        Dim mockSubForm As New Mock(Of ISubForm)
        ' mock the factory that creates the mocked form
        Dim formFactory As New Mock(Of IFormFactory)
        formFactory.Setup(Function(x) x.Create(Of ISubForm)).Returns(mockSubForm.Object)

        Dim dal As New Mock(Of IDataFunctions)
        Dim clientEng As New Mock(Of IClientEngine)


        ' create the form and simulate the button click. 
        Dim mainForm As New MainForm(formFactory.Object, dal.Object, clientEng.Object)
        mainForm.ShowSubForm()

        formFactory.Verify(Function(x) x.Create(Of ISubForm), Times.Once) ' verify the correct form was created
        mockSubForm.Verify(Sub(x) x.ShowDialog(), Times.Once) ' verify that the form was shown

    End Sub

End Class