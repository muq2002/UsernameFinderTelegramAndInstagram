<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadInstagram = New System.Windows.Forms.RadioButton()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.TextNoChar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListGenUsers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextChar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListProccess = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Length = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.State = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadTelegram = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(196, 375)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 23)
        Me.BtnStop.TabIndex = 0
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(196, 345)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RadTelegram)
        Me.GroupBox1.Controls.Add(Me.RadInstagram)
        Me.GroupBox1.Controls.Add(Me.BtnExport)
        Me.GroupBox1.Controls.Add(Me.TextNoChar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ListGenUsers)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextChar)
        Me.GroupBox1.Controls.Add(Me.BtnStart)
        Me.GroupBox1.Controls.Add(Me.BtnStop)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 404)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generation Username"
        '
        'RadInstagram
        '
        Me.RadInstagram.AutoSize = True
        Me.RadInstagram.Checked = True
        Me.RadInstagram.Location = New System.Drawing.Point(23, 322)
        Me.RadInstagram.Name = "RadInstagram"
        Me.RadInstagram.Size = New System.Drawing.Size(105, 17)
        Me.RadInstagram.TabIndex = 8
        Me.RadInstagram.TabStop = True
        Me.RadInstagram.Text = "Digger Instagram"
        Me.RadInstagram.UseVisualStyleBackColor = True
        '
        'BtnExport
        '
        Me.BtnExport.Location = New System.Drawing.Point(196, 316)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(75, 23)
        Me.BtnExport.TabIndex = 7
        Me.BtnExport.Text = "Export"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'TextNoChar
        '
        Me.TextNoChar.Location = New System.Drawing.Point(86, 59)
        Me.TextNoChar.Name = "TextNoChar"
        Me.TextNoChar.Size = New System.Drawing.Size(160, 20)
        Me.TextNoChar.TabIndex = 6
        Me.TextNoChar.Text = "3"
        Me.TextNoChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "No. Char"
        '
        'ListGenUsers
        '
        Me.ListGenUsers.FormattingEnabled = True
        Me.ListGenUsers.Location = New System.Drawing.Point(23, 98)
        Me.ListGenUsers.Name = "ListGenUsers"
        Me.ListGenUsers.Size = New System.Drawing.Size(248, 212)
        Me.ListGenUsers.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Char : "
        '
        'TextChar
        '
        Me.TextChar.Location = New System.Drawing.Point(86, 30)
        Me.TextChar.Name = "TextChar"
        Me.TextChar.Size = New System.Drawing.Size(161, 20)
        Me.TextChar.TabIndex = 2
        Me.TextChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListProccess)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(287, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 404)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proccessing"
        '
        'ListProccess
        '
        Me.ListProccess.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Length, Me.State})
        Me.ListProccess.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListProccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListProccess.FullRowSelect = True
        Me.ListProccess.GridLines = True
        Me.ListProccess.Location = New System.Drawing.Point(3, 16)
        Me.ListProccess.Name = "ListProccess"
        Me.ListProccess.Size = New System.Drawing.Size(416, 385)
        Me.ListProccess.TabIndex = 4
        Me.ListProccess.UseCompatibleStateImageBehavior = False
        Me.ListProccess.View = System.Windows.Forms.View.Details
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 100
        '
        'Length
        '
        Me.Length.Text = "Length"
        Me.Length.Width = 80
        '
        'State
        '
        Me.State.Text = "State"
        Me.State.Width = 80
        '
        'RadTelegram
        '
        Me.RadTelegram.AutoSize = True
        Me.RadTelegram.Location = New System.Drawing.Point(23, 351)
        Me.RadTelegram.Name = "RadTelegram"
        Me.RadTelegram.Size = New System.Drawing.Size(103, 17)
        Me.RadTelegram.TabIndex = 9
        Me.RadTelegram.TabStop = True
        Me.RadTelegram.Text = "Digger Telegram"
        Me.RadTelegram.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Digged:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.OpenToolStripMenuItem, Me.CheckingToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 92)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'CheckingToolStripMenuItem
        '
        Me.CheckingToolStripMenuItem.Name = "CheckingToolStripMenuItem"
        Me.CheckingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CheckingToolStripMenuItem.Text = "Checking"
        '
        'Main
        '
        Me.AcceptButton = Me.BtnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 404)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Uersname Finder For Telegram and Instagram"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextNoChar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListGenUsers As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextChar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListProccess As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Length As System.Windows.Forms.ColumnHeader
    Friend WithEvents State As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadInstagram As System.Windows.Forms.RadioButton
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents RadTelegram As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
