
Imports _2___ByteBank.ByteBank

Public Class ContaCorrente
#Region "Construtores"
    Public Sub New(m_saldo As Double)
        Saldo = m_saldo
    End Sub
#End Region
#Region "Propriedades"

    Private m_titular As Cliente
    Public Property Titular As Cliente
        Get
            Return m_titular
        End Get
        Set(value As Cliente)
            m_titular = value
        End Set
    End Property

    Private m_agencia As Integer
    Public Property Agencia
        Get
            Return m_agencia
        End Get
        Set(value)
            m_agencia = value
        End Set
    End Property

    Private m_conta As Integer
    Public Property Conta
        Get
            Return m_conta
        End Get
        Set(value)
            m_conta = value
        End Set
    End Property

    Public m_extrato As String = ""
    Public Property Extrato
        Get
            Return m_extrato
        End Get
        Set(value)
            m_extrato = value
        End Set
    End Property

    Private m_saldo As Double = 100
    Public Property Saldo As Double
        Get
            Return m_saldo
        End Get

        Set(value As Double)
            If value < 0 Then
                m_saldo = 0
            Else
                m_saldo = value
            End If
        End Set

    End Property
#End Region
#Region "Metodos"

    'Public Sub SetSaldo(SaldoInicial As Double)
    '    If SaldoInicial < 0 Then
    '        m_saldo = 0
    '    Else
    '        m_saldo = SaldoInicial
    '    End If
    'End Sub

    'Public Function GetSaldo() As Double
    '    Return m_saldo
    'End Function

    Public Function Sacar(ValorSacar As Double) As Boolean

        Dim Retorno As Boolean
        If m_saldo < ValorSacar Then
            Retorno = False
        Else
            m_saldo -= ValorSacar
            Retorno = True
        End If
        Return Retorno

    End Function

    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean

        Dim Retorno As Boolean
        If Saldo < ValorTransferencia Then
            Retorno = False
        Else
            m_saldo -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If
        Return Retorno

    End Function

    Public Sub Depositar(ValorDepositar As Double)

        m_saldo += ValorDepositar

    End Sub

#End Region

End Class




