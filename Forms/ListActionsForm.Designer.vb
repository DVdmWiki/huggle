﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListActionsForm
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
        Me.OK = New System.Windows.Forms.Button
        Me.NamespaceTransform = New System.Windows.Forms.Button
        Me.NamespaceTransformGroup = New System.Windows.Forms.GroupBox
        Me.NamespaceTransformLabel = New System.Windows.Forms.Label
        Me.NamespaceTransformSelector = New System.Windows.Forms.ComboBox
        Me.PageFiltersGroup = New System.Windows.Forms.GroupBox
        Me.TitleRegex = New Huggle.RegexBox
        Me.NamespacesLabel = New System.Windows.Forms.Label
        Me.Namespaces = New System.Windows.Forms.CheckedListBox
        Me.PageRegexLabel = New System.Windows.Forms.Label
        Me.CheckAll = New System.Windows.Forms.Button
        Me.Apply = New System.Windows.Forms.Button
        Me.NamespaceTransformGroup.SuspendLayout()
        Me.PageFiltersGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.Location = New System.Drawing.Point(317, 265)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 23)
        Me.OK.TabIndex = 2
        Me.OK.Text = "Close"
        Me.OK.UseVisualStyleBackColor = True
        '
        'NamespaceTransform
        '
        Me.NamespaceTransform.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NamespaceTransform.Location = New System.Drawing.Point(302, 18)
        Me.NamespaceTransform.Name = "NamespaceTransform"
        Me.NamespaceTransform.Size = New System.Drawing.Size(75, 23)
        Me.NamespaceTransform.TabIndex = 2
        Me.NamespaceTransform.Text = "Change"
        Me.NamespaceTransform.UseVisualStyleBackColor = True
        '
        'NamespaceTransformGroup
        '
        Me.NamespaceTransformGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NamespaceTransformGroup.Controls.Add(Me.NamespaceTransformLabel)
        Me.NamespaceTransformGroup.Controls.Add(Me.NamespaceTransform)
        Me.NamespaceTransformGroup.Controls.Add(Me.NamespaceTransformSelector)
        Me.NamespaceTransformGroup.Location = New System.Drawing.Point(12, 12)
        Me.NamespaceTransformGroup.Name = "NamespaceTransformGroup"
        Me.NamespaceTransformGroup.Size = New System.Drawing.Size(383, 51)
        Me.NamespaceTransformGroup.TabIndex = 0
        Me.NamespaceTransformGroup.TabStop = False
        Me.NamespaceTransformGroup.Text = "Namespace transform"
        '
        'NamespaceTransformLabel
        '
        Me.NamespaceTransformLabel.AutoSize = True
        Me.NamespaceTransformLabel.Location = New System.Drawing.Point(6, 23)
        Me.NamespaceTransformLabel.Name = "NamespaceTransformLabel"
        Me.NamespaceTransformLabel.Size = New System.Drawing.Size(44, 13)
        Me.NamespaceTransformLabel.TabIndex = 0
        Me.NamespaceTransformLabel.Text = "Change"
        '
        'NamespaceTransformSelector
        '
        Me.NamespaceTransformSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NamespaceTransformSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NamespaceTransformSelector.FormattingEnabled = True
        Me.NamespaceTransformSelector.Items.AddRange(New Object() {"non-talk pages to talk pages", "talk pages to non-talk pages"})
        Me.NamespaceTransformSelector.Location = New System.Drawing.Point(56, 19)
        Me.NamespaceTransformSelector.Name = "NamespaceTransformSelector"
        Me.NamespaceTransformSelector.Size = New System.Drawing.Size(240, 21)
        Me.NamespaceTransformSelector.TabIndex = 1
        '
        'PageFiltersGroup
        '
        Me.PageFiltersGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PageFiltersGroup.Controls.Add(Me.TitleRegex)
        Me.PageFiltersGroup.Controls.Add(Me.NamespacesLabel)
        Me.PageFiltersGroup.Controls.Add(Me.Namespaces)
        Me.PageFiltersGroup.Controls.Add(Me.PageRegexLabel)
        Me.PageFiltersGroup.Location = New System.Drawing.Point(12, 69)
        Me.PageFiltersGroup.Name = "PageFiltersGroup"
        Me.PageFiltersGroup.Size = New System.Drawing.Size(383, 190)
        Me.PageFiltersGroup.TabIndex = 1
        Me.PageFiltersGroup.TabStop = False
        Me.PageFiltersGroup.Text = "Page filters"
        '
        'TitleRegex
        '
        Me.TitleRegex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleRegex.Location = New System.Drawing.Point(173, 19)
        Me.TitleRegex.Multiline = False
        Me.TitleRegex.Name = "TitleRegex"
        Me.TitleRegex.Size = New System.Drawing.Size(204, 36)
        Me.TitleRegex.TabIndex = 1
        '
        'NamespacesLabel
        '
        Me.NamespacesLabel.AutoSize = True
        Me.NamespacesLabel.Location = New System.Drawing.Point(6, 44)
        Me.NamespacesLabel.Name = "NamespacesLabel"
        Me.NamespacesLabel.Size = New System.Drawing.Size(72, 13)
        Me.NamespacesLabel.TabIndex = 2
        Me.NamespacesLabel.Text = "Namespaces:"
        '
        'Namespaces
        '
        Me.Namespaces.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Namespaces.CheckOnClick = True
        Me.Namespaces.IntegralHeight = False
        Me.Namespaces.Location = New System.Drawing.Point(6, 60)
        Me.Namespaces.MultiColumn = True
        Me.Namespaces.Name = "Namespaces"
        Me.Namespaces.Size = New System.Drawing.Size(371, 124)
        Me.Namespaces.TabIndex = 3
        '
        'PageRegexLabel
        '
        Me.PageRegexLabel.AutoSize = True
        Me.PageRegexLabel.Location = New System.Drawing.Point(6, 22)
        Me.PageRegexLabel.Name = "PageRegexLabel"
        Me.PageRegexLabel.Size = New System.Drawing.Size(161, 13)
        Me.PageRegexLabel.TabIndex = 0
        Me.PageRegexLabel.Text = "Title matches regular expression:"
        '
        'CheckAll
        '
        Me.CheckAll.Location = New System.Drawing.Point(12, 265)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Size = New System.Drawing.Size(93, 23)
        Me.CheckAll.TabIndex = 3
        Me.CheckAll.Text = "Check/clear all"
        Me.CheckAll.UseVisualStyleBackColor = True
        '
        'Apply
        '
        Me.Apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Apply.Location = New System.Drawing.Point(236, 265)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(75, 23)
        Me.Apply.TabIndex = 4
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'ListActionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 300)
        Me.Controls.Add(Me.Apply)
        Me.Controls.Add(Me.CheckAll)
        Me.Controls.Add(Me.PageFiltersGroup)
        Me.Controls.Add(Me.NamespaceTransformGroup)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ListActionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List options"
        Me.NamespaceTransformGroup.ResumeLayout(False)
        Me.NamespaceTransformGroup.PerformLayout()
        Me.PageFiltersGroup.ResumeLayout(False)
        Me.PageFiltersGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents NamespaceTransform As System.Windows.Forms.Button
    Friend WithEvents NamespaceTransformGroup As System.Windows.Forms.GroupBox
    Friend WithEvents NamespaceTransformSelector As System.Windows.Forms.ComboBox
    Friend WithEvents NamespaceTransformLabel As System.Windows.Forms.Label
    Friend WithEvents PageFiltersGroup As System.Windows.Forms.GroupBox
    Friend WithEvents NamespacesLabel As System.Windows.Forms.Label
    Friend WithEvents Namespaces As System.Windows.Forms.CheckedListBox
    Friend WithEvents PageRegexLabel As System.Windows.Forms.Label
    Friend WithEvents TitleRegex As Huggle.RegexBox
    Friend WithEvents CheckAll As System.Windows.Forms.Button
    Friend WithEvents Apply As System.Windows.Forms.Button
End Class
