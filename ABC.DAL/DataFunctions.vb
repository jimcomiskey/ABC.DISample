Imports ABC.DAL

Public Class DataFunctions
    Implements IDataFunctions
    Public Function GetData() As String Implements IDataFunctions.GetData
        Return "I get data!"
    End Function

    Public Function GetRecordset(sql As String) As DataTable Implements IDataFunctions.GetRecordset
        Dim fakeDataTable As New DataTable()
        fakeDataTable.Columns.Add("CLIENT_CODE", GetType(String))
        fakeDataTable.Columns.Add("CLIENT_NAME", GetType(String))

        Dim dr = fakeDataTable.NewRow()
        dr("CLIENT_CODE") = "TST"
        dr("CLIENT_NAME") = "Test Client"
        fakeDataTable.Rows.Add(dr)

        dr = fakeDataTable.NewRow()
        dr("CLIENT_CODE") = "ABC"
        dr("CLIENT_NAME") = "ABC Client"
        fakeDataTable.Rows.Add(dr)

        Return fakeDataTable
    End Function
End Class
