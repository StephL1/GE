<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseShift
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
        Me.components = New System.ComponentModel.Container()
        Me.btnA = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SomPermissionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAuditor = New R10_Inspection.DataSetAuditor()
        Me.Som_PermissionsTableAdapter = New R10_Inspection.DataSetAuditorTableAdapters.Som_PermissionsTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FillByPermission1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByPermission1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.SomPermissionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAuditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByPermission1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.Black
        Me.btnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnA.Location = New System.Drawing.Point(35, 49)
        Me.btnA.Margin = New System.Windows.Forms.Padding(4)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(152, 106)
        Me.btnA.TabIndex = 0
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(35, 222)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 106)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "B"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(35, 400)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 106)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "C"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(35, 577)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 106)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "D"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'SomPermissionsBindingSource
        '
        Me.SomPermissionsBindingSource.DataMember = "Som_Permissions"
        Me.SomPermissionsBindingSource.DataSource = Me.DataSetAuditor
        '
        'DataSetAuditor
        '
        Me.DataSetAuditor.DataSetName = "DataSetAuditor"
        Me.DataSetAuditor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Som_PermissionsTableAdapter
        '
        Me.Som_PermissionsTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SomPermissionsBindingSource
        Me.ComboBox1.DisplayMember = "Initials"
        Me.ComboBox1.DropDownHeight = 500
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.ItemHeight = 16
        Me.ComboBox1.Location = New System.Drawing.Point(540, 159)
        Me.ComboBox1.MaxDropDownItems = 50
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(314, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'FillByPermission1ToolStrip
        '
        Me.FillByPermission1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByPermission1ToolStripButton})
        Me.FillByPermission1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByPermission1ToolStrip.Name = "FillByPermission1ToolStrip"
        Me.FillByPermission1ToolStrip.Size = New System.Drawing.Size(222, 25)
        Me.FillByPermission1ToolStrip.TabIndex = 5
        Me.FillByPermission1ToolStrip.Text = "FillByPermission1ToolStrip"
        '
        'FillByPermission1ToolStripButton
        '
        Me.FillByPermission1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByPermission1ToolStripButton.Name = "FillByPermission1ToolStripButton"
        Me.FillByPermission1ToolStripButton.Size = New System.Drawing.Size(119, 22)
        Me.FillByPermission1ToolStripButton.Text = "FillByPermission1"
        '
        'ChooseShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 737)
        Me.Controls.Add(Me.FillByPermission1ToolStrip)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnA)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ChooseShift"
        Me.Text = "Choose Shift"
        CType(Me.SomPermissionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAuditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByPermission1ToolStrip.ResumeLayout(False)
        Me.FillByPermission1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataSetAuditor As R10_Inspection.DataSetAuditor
    Friend WithEvents SomPermissionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Som_PermissionsTableAdapter As R10_Inspection.DataSetAuditorTableAdapters.Som_PermissionsTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents FillByPermission1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByPermission1ToolStripButton As System.Windows.Forms.ToolStripButton
End Class
