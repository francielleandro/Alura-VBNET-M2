Public Class Frm_Principal_01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "1 - Primeira Classe"

        Lbl_Principal.Text = "1 - Primeira Classe"

        Btn_Acao.Text = "Clique aqui"

        Btn_Acao2.Text = "Conta Bruno"

        Btn_ValRef.Text = "Clique aqui"

    End Sub

    Private Sub Btn_Acao_Click(sender As Object, e As EventArgs) Handles Btn_Acao.Click

        'Dim Titular As String = "Gabriela"
        'Dim Agencia As Integer = 863
        'Dim Conta As Integer = 863123
        'Dim Saldo As Double = 100

        Dim ContaCorrente As New ContaCorrente

        ContaCorrente.Titular = "Gabriela"
        ContaCorrente.Conta = 400915912
        ContaCorrente.Agencia = 4009
        ContaCorrente.Saldo = Val(Txt_Saldo.Text)

        Lbl_Saldo.Text = "Saldo"
        Lbl_Incremento.Text = "Incremento"


        MsgBox("O saldo da conta da " + ContaCorrente.Titular + "na C/C " + ContaCorrente.Agencia.ToString _
               + " - " + ContaCorrente.Conta.ToString + " é " + ContaCorrente.Saldo.ToString)

        Dim vIncremento As Double = Val(Txt_Incremento.Text)
        ContaCorrente.Saldo += vIncremento

        MsgBox("O saldo da conta da " + ContaCorrente.Titular + "na C/C " + ContaCorrente.Agencia.ToString _
       + " - " + ContaCorrente.Conta.ToString + " é " + ContaCorrente.Saldo.ToString)


    End Sub

    Private Sub Btn_Acao2_Click(sender As Object, e As EventArgs) Handles Btn_Acao2.Click
        Dim ContaBruno As New ContaCorrente

        MsgBox(ContaBruno.Saldo)
    End Sub

    Private Sub Btn_ValRef_Click(sender As Object, e As EventArgs) Handles Btn_ValRef.Click
        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade

        MsgBox("Valor da idade" + idade.ToString + " idade2 " + idade2.ToString)

        idade = 30

        MsgBox("Valor da idade" + idade.ToString + " idade2 " + idade2.ToString)

        Dim ContaGrabriela As New ContaCorrente
        Dim ContaGrabielCostas As New ContaCorrente

        ContaGrabriela.Titular = "Gabriela"
        ContaGrabriela.Agencia = 863
        ContaGrabriela.Conta = 86154

        ContaGrabriela.Saldo = 150

        ContaGrabielCostas = ContaGrabriela

        MsgBox("Valor da ContaDaGabriela" + ContaGrabriela.Saldo.ToString +
               "ContaGabrielaCosta " + ContaGrabielCostas.Saldo.ToString)


    End Sub
End Class
