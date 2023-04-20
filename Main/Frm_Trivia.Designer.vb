<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_trivia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_trivia))
        Me.lbl_Game = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Play_Button = New System.Windows.Forms.Button()
        Me.lbl_Trivia = New System.Windows.Forms.Label()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Minimized_Button = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Play_Button)
        Me.Panel1.Controls.Add(Me.lbl_Trivia)
        Me.Panel1.Controls.Add(Me.lbl_Game)
        Me.Panel1.Location = New System.Drawing.Point(301, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 689)
        Me.Panel1.TabIndex = 2
        '
        'Play_Button
        '
        Me.Play_Button.BackColor = System.Drawing.Color.Transparent
        Me.Play_Button.BackgroundImage = CType(resources.GetObject("Play_Button.BackgroundImage"), System.Drawing.Image)
        Me.Play_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Play_Button.FlatAppearance.BorderSize = 0
        Me.Play_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Play_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Play_Button.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play_Button.Location = New System.Drawing.Point(159, 549)
        Me.Play_Button.Name = "Play_Button"
        Me.Play_Button.Size = New System.Drawing.Size(113, 73)
        Me.Play_Button.TabIndex = 3
        Me.Play_Button.UseVisualStyleBackColor = False
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
        'Frm_trivia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1034, 681)
        Me.Controls.Add(Me.Minimized_Button)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_trivia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trivia Game"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Game As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Play_Button As Button
    Friend WithEvents lbl_Trivia As Label
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Minimized_Button As Button
End Class
