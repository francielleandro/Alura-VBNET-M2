Public Class Frm_Principal_01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "1 - Primeira Classe"

        Lbl_Principal.Text = "1 - Primeira Classe"

        Btn_Acao.Text = "Clique aqui"

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

End Class
