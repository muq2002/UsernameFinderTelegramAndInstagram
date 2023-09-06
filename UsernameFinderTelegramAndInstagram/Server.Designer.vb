<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server
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
        Me.Web1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Web1
        '
        Me.Web1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Web1.Location = New System.Drawing.Point(0, 0)
        Me.Web1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web1.Name = "Web1"
        Me.Web1.Size = New System.Drawing.Size(576, 418)
        Me.Web1.TabIndex = 0
        '
        'Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 418)
        Me.Controls.Add(Me.Web1)
        Me.Name = "Server"
        Me.Text = "Server"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Web1 As System.Windows.Forms.WebBrowser
End Class
