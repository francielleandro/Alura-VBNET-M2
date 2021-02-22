
Imports _2___ByteBank.ByteBank

Public Class ContaCorrente

    Public Titular As Cliente
    Public Agencia As Integer
    Public Conta As Integer
    Public Extrato As String = ""

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


End Class




