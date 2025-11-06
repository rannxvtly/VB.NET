<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKalkulator
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
        Me.Txtangka1 = New System.Windows.Forms.TextBox()
        Me.Txtangka2 = New System.Windows.Forms.TextBox()
        Me.Btjumlah = New System.Windows.Forms.Button()
        Me.Btkurang = New System.Windows.Forms.Button()
        Me.Btbagi = New System.Windows.Forms.Button()
        Me.Btkali = New System.Windows.Forms.Button()
        Me.Txthasil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txtangka1
        '
        Me.Txtangka1.Location = New System.Drawing.Point(127, 21)
        Me.Txtangka1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Txtangka1.Name = "Txtangka1"
        Me.Txtangka1.Size = New System.Drawing.Size(124, 20)
        Me.Txtangka1.TabIndex = 1
        '
        'Txtangka2
        '
        Me.Txtangka2.Location = New System.Drawing.Point(127, 47)
        Me.Txtangka2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Txtangka2.Name = "Txtangka2"
        Me.Txtangka2.Size = New System.Drawing.Size(124, 20)
        Me.Txtangka2.TabIndex = 3
        '
        'Btjumlah
        '
        Me.Btjumlah.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btjumlah.Location = New System.Drawing.Point(36, 83)
        Me.Btjumlah.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Btjumlah.Name = "Btjumlah"
        Me.Btjumlah.Size = New System.Drawing.Size(53, 40)
        Me.Btjumlah.TabIndex = 4
        Me.Btjumlah.Text = "+"
        Me.Btjumlah.UseVisualStyleBackColor = True
        '
        'Btkurang
        '
        Me.Btkurang.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btkurang.Location = New System.Drawing.Point(93, 83)
        Me.Btkurang.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Btkurang.Name = "Btkurang"
        Me.Btkurang.Size = New System.Drawing.Size(53, 40)
        Me.Btkurang.TabIndex = 5
        Me.Btkurang.Text = "-"
        Me.Btkurang.UseVisualStyleBackColor = True
        '
        'Btbagi
        '
        Me.Btbagi.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btbagi.Location = New System.Drawing.Point(149, 83)
        Me.Btbagi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Btbagi.Name = "Btbagi"
        Me.Btbagi.Size = New System.Drawing.Size(53, 40)
        Me.Btbagi.TabIndex = 6
        Me.Btbagi.Text = "/"
        Me.Btbagi.UseVisualStyleBackColor = True
        '
        'Btkali
        '
        Me.Btkali.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btkali.Location = New System.Drawing.Point(206, 83)
        Me.Btkali.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Btkali.Name = "Btkali"
        Me.Btkali.Size = New System.Drawing.Size(53, 40)
        Me.Btkali.TabIndex = 7
        Me.Btkali.Text = "*"
        Me.Btkali.UseVisualStyleBackColor = True
        '
        'Txthasil
        '
        Me.Txthasil.Location = New System.Drawing.Point(125, 142)
        Me.Txthasil.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Txthasil.Name = "Txthasil"
        Me.Txthasil.Size = New System.Drawing.Size(124, 20)
        Me.Txthasil.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Angka Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Angka Kedua"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hasil"
        '
        'FrmKalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(367, 191)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txthasil)
        Me.Controls.Add(Me.Btkali)
        Me.Controls.Add(Me.Btbagi)
        Me.Controls.Add(Me.Btkurang)
        Me.Controls.Add(Me.Btjumlah)
        Me.Controls.Add(Me.Txtangka2)
        Me.Controls.Add(Me.Txtangka1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmKalkulator"
        Me.Text = ":: Kalkulator Sederhana ::"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtangka1 As TextBox
    Friend WithEvents Txtangka2 As TextBox
    Friend WithEvents Btjumlah As Button
    Friend WithEvents Btkurang As Button
    Friend WithEvents Btbagi As Button
    Friend WithEvents Btkali As Button
    Friend WithEvents Txthasil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
