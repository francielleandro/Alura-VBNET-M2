<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_01
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btn_Acao = New System.Windows.Forms.Button()
        Me.Lbl_Saldo = New System.Windows.Forms.Label()
        Me.Lbl_Incremento = New System.Windows.Forms.Label()
        Me.Txt_Saldo = New System.Windows.Forms.TextBox()
        Me.Txt_Incremento = New System.Windows.Forms.TextBox()
        Me.Btn_Acao2 = New System.Windows.Forms.Button()
        Me.Btn_ValRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btn_Acao
        '
        Me.Btn_Acao.Location = New System.Drawing.Point(40, 113)
        Me.Btn_Acao.Name = "Btn_Acao"
        Me.Btn_Acao.Size = New System.Drawing.Size(109, 40)
        Me.Btn_Acao.TabIndex = 1
        Me.Btn_Acao.Text = "Button1"
        Me.Btn_Acao.UseVisualStyleBackColor = True
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.AutoSize = True
        Me.Lbl_Saldo.Location = New System.Drawing.Point(12, 208)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Saldo.TabIndex = 2
        Me.Lbl_Saldo.Text = "Label1"
        '
        'Lbl_Incremento
        '
        Me.Lbl_Incremento.AutoSize = True
        Me.Lbl_Incremento.Location = New System.Drawing.Point(141, 208)
        Me.Lbl_Incremento.Name = "Lbl_Incremento"
        Me.Lbl_Incremento.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Incremento.TabIndex = 3
        Me.Lbl_Incremento.Text = "Label1"
        '
        'Txt_Saldo
        '
        Me.Txt_Saldo.Location = New System.Drawing.Point(15, 242)
        Me.Txt_Saldo.Name = "Txt_Saldo"
        Me.Txt_Saldo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Saldo.TabIndex = 4
        '
        'Txt_Incremento
        '
        Me.Txt_Incremento.Location = New System.Drawing.Point(144, 242)
        Me.Txt_Incremento.Name = "Txt_Incremento"
        Me.Txt_Incremento.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Incremento.TabIndex = 5
        '
        'Btn_Acao2
        '
        Me.Btn_Acao2.Location = New System.Drawing.Point(252, 113)
        Me.Btn_Acao2.Name = "Btn_Acao2"
        Me.Btn_Acao2.Size = New System.Drawing.Size(109, 39)
        Me.Btn_Acao2.TabIndex = 6
        Me.Btn_Acao2.Text = "Button1"
        Me.Btn_Acao2.UseVisualStyleBackColor = True
        '
        'Btn_ValRef
        '
        Me.Btn_ValRef.Location = New System.Drawing.Point(252, 158)
        Me.Btn_ValRef.Name = "Btn_ValRef"
        Me.Btn_ValRef.Size = New System.Drawing.Size(109, 39)
        Me.Btn_ValRef.TabIndex = 7
        Me.Btn_ValRef.Text = "Button1"
        Me.Btn_ValRef.UseVisualStyleBackColor = True
        '
        'Frm_Principal_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 342)
        Me.Controls.Add(Me.Btn_ValRef)
        Me.Controls.Add(Me.Btn_Acao2)
        Me.Controls.Add(Me.Txt_Incremento)
        Me.Controls.Add(Me.Txt_Saldo)
        Me.Controls.Add(Me.Lbl_Incremento)
        Me.Controls.Add(Me.Lbl_Saldo)
        Me.Controls.Add(Me.Btn_Acao)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fomr 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_Acao As Button
    Friend WithEvents Lbl_Saldo As Label
    Friend WithEvents Lbl_Incremento As Label
    Friend WithEvents Txt_Saldo As TextBox
    Friend WithEvents Txt_Incremento As TextBox
    Friend WithEvents Btn_Acao2 As Button
    Friend WithEvents Btn_ValRef As Button
End Class
