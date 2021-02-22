Public Class ContaCorrente

    Public Titular As String
    Public Agencia As Integer
    Public Conta As Integer
    Public Saldo As Integer
    Public Extrto As String


    Public Function Sacar(ValorSacar As Double)

        If (Saldo >= ValorSacar) Then
            Saldo -= ValorSacar
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Depositar(ValorDeposito As Double)
        Saldo += ValorDeposito
    End Sub

End Class