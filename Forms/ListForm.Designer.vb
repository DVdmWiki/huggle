﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListForm
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
        Me.components = New System.ComponentModel.Container
        Me.Lists = New System.Windows.Forms.ListBox
        Me.ListEmpty = New System.Windows.Forms.Label
        Me.FromLabel = New System.Windows.Forms.Label
        Me.From = New System.Windows.Forms.TextBox
        Me.Cancel = New System.Windows.Forms.Button
        Me.Progress = New System.Windows.Forms.Label
        Me.LimitLabel = New System.Windows.Forms.Label
        Me.Actions = New System.Windows.Forms.Button
        Me.Clear = New System.Windows.Forms.Button
        Me.Save = New System.Windows.Forms.Button
        Me.ListSelector = New System.Windows.Forms.ComboBox
        Me.Limit = New System.Windows.Forms.NumericUpDown
        Me.Throbber = New Huggle.Throbber
        Me.Count = New System.Windows.Forms.Label
        Me.SourceLabel = New System.Windows.Forms.Label
        Me.Exclude = New System.Windows.Forms.Button
        Me.Combine = New System.Windows.Forms.Button
        Me.Intersect = New System.Windows.Forms.Button
        Me.SourceType = New System.Windows.Forms.ComboBox
        Me.SourceTypeLabel = New System.Windows.Forms.Label
        Me.ListPages = New System.Windows.Forms.ListBox
        Me.Source = New System.Windows.Forms.TextBox
        Me.Browse = New System.Windows.Forms.Button
        Me.CopyList = New System.Windows.Forms.Button
        Me.RenameList = New System.Windows.Forms.Button
        Me.DeleteList = New System.Windows.Forms.Button
        Me.AddList = New System.Windows.Forms.Button
        Me.ListsEmpty = New System.Windows.Forms.Label
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListMenuView = New System.Windows.Forms.ToolStripMenuItem
        Me.ListMenuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ListMenuRemove = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseButton = New System.Windows.Forms.Button
        CType(Me.Limit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lists
        '
        Me.Lists.FormattingEnabled = True
        Me.Lists.IntegralHeight = False
        Me.Lists.Location = New System.Drawing.Point(12, 12)
        Me.Lists.Name = "Lists"
        Me.Lists.Size = New System.Drawing.Size(156, 340)
        Me.Lists.TabIndex = 0
        '
        'ListEmpty
        '
        Me.ListEmpty.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListEmpty.BackColor = System.Drawing.SystemColors.Window
        Me.ListEmpty.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListEmpty.Location = New System.Drawing.Point(205, 227)
        Me.ListEmpty.Name = "ListEmpty"
        Me.ListEmpty.Size = New System.Drawing.Size(359, 36)
        Me.ListEmpty.TabIndex = 88
        Me.ListEmpty.Text = "No items in list" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter a source and click ""Add"""
        Me.ListEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ListEmpty.Visible = False
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Location = New System.Drawing.Point(431, 15)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(33, 13)
        Me.FromLabel.TabIndex = 72
        Me.FromLabel.Text = "From:"
        '
        'From
        '
        Me.From.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.From.Location = New System.Drawing.Point(466, 12)
        Me.From.Name = "From"
        Me.From.Size = New System.Drawing.Size(107, 20)
        Me.From.TabIndex = 73
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.Location = New System.Drawing.Point(488, 121)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(76, 23)
        Me.Cancel.TabIndex = 84
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        Me.Cancel.Visible = False
        '
        'Progress
        '
        Me.Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progress.Location = New System.Drawing.Point(265, 91)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(308, 15)
        Me.Progress.TabIndex = 86
        Me.Progress.Text = " "
        '
        'LimitLabel
        '
        Me.LimitLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LimitLabel.AutoSize = True
        Me.LimitLabel.Location = New System.Drawing.Point(483, 41)
        Me.LimitLabel.Name = "LimitLabel"
        Me.LimitLabel.Size = New System.Drawing.Size(36, 13)
        Me.LimitLabel.TabIndex = 78
        Me.LimitLabel.Text = "Up to:"
        '
        'Actions
        '
        Me.Actions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Actions.Enabled = False
        Me.Actions.Location = New System.Drawing.Point(341, 387)
        Me.Actions.Name = "Actions"
        Me.Actions.Size = New System.Drawing.Size(114, 23)
        Me.Actions.TabIndex = 69
        Me.Actions.Text = "Actions and Filters..."
        Me.Actions.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Clear.Enabled = False
        Me.Clear.Location = New System.Drawing.Point(268, 387)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(67, 23)
        Me.Clear.TabIndex = 67
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Save.Enabled = False
        Me.Save.Location = New System.Drawing.Point(195, 387)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(67, 23)
        Me.Save.TabIndex = 66
        Me.Save.Text = "Save..."
        Me.Save.UseVisualStyleBackColor = True
        '
        'ListSelector
        '
        Me.ListSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListSelector.FormattingEnabled = True
        Me.ListSelector.Location = New System.Drawing.Point(265, 38)
        Me.ListSelector.Name = "ListSelector"
        Me.ListSelector.Size = New System.Drawing.Size(211, 21)
        Me.ListSelector.Sorted = True
        Me.ListSelector.TabIndex = 76
        '
        'Limit
        '
        Me.Limit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Limit.Enabled = False
        Me.Limit.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Limit.Location = New System.Drawing.Point(521, 38)
        Me.Limit.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Limit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Limit.Name = "Limit"
        Me.Limit.Size = New System.Drawing.Size(52, 20)
        Me.Limit.TabIndex = 79
        Me.Limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Limit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Throbber
        '
        Me.Throbber.BackColor = System.Drawing.Color.White
        Me.Throbber.Location = New System.Drawing.Point(195, 72)
        Me.Throbber.Name = "Throbber"
        Me.Throbber.Size = New System.Drawing.Size(58, 10)
        Me.Throbber.TabIndex = 80
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Location = New System.Drawing.Point(193, 92)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(40, 13)
        Me.Count.TabIndex = 85
        Me.Count.Text = "0 items"
        '
        'SourceLabel
        '
        Me.SourceLabel.Location = New System.Drawing.Point(192, 41)
        Me.SourceLabel.Name = "SourceLabel"
        Me.SourceLabel.Size = New System.Drawing.Size(72, 16)
        Me.SourceLabel.TabIndex = 74
        Me.SourceLabel.Text = "Source:"
        Me.SourceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Exclude
        '
        Me.Exclude.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Exclude.Enabled = False
        Me.Exclude.Location = New System.Drawing.Point(497, 65)
        Me.Exclude.Name = "Exclude"
        Me.Exclude.Size = New System.Drawing.Size(76, 23)
        Me.Exclude.TabIndex = 83
        Me.Exclude.Text = "Exclude"
        Me.Exclude.UseVisualStyleBackColor = True
        '
        'Combine
        '
        Me.Combine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Combine.Enabled = False
        Me.Combine.Location = New System.Drawing.Point(333, 65)
        Me.Combine.Name = "Combine"
        Me.Combine.Size = New System.Drawing.Size(76, 23)
        Me.Combine.TabIndex = 81
        Me.Combine.Text = "Combine"
        Me.Combine.UseVisualStyleBackColor = True
        '
        'Intersect
        '
        Me.Intersect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Intersect.Enabled = False
        Me.Intersect.Location = New System.Drawing.Point(415, 65)
        Me.Intersect.Name = "Intersect"
        Me.Intersect.Size = New System.Drawing.Size(76, 23)
        Me.Intersect.TabIndex = 82
        Me.Intersect.Text = "Intersect"
        Me.Intersect.UseVisualStyleBackColor = True
        '
        'SourceType
        '
        Me.SourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SourceType.Enabled = False
        Me.SourceType.FormattingEnabled = True
        Me.SourceType.Location = New System.Drawing.Point(265, 11)
        Me.SourceType.MaxDropDownItems = 20
        Me.SourceType.Name = "SourceType"
        Me.SourceType.Size = New System.Drawing.Size(156, 21)
        Me.SourceType.TabIndex = 71
        '
        'SourceTypeLabel
        '
        Me.SourceTypeLabel.AutoSize = True
        Me.SourceTypeLabel.Location = New System.Drawing.Point(197, 14)
        Me.SourceTypeLabel.Name = "SourceTypeLabel"
        Me.SourceTypeLabel.Size = New System.Drawing.Size(67, 13)
        Me.SourceTypeLabel.TabIndex = 70
        Me.SourceTypeLabel.Text = "Source type:"
        '
        'ListPages
        '
        Me.ListPages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListPages.IntegralHeight = False
        Me.ListPages.Location = New System.Drawing.Point(195, 109)
        Me.ListPages.Name = "ListPages"
        Me.ListPages.Size = New System.Drawing.Size(378, 271)
        Me.ListPages.Sorted = True
        Me.ListPages.TabIndex = 87
        '
        'Source
        '
        Me.Source.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Source.Enabled = False
        Me.Source.Location = New System.Drawing.Point(265, 39)
        Me.Source.Name = "Source"
        Me.Source.Size = New System.Drawing.Size(211, 20)
        Me.Source.TabIndex = 75
        '
        'Browse
        '
        Me.Browse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browse.Enabled = False
        Me.Browse.Location = New System.Drawing.Point(409, 37)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(67, 23)
        Me.Browse.TabIndex = 77
        Me.Browse.Text = "Browse..."
        Me.Browse.UseVisualStyleBackColor = True
        Me.Browse.Visible = False
        '
        'CopyList
        '
        Me.CopyList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CopyList.Enabled = False
        Me.CopyList.Location = New System.Drawing.Point(12, 387)
        Me.CopyList.Name = "CopyList"
        Me.CopyList.Size = New System.Drawing.Size(75, 23)
        Me.CopyList.TabIndex = 91
        Me.CopyList.Text = "Copy"
        Me.CopyList.UseVisualStyleBackColor = True
        '
        'RenameList
        '
        Me.RenameList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RenameList.Enabled = False
        Me.RenameList.Location = New System.Drawing.Point(93, 387)
        Me.RenameList.Name = "RenameList"
        Me.RenameList.Size = New System.Drawing.Size(75, 23)
        Me.RenameList.TabIndex = 92
        Me.RenameList.Text = "Rename"
        Me.RenameList.UseVisualStyleBackColor = True
        '
        'DeleteList
        '
        Me.DeleteList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeleteList.Enabled = False
        Me.DeleteList.Location = New System.Drawing.Point(93, 358)
        Me.DeleteList.Name = "DeleteList"
        Me.DeleteList.Size = New System.Drawing.Size(75, 23)
        Me.DeleteList.TabIndex = 90
        Me.DeleteList.Text = "Delete"
        Me.DeleteList.UseVisualStyleBackColor = True
        '
        'AddList
        '
        Me.AddList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddList.Location = New System.Drawing.Point(12, 358)
        Me.AddList.Name = "AddList"
        Me.AddList.Size = New System.Drawing.Size(75, 23)
        Me.AddList.TabIndex = 89
        Me.AddList.Text = "Add"
        Me.AddList.UseVisualStyleBackColor = True
        '
        'ListsEmpty
        '
        Me.ListsEmpty.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ListsEmpty.BackColor = System.Drawing.SystemColors.Window
        Me.ListsEmpty.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListsEmpty.Location = New System.Drawing.Point(21, 161)
        Me.ListsEmpty.Name = "ListsEmpty"
        Me.ListsEmpty.Size = New System.Drawing.Size(138, 36)
        Me.ListsEmpty.TabIndex = 93
        Me.ListsEmpty.Text = "No lists defined" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click ""Add"" to create one"
        Me.ListsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ListsEmpty.Visible = False
        '
        'ListMenu
        '
        Me.ListMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListMenuView, Me.ListMenuEdit, Me.ListMenuRemove})
        Me.ListMenu.Name = "QueueMenu"
        Me.ListMenu.Size = New System.Drawing.Size(114, 70)
        '
        'ListMenuView
        '
        Me.ListMenuView.Name = "ListMenuView"
        Me.ListMenuView.Size = New System.Drawing.Size(113, 22)
        Me.ListMenuView.Text = "View"
        '
        'ListMenuEdit
        '
        Me.ListMenuEdit.Name = "ListMenuEdit"
        Me.ListMenuEdit.Size = New System.Drawing.Size(113, 22)
        Me.ListMenuEdit.Text = "Edit"
        '
        'ListMenuRemove
        '
        Me.ListMenuRemove.Name = "ListMenuRemove"
        Me.ListMenuRemove.Size = New System.Drawing.Size(113, 22)
        Me.ListMenuRemove.Text = "Remove"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(498, 387)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 94
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 421)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ListsEmpty)
        Me.Controls.Add(Me.CopyList)
        Me.Controls.Add(Me.RenameList)
        Me.Controls.Add(Me.DeleteList)
        Me.Controls.Add(Me.AddList)
        Me.Controls.Add(Me.ListEmpty)
        Me.Controls.Add(Me.FromLabel)
        Me.Controls.Add(Me.From)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.LimitLabel)
        Me.Controls.Add(Me.ListSelector)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Limit)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Throbber)
        Me.Controls.Add(Me.Actions)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.SourceLabel)
        Me.Controls.Add(Me.SourceType)
        Me.Controls.Add(Me.SourceTypeLabel)
        Me.Controls.Add(Me.Exclude)
        Me.Controls.Add(Me.Combine)
        Me.Controls.Add(Me.Source)
        Me.Controls.Add(Me.Intersect)
        Me.Controls.Add(Me.ListPages)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.Lists)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Builder"
        CType(Me.Limit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lists As System.Windows.Forms.ListBox
    Friend WithEvents ListEmpty As System.Windows.Forms.Label
    Friend WithEvents FromLabel As System.Windows.Forms.Label
    Friend WithEvents From As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Progress As System.Windows.Forms.Label
    Friend WithEvents LimitLabel As System.Windows.Forms.Label
    Friend WithEvents Actions As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents ListSelector As System.Windows.Forms.ComboBox
    Friend WithEvents Limit As System.Windows.Forms.NumericUpDown
    Friend WithEvents Throbber As Huggle.Throbber
    Friend WithEvents Count As System.Windows.Forms.Label
    Friend WithEvents SourceLabel As System.Windows.Forms.Label
    Friend WithEvents Exclude As System.Windows.Forms.Button
    Friend WithEvents Combine As System.Windows.Forms.Button
    Friend WithEvents Intersect As System.Windows.Forms.Button
    Friend WithEvents SourceType As System.Windows.Forms.ComboBox
    Friend WithEvents SourceTypeLabel As System.Windows.Forms.Label
    Friend WithEvents ListPages As System.Windows.Forms.ListBox
    Friend WithEvents Source As System.Windows.Forms.TextBox
    Friend WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents CopyList As System.Windows.Forms.Button
    Friend WithEvents RenameList As System.Windows.Forms.Button
    Friend WithEvents DeleteList As System.Windows.Forms.Button
    Friend WithEvents AddList As System.Windows.Forms.Button
    Friend WithEvents ListsEmpty As System.Windows.Forms.Label
    Friend WithEvents Tip As System.Windows.Forms.ToolTip
    Friend WithEvents ListMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListMenuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMenuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMenuRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
