﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailForm
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
        Me.SubjectLabel = New System.Windows.Forms.Label
        Me.Subject = New System.Windows.Forms.TextBox
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.Message = New System.Windows.Forms.TextBox
        Me.Cancel = New System.Windows.Forms.Button
        Me.Send = New System.Windows.Forms.Button
        Me.CcMe = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Location = New System.Drawing.Point(12, 15)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(46, 13)
        Me.SubjectLabel.TabIndex = 0
        Me.SubjectLabel.Text = "Subject:"
        '
        'Subject
        '
        Me.Subject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Subject.Location = New System.Drawing.Point(64, 12)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(467, 20)
        Me.Subject.TabIndex = 1
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Location = New System.Drawing.Point(5, 41)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(53, 13)
        Me.MessageLabel.TabIndex = 2
        Me.MessageLabel.Text = "Message:"
        '
        'Message
        '
        Me.Message.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Message.Location = New System.Drawing.Point(64, 38)
        Me.Message.Multiline = True
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(467, 249)
        Me.Message.TabIndex = 3
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.Location = New System.Drawing.Point(456, 293)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Send
        '
        Me.Send.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Send.Enabled = False
        Me.Send.Location = New System.Drawing.Point(375, 293)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 4
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'CcMe
        '
        Me.CcMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CcMe.AutoSize = True
        Me.CcMe.Checked = True
        Me.CcMe.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CcMe.Location = New System.Drawing.Point(64, 297)
        Me.CcMe.Name = "CcMe"
        Me.CcMe.Size = New System.Drawing.Size(182, 17)
        Me.CcMe.TabIndex = 5
        Me.CcMe.Text = "E-mail me a copy of this message"
        Me.CcMe.UseVisualStyleBackColor = True
        '
        'EmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 328)
        Me.Controls.Add(Me.CcMe)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.SubjectLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "EmailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-mail user"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubjectLabel As System.Windows.Forms.Label
    Friend WithEvents Subject As System.Windows.Forms.TextBox
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents Message As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents CcMe As System.Windows.Forms.CheckBox
End Class
