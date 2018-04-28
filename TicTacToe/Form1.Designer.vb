<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.player1_name = New System.Windows.Forms.TextBox()
        Me.player2_name = New System.Windows.Forms.TextBox()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'player1_name
        '
        Me.player1_name.BackColor = System.Drawing.SystemColors.Control
        Me.player1_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.player1_name.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1_name.Location = New System.Drawing.Point(42, 40)
        Me.player1_name.Name = "player1_name"
        Me.player1_name.Size = New System.Drawing.Size(386, 43)
        Me.player1_name.TabIndex = 0
        Me.player1_name.Text = "enter player x's name"
        '
        'player2_name
        '
        Me.player2_name.BackColor = System.Drawing.SystemColors.Control
        Me.player2_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.player2_name.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2_name.Location = New System.Drawing.Point(42, 95)
        Me.player2_name.Name = "player2_name"
        Me.player2_name.Size = New System.Drawing.Size(386, 43)
        Me.player2_name.TabIndex = 1
        Me.player2_name.Text = "enter player o's name"
        '
        'btn_next
        '
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(177, 164)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(116, 42)
        Me.btn_next.TabIndex = 2
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 226)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.player2_name)
        Me.Controls.Add(Me.player1_name)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter player's first name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player1_name As TextBox
    Friend WithEvents player2_name As TextBox
    Friend WithEvents btn_next As Button
End Class
