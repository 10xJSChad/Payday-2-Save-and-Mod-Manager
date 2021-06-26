<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.GameBox = New System.Windows.Forms.TextBox()
        Me.SaveBox = New System.Windows.Forms.TextBox()
        Me.ChangeGame = New System.Windows.Forms.Button()
        Me.ChangeSave = New System.Windows.Forms.Button()
        Me.DoneBtn = New System.Windows.Forms.Button()
        Me.FolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.HowtoLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'GameBox
        '
        Me.GameBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameBox.Location = New System.Drawing.Point(12, 12)
        Me.GameBox.Name = "GameBox"
        Me.GameBox.Size = New System.Drawing.Size(406, 31)
        Me.GameBox.TabIndex = 0
        Me.GameBox.Text = "Game Path (Folder with the EXE)"
        '
        'SaveBox
        '
        Me.SaveBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaveBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBox.Location = New System.Drawing.Point(12, 49)
        Me.SaveBox.Name = "SaveBox"
        Me.SaveBox.Size = New System.Drawing.Size(406, 31)
        Me.SaveBox.TabIndex = 1
        Me.SaveBox.Text = "Save Path"
        '
        'ChangeGame
        '
        Me.ChangeGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeGame.Location = New System.Drawing.Point(424, 12)
        Me.ChangeGame.Name = "ChangeGame"
        Me.ChangeGame.Size = New System.Drawing.Size(111, 31)
        Me.ChangeGame.TabIndex = 2
        Me.ChangeGame.Text = "Select Path"
        Me.ChangeGame.UseVisualStyleBackColor = True
        '
        'ChangeSave
        '
        Me.ChangeSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeSave.Location = New System.Drawing.Point(424, 49)
        Me.ChangeSave.Name = "ChangeSave"
        Me.ChangeSave.Size = New System.Drawing.Size(111, 31)
        Me.ChangeSave.TabIndex = 3
        Me.ChangeSave.Text = "Select Path"
        Me.ChangeSave.UseVisualStyleBackColor = True
        '
        'DoneBtn
        '
        Me.DoneBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneBtn.Location = New System.Drawing.Point(424, 86)
        Me.DoneBtn.Name = "DoneBtn"
        Me.DoneBtn.Size = New System.Drawing.Size(111, 31)
        Me.DoneBtn.TabIndex = 4
        Me.DoneBtn.Text = "Done"
        Me.DoneBtn.UseVisualStyleBackColor = True
        '
        'FolderDialog
        '
        Me.FolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'HowtoLabel
        '
        Me.HowtoLabel.AutoSize = True
        Me.HowtoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HowtoLabel.Location = New System.Drawing.Point(12, 86)
        Me.HowtoLabel.Name = "HowtoLabel"
        Me.HowtoLabel.Size = New System.Drawing.Size(261, 18)
        Me.HowtoLabel.TabIndex = 5
        Me.HowtoLabel.TabStop = True
        Me.HowtoLabel.Text = "How to find save path (Thanks to Rag)"
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 122)
        Me.Controls.Add(Me.HowtoLabel)
        Me.Controls.Add(Me.DoneBtn)
        Me.Controls.Add(Me.ChangeSave)
        Me.Controls.Add(Me.ChangeGame)
        Me.Controls.Add(Me.SaveBox)
        Me.Controls.Add(Me.GameBox)
        Me.MaximumSize = New System.Drawing.Size(563, 160)
        Me.MinimumSize = New System.Drawing.Size(563, 160)
        Me.Name = "SettingsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GameBox As TextBox
    Friend WithEvents SaveBox As TextBox
    Friend WithEvents ChangeGame As Button
    Friend WithEvents ChangeSave As Button
    Friend WithEvents DoneBtn As Button
    Friend WithEvents FolderDialog As FolderBrowserDialog
    Friend WithEvents HowtoLabel As LinkLabel
End Class
