Public Class Client
    Private m_sCode As String
    Public Property Code() As String
        Get
            Return m_sCode
        End Get
        Set(ByVal value As String)
            m_sCode = value
        End Set
    End Property
    Private m_sName As String
    Public Property Name() As String
        Get
            Return m_sName
        End Get
        Set(ByVal value As String)
            m_sName = value
        End Set
    End Property
End Class
