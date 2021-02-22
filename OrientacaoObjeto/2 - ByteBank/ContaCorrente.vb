
Imports _2___ByteBank.ByteBank

Public Class ContaCorrente

    Public Titular As Cliente
    Public Agencia As Integer
    Public Conta As Integer
    Private Saldo As Double = 100
    Public Extrato As String = ""

    Public Function ObterSaldo() As Double
        Return Saldo
    End Function

    Public Function Sacar(ValorSacar As Double) As Boolean

        Dim Retorno As Boolean
        If Saldo < ValorSacar Then
            Retorno = False
        Else
            Saldo -= ValorSacar
            Retorno = True
        End If
        Return Retorno

    End Function

    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean

        Dim Retorno As Boolean
        If ObterSaldo < ValorTransferencia Then
            Retorno = False
        Else
            Saldo -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If
        Return Retorno

    End Function

    Public Sub Depositar(ValorDepositar As Double)

        Saldo += ValorDepositar

    End Sub


End Class




