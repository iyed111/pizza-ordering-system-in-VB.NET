<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAfficher = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEnvoyer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQte = New System.Windows.Forms.TextBox()
        Me.fidel = New System.Windows.Forms.ComboBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prop3 = New System.Windows.Forms.RadioButton()
        Me.prop2 = New System.Windows.Forms.RadioButton()
        Me.prop1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1343, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(592, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "pizza order"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 480)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1343, 51)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.btnAfficher)
        Me.GroupBox1.Controls.Add(Me.btnEffacer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnEnvoyer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtQte)
        Me.GroupBox1.Controls.Add(Me.fidel)
        Me.GroupBox1.Controls.Add(Me.chk3)
        Me.GroupBox1.Controls.Add(Me.chk2)
        Me.GroupBox1.Controls.Add(Me.chk1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.prop3)
        Me.GroupBox1.Controls.Add(Me.prop2)
        Me.GroupBox1.Controls.Add(Me.prop1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Forte", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(238, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1040, 423)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'btnAfficher
        '
        Me.btnAfficher.BackColor = System.Drawing.Color.White
        Me.btnAfficher.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfficher.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAfficher.Location = New System.Drawing.Point(767, 330)
        Me.btnAfficher.Name = "btnAfficher"
        Me.btnAfficher.Size = New System.Drawing.Size(119, 71)
        Me.btnAfficher.TabIndex = 12
        Me.btnAfficher.Text = "afficher"
        Me.btnAfficher.UseVisualStyleBackColor = False
        '
        'btnEffacer
        '
        Me.btnEffacer.BackColor = System.Drawing.Color.White
        Me.btnEffacer.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEffacer.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEffacer.Location = New System.Drawing.Point(892, 330)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(113, 71)
        Me.btnEffacer.TabIndex = 5
        Me.btnEffacer.Text = "effacer"
        Me.btnEffacer.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia Pro Cond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(618, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 27)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "fidelité:"
        '
        'btnEnvoyer
        '
        Me.btnEnvoyer.BackColor = System.Drawing.Color.White
        Me.btnEnvoyer.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnvoyer.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEnvoyer.Location = New System.Drawing.Point(632, 330)
        Me.btnEnvoyer.Name = "btnEnvoyer"
        Me.btnEnvoyer.Size = New System.Drawing.Size(129, 71)
        Me.btnEnvoyer.TabIndex = 4
        Me.btnEnvoyer.Text = "envoyer"
        Me.btnEnvoyer.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia Pro Cond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(599, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 27)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "quantité :"
        '
        'txtQte
        '
        Me.txtQte.BackColor = System.Drawing.Color.White
        Me.txtQte.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtQte.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtQte.Location = New System.Drawing.Point(727, 58)
        Me.txtQte.Name = "txtQte"
        Me.txtQte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQte.Size = New System.Drawing.Size(109, 34)
        Me.txtQte.TabIndex = 9
        '
        'fidel
        '
        Me.fidel.BackColor = System.Drawing.Color.White
        Me.fidel.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.fidel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.fidel.FormattingEnabled = True
        Me.fidel.Items.AddRange(New Object() {"oui ", "non"})
        Me.fidel.Location = New System.Drawing.Point(727, 134)
        Me.fidel.Name = "fidel"
        Me.fidel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fidel.Size = New System.Drawing.Size(159, 34)
        Me.fidel.TabIndex = 8
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk3.Location = New System.Drawing.Point(195, 330)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(335, 42)
        Me.chk3.TabIndex = 7
        Me.chk3.Text = "fromage supplimentaire"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2.Location = New System.Drawing.Point(195, 282)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(111, 42)
        Me.chk2.TabIndex = 6
        Me.chk2.Text = "olives"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1.Location = New System.Drawing.Point(195, 238)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(200, 42)
        Me.chk1.TabIndex = 5
        Me.chk1.Text = "champignion"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ajouter :"
        '
        'prop3
        '
        Me.prop3.AutoSize = True
        Me.prop3.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prop3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.prop3.Location = New System.Drawing.Point(195, 145)
        Me.prop3.Name = "prop3"
        Me.prop3.Size = New System.Drawing.Size(223, 42)
        Me.prop3.TabIndex = 3
        Me.prop3.TabStop = True
        Me.prop3.Text = "croute epaisse"
        Me.prop3.UseVisualStyleBackColor = True
        '
        'prop2
        '
        Me.prop2.AutoSize = True
        Me.prop2.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prop2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.prop2.Location = New System.Drawing.Point(195, 102)
        Me.prop2.Name = "prop2"
        Me.prop2.Size = New System.Drawing.Size(243, 42)
        Me.prop2.TabIndex = 2
        Me.prop2.TabStop = True
        Me.prop2.Text = "croute classique"
        Me.prop2.UseVisualStyleBackColor = True
        '
        'prop1
        '
        Me.prop1.AutoSize = True
        Me.prop1.Font = New System.Drawing.Font("Arial Unicode MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prop1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.prop1.Location = New System.Drawing.Point(195, 58)
        Me.prop1.Name = "prop1"
        Me.prop1.Size = New System.Drawing.Size(171, 42)
        Me.prop1.TabIndex = 1
        Me.prop1.TabStop = True
        Me.prop1.Text = "croute fine"
        Me.prop1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "commander :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.pizza_order.My.Resources.Resources.pngtree_pizza_menu_dark_background_image_15627186
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1343, 429)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents prop3 As RadioButton
    Friend WithEvents prop2 As RadioButton
    Friend WithEvents prop1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents fidel As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQte As TextBox
    Friend WithEvents btnEnvoyer As Button
    Friend WithEvents btnEffacer As Button
    Friend WithEvents btnAfficher As Button
End Class
