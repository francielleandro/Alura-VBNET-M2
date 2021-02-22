Public Class Frm_Principal_02
    Dim contaDaGabriela As New ContaCorrente
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Principal_02.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_ValorSacar.Text = "Valor a ser sacado"
        Btn_Sacar.Text = "Efetuar saque"
        Btn_Depositar.Text = "Depositar"

        Lbl_Saldo.Text = "Novo Saldo"
        Lbl_Resultado.Text = "Resultado do saque"
        Lbl_SaldoAtual.Text = "Saldo Atual"

        contaDaGabriela.Titular = "Gabriela"
        contaDaGabriela.Conta = 865123
        contaDaGabriela.Agencia = 4009
        contaDaGabriela.Saldo = 100

        Txt_SaldoAtual.Text = contaDaGabriela.Saldo


    End Sub

    Private Sub Btn_Sacar_Click(sender As Object, e As EventArgs) Handles Btn_Sacar.Click
        Dim valorSacar As Double = Val(Txt_ValorSacar.Text)

        Txt_Resultado.Text = ""
        Txt_Saldo.Text = ""

        Dim retornoSaque As Boolean = contaDaGabriela.Sacar(valorSacar)

        Txt_Saldo.Text = contaDaGabriela.Saldo
        If (retornoSaque) Then
            Txt_Resultado.Text = "Saque efetuado com sucesso!"
        Else
            Txt_Resultado.Text = "Não foi possível realizar esta operação, saldo indisponível"
        End If
        Txt_SaldoAtual.Text = contaDaGabriela.Saldo

    End Sub

    Private Sub Btn_Depositar_Click(sender As Object, e As EventArgs) Handles Btn_Depositar.Click
        Dim valorDepositar As Double = Val(Txt_ValorSacar.Text)
        contaDaGabriela.Depositar(valorDepositar)
        Txt_Saldo.Text = contaDaGabriela.Saldo
        Txt_SaldoAtual.Text = contaDaGabriela.Saldo
        Txt_Resultado.Text = "Deposíto efetuado com sucesso!"

    End Sub
End Class