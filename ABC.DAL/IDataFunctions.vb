Public Interface IDataFunctions
    Function GetData() As String
    Function GetRecordset(sql As String) As DataTable
End Interface
