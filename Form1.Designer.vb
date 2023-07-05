<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.targetLvlSNUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.soulsNeededTextBox = New System.Windows.Forms.TextBox()
        Me.initialLvlSNUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.currentSoulsLAUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.levelsAvailableTextBox = New System.Windows.Forms.TextBox()
        Me.currentLvlLAUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.targetLvlSNUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.initialLvlSNUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.currentSoulsLAUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currentLvlLAUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.targetLvlSNUpDown)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.soulsNeededTextBox)
        Me.GroupBox1.Controls.Add(Me.initialLvlSNUpDown)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculate Souls Needed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Souls Needed"
        '
        'targetLvlSNUpDown
        '
        Me.targetLvlSNUpDown.Location = New System.Drawing.Point(164, 73)
        Me.targetLvlSNUpDown.Maximum = New Decimal(New Integer() {802, 0, 0, 0})
        Me.targetLvlSNUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.targetLvlSNUpDown.Name = "targetLvlSNUpDown"
        Me.targetLvlSNUpDown.Size = New System.Drawing.Size(60, 26)
        Me.targetLvlSNUpDown.TabIndex = 4
        Me.targetLvlSNUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.targetLvlSNUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Target Level"
        '
        'soulsNeededTextBox
        '
        Me.soulsNeededTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.soulsNeededTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.soulsNeededTextBox.Location = New System.Drawing.Point(107, 126)
        Me.soulsNeededTextBox.Name = "soulsNeededTextBox"
        Me.soulsNeededTextBox.ReadOnly = True
        Me.soulsNeededTextBox.Size = New System.Drawing.Size(117, 26)
        Me.soulsNeededTextBox.TabIndex = 2
        Me.soulsNeededTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'initialLvlSNUpDown
        '
        Me.initialLvlSNUpDown.Location = New System.Drawing.Point(164, 41)
        Me.initialLvlSNUpDown.Maximum = New Decimal(New Integer() {802, 0, 0, 0})
        Me.initialLvlSNUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.initialLvlSNUpDown.Name = "initialLvlSNUpDown"
        Me.initialLvlSNUpDown.Size = New System.Drawing.Size(60, 26)
        Me.initialLvlSNUpDown.TabIndex = 1
        Me.initialLvlSNUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.initialLvlSNUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Level"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.currentSoulsLAUpDown)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.levelsAvailableTextBox)
        Me.GroupBox2.Controls.Add(Me.currentLvlLAUpDown)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(252, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 161)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calculate Level-Ups Available"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Level-Ups"
        '
        'currentSoulsLAUpDown
        '
        Me.currentSoulsLAUpDown.Location = New System.Drawing.Point(107, 73)
        Me.currentSoulsLAUpDown.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.currentSoulsLAUpDown.Name = "currentSoulsLAUpDown"
        Me.currentSoulsLAUpDown.Size = New System.Drawing.Size(117, 26)
        Me.currentSoulsLAUpDown.TabIndex = 4
        Me.currentSoulsLAUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Current Souls"
        '
        'levelsAvailableTextBox
        '
        Me.levelsAvailableTextBox.Location = New System.Drawing.Point(107, 126)
        Me.levelsAvailableTextBox.Name = "levelsAvailableTextBox"
        Me.levelsAvailableTextBox.ReadOnly = True
        Me.levelsAvailableTextBox.Size = New System.Drawing.Size(117, 26)
        Me.levelsAvailableTextBox.TabIndex = 2
        Me.levelsAvailableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'currentLvlLAUpDown
        '
        Me.currentLvlLAUpDown.Location = New System.Drawing.Point(164, 41)
        Me.currentLvlLAUpDown.Maximum = New Decimal(New Integer() {802, 0, 0, 0})
        Me.currentLvlLAUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.currentLvlLAUpDown.Name = "currentLvlLAUpDown"
        Me.currentLvlLAUpDown.Size = New System.Drawing.Size(60, 26)
        Me.currentLvlLAUpDown.TabIndex = 1
        Me.currentLvlLAUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.currentLvlLAUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Current Level"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 210)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainForm"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.targetLvlSNUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.initialLvlSNUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.currentSoulsLAUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentLvlLAUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents targetLvlSNUpDown As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents soulsNeededTextBox As TextBox
    Friend WithEvents initialLvlSNUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents currentSoulsLAUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents levelsAvailableTextBox As TextBox
    Friend WithEvents currentLvlLAUpDown As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
End Class
