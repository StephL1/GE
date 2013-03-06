<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printer
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
        Me.print = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bmi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.snmi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.audit = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(251, 198)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(135, 52)
        Me.print.TabIndex = 0
        Me.print.Text = "Print Ticket"
        Me.print.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Boxes Moved In"
        '
        'bmi
        '
        Me.bmi.Location = New System.Drawing.Point(102, 26)
        Me.bmi.Name = "bmi"
        Me.bmi.ReadOnly = True
        Me.bmi.Size = New System.Drawing.Size(100, 20)
        Me.bmi.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Skid Number Moved In"
        '
        'snmi
        '
        Me.snmi.Location = New System.Drawing.Point(480, 26)
        Me.snmi.Name = "snmi"
        Me.snmi.ReadOnly = True
        Me.snmi.Size = New System.Drawing.Size(100, 20)
        Me.snmi.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Boxes on Skid"
        '
        'bos
        '
        Me.bos.Location = New System.Drawing.Point(102, 87)
        Me.bos.Name = "bos"
        Me.bos.ReadOnly = True
        Me.bos.Size = New System.Drawing.Size(100, 20)
        Me.bos.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(358, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Good Boxes"
        '
        'gb
        '
        Me.gb.Location = New System.Drawing.Point(448, 84)
        Me.gb.Name = "gb"
        Me.gb.ReadOnly = True
        Me.gb.Size = New System.Drawing.Size(118, 20)
        Me.gb.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Status:"
        '
        'stat
        '
        Me.stat.FormattingEnabled = True
        Me.stat.Location = New System.Drawing.Point(102, 121)
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(121, 21)
        Me.stat.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(358, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Auditor:"
        '
        'audit
        '
        Me.audit.FormattingEnabled = True
        Me.audit.Location = New System.Drawing.Point(445, 118)
        Me.audit.Name = "audit"
        Me.audit.Size = New System.Drawing.Size(121, 21)
        Me.audit.TabIndex = 4
        '
        'PrintDocument1
        '
        '
        'printer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 262)
        Me.Controls.Add(Me.audit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.snmi)
        Me.Controls.Add(Me.gb)
        Me.Controls.Add(Me.bos)
        Me.Controls.Add(Me.bmi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.print)
        Me.Name = "printer"
        Me.Text = "printer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bmi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents snmi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents stat As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents audit As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
