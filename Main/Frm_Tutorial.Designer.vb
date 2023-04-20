<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Tutorial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_Trivia = New System.Windows.Forms.Label()
        Me.lbl_Game = New System.Windows.Forms.Label()
        Me.lbl_Texto1 = New System.Windows.Forms.Label()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Minimized_Button = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Start)
        Me.Panel1.Controls.Add(Me.Txt_Nombre)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbl_Texto1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 681)
        Me.Panel1.TabIndex = 2
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.Location = New System.Drawing.Point(472, 636)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(91, 33)
        Me.btn_Start.TabIndex = 5
        Me.btn_Start.Text = "inicio"
        Me.btn_Start.UseCompatibleTextRendering = True
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Nombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nombre.Location = New System.Drawing.Point(419, 552)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Nombre.Size = New System.Drawing.Size(196, 25)
        Me.Txt_Nombre.TabIndex = 4
        Me.Txt_Nombre.Text = "NOMBRE"
        Me.Txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_Trivia)
        Me.Panel2.Controls.Add(Me.lbl_Game)
        Me.Panel2.Location = New System.Drawing.Point(301, -4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(432, 189)
        Me.Panel2.TabIndex = 3
        '
        'lbl_Trivia
        '
        Me.lbl_Trivia.AutoSize = True
        Me.lbl_Trivia.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Trivia.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Trivia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lbl_Trivia.Location = New System.Drawing.Point(45, 48)
        Me.lbl_Trivia.Name = "lbl_Trivia"
        Me.lbl_Trivia.Size = New System.Drawing.Size(242, 84)
        Me.lbl_Trivia.TabIndex = 3
        Me.lbl_Trivia.Text = "TRIVIA"
        Me.lbl_Trivia.UseCompatibleTextRendering = True
        '
        'lbl_Game
        '
        Me.lbl_Game.AutoSize = True
        Me.lbl_Game.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Game.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Game.ForeColor = System.Drawing.Color.DarkCyan
        Me.lbl_Game.Location = New System.Drawing.Point(78, 117)
        Me.lbl_Game.Name = "lbl_Game"
        Me.lbl_Game.Size = New System.Drawing.Size(221, 84)
        Me.lbl_Game.TabIndex = 1
        Me.lbl_Game.Text = "GAME"
        Me.lbl_Game.UseCompatibleTextRendering = True
        '
        'lbl_Texto1
        '
        Me.lbl_Texto1.AutoSize = True
        Me.lbl_Texto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Texto1.Location = New System.Drawing.Point(58, 226)
        Me.lbl_Texto1.Name = "lbl_Texto1"
        Me.lbl_Texto1.Size = New System.Drawing.Size(573, 30)
        Me.lbl_Texto1.TabIndex = 0
        Me.lbl_Texto1.Text = "Te damos la bienvenida al juego de trivia mas interesante."""
        Me.lbl_Texto1.UseCompatibleTextRendering = True
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.IndianRed
        Me.Exit_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.ForeColor = System.Drawing.Color.White
        Me.Exit_Button.Location = New System.Drawing.Point(981, 12)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(41, 37)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "X"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'Minimized_Button
        '
        Me.Minimized_Button.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Minimized_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Minimized_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimized_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimized_Button.ForeColor = System.Drawing.Color.White
        Me.Minimized_Button.Location = New System.Drawing.Point(934, 12)
        Me.Minimized_Button.Name = "Minimized_Button"
        Me.Minimized_Button.Size = New System.Drawing.Size(41, 37)
        Me.Minimized_Button.TabIndex = 4
        Me.Minimized_Button.Text = "___"
        Me.Minimized_Button.UseVisualStyleBackColor = False
        '
        'Frm_Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1034, 681)
        Me.Controls.Add(Me.Minimized_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trivia Game"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Minimized_Button As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_Trivia As Label
    Friend WithEvents lbl_Game As Label
    Friend WithEvents lbl_Texto1 As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents btn_Start As Button
End Class
