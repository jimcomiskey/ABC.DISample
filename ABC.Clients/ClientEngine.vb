Imports ABC.DAL

Public Class ClientEngine
    Implements IClientEngine

    Private m_DAL As IDataFunctions

    Public Sub New(dal As IDataFunctions)
        m_DAL = dal
    End Sub

    Public Function GetClients() As IEnumerable(Of Client) Implements IClientEngine.GetClients

        Dim dt As DataTable = m_DAL.GetRecordset("select * from CLIENTS")
        Dim col = New List(Of Client)

        For Each dr As DataRow In dt.Rows
            col.Add(New Client() With {.Code = dr("CLIENT_CODE").ToString, .Name = dr("CLIENT_NAME").ToString})
        Next

        Return col
    End Function

End Class
