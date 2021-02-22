Public Class Frm_Principal_02
    Dim contaDaGabriela As New ContaCorrente
    Dim contaDoBruno As New ContaCorrente
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Principal_02.Text = "1 - Primeira Classe - Formulário 02"
        'Inicializando dados gabriela'
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

        Txt_SaldoAtual.ReadOnly = True
        Txt_Saldo.ReadOnly = True
        Txt_extrado.ReadOnly = True
        Txt_Resultado.ReadOnly = True

        'Inicializando dados bruno'

        Lbl_ValorSacarBruno.Text = "Valor a ser sacado"
        Btn_SacarBruno.Text = "Efetuar saque"
        Btn_DepositarBruno.Text = "Depositar"

        Lbl_SaldoBruno.Text = "Novo Saldo"
        Lbl_ResultadoBruno.Text = "Resultado do saque"
        Lbl_saldoAtualBruno.Text = "Saldo Atual"

        contaDoBruno.Titular = "Gabriela"
        contaDoBruno.Conta = 865123
        contaDoBruno.Agencia = 4009
        contaDoBruno.Saldo = 100

        Txt_saldoAtualBruno.Text = contaDaGabriela.Saldo

        Txt_saldoAtualBruno.ReadOnly = True
        Txt_SaldoBruno.ReadOnly = True
        Txt_ExtratoBruno.ReadOnly = True
        Txt_ResultadoBruno.ReadOnly = True


    End Sub

    Private Sub Btn_Sacar_Click(sender As Object, e As EventArgs) Handles Btn_Sacar.Click
        Dim valorSacar As Double = Val(Txt_ValorSacar.Text)

        Txt_Resultado.Text = ""
        Txt_Saldo.Text = ""

        Dim retornoSaque As Boolean = contaDaGabriela.Sacar(valorSacar)

        Txt_Saldo.Text = contaDaGabriela.Saldo
        If (retornoSaque) Then
            Txt_Resultado.Text = "Saque efetuado com sucesso!"
            contaDaGabriela.Extrto += Now.ToString + " Saque de " + valorSacar.ToString + " saldo " + contaDaGabriela.Saldo.ToString + vbCrLf
            Txt_extrado.Text = contaDaGabriela.Extrto
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
        Txt_Resultado.Text = "Depósito efetuado com sucesso!"
        contaDaGabriela.Extrto += Now.ToString + " Deposíto de " + valorDepositar.ToString + " saldo " + contaDaGabriela.Saldo.ToString + vbCrLf

        Txt_extrado.Text = contaDaGabriela.Extrto

    End Sub

    Private Sub Btn_DepositarBruno_Click(sender As Object, e As EventArgs) Handles Btn_DepositarBruno.Click
        Dim valorSacar As Double = Val(Txt_ValorSacar.Text)

        Txt_ResultadoBruno.Text = ""
        Txt_SaldoBruno.Text = ""

        Dim retornoSaque As Boolean = contaDoBruno.Sacar(valorSacar)

        Txt_SaldoBruno.Text = contaDoBruno.Saldo
        If (retornoSaque) Then
            Txt_ResultadoBruno.Text = "Saque efetuado com sucesso!"
            contaDoBruno.Extrto += Now.ToString + " Saque de " + valorSacar.ToString + " saldo " + contaDoBruno.Saldo.ToString + vbCrLf
            Txt_ExtratoBruno.Text = contaDoBruno.Extrto
        Else
            Txt_ResultadoBruno.Text = "Não foi possível realizar esta operação, saldo indisponível"
        End If
        Txt_saldoAtualBruno.Text = contaDoBruno.Saldo
    End Sub

    Private Sub Btn_SacarBruno_Click(sender As Object, e As EventArgs) Handles Btn_SacarBruno.Click

        Dim valorDepositar As Double = Val(Txt_ValorSacar.Text)
        contaDoBruno.Depositar(valorDepositar)
        Txt_SaldoBruno.Text = contaDoBruno.Saldo
        Txt_saldoAtualBruno.Text = contaDoBruno.Saldo
        Txt_ResultadoBruno.Text = "Depósito efetuado com sucesso!"
        contaDoBruno.Extrto += Now.ToString + " Deposíto de " + valorDepositar.ToString + " saldo " + contaDoBruno.Saldo.ToString + vbCrLf

        Txt_ExtratoBruno.Text = contaDoBruno.Extrto
    End Sub
End Class