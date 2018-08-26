Imports ABC.DAL

Public Class ClientEngine
    Implements IClientEngine

    Private m_DAL As IDataFunctions

    Public Sub New(dal As IDataFunctions)
        m_DAL = dal
    End Sub

    Public Function GetClients() As IEnumerable(Of Client) Implements IClientEngine.GetClients
        Dim col = New List(Of Client)
        col.Add(New Client() With {.Code = "TST", .Name = "Test Client"})
        col.Add(New Client() With {.Code = "NOR", .Name = "Wells Fargo"})

        Return col
    End Function

End Class
