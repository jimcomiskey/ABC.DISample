Imports ABC.Clients

Public Interface IClientEngine
    Function GetClients() As IEnumerable(Of Client)
End Interface
