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


    End Sub
End Class
