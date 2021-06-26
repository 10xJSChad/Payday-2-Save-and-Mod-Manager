<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SwapBtn = New System.Windows.Forms.Button()
        Me.SavesBox = New System.Windows.Forms.ListBox()
        Me.LoadedBox = New System.Windows.Forms.ListBox()
        Me.ModsLabel = New System.Windows.Forms.Label()
        Me.SavesLabel = New System.Windows.Forms.Label()
        Me.UnloadedBox = New System.Windows.Forms.ListBox()
        Me.UnloadedModsLabel = New System.Windows.Forms.Label()
        Me.LoadModBtn = New System.Windows.Forms.Button()
        Me.UnloadModBtn = New System.Windows.Forms.Button()
        Me.ConfirmBox = New System.Windows.Forms.Button()
        Me.ModsTextBox = New System.Windows.Forms.TextBox()
        Me.SettingsBox = New System.Windows.Forms.Button()
        Me.Saveit = New System.Windows.Forms.Timer(Me.components)
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Newsave = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'SwapBtn
        '
        Me.SwapBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.SwapBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SwapBtn.FlatAppearance.BorderSize = 3
        Me.SwapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SwapBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwapBtn.ForeColor = System.Drawing.Color.White
        Me.SwapBtn.Location = New System.Drawing.Point(351, 46)
        Me.SwapBtn.Name = "SwapBtn"
        Me.SwapBtn.Size = New System.Drawing.Size(258, 124)
        Me.SwapBtn.TabIndex = 0
        Me.SwapBtn.Text = "Load Save"
        Me.SwapBtn.UseVisualStyleBackColor = False
        '
        'SavesBox
        '
        Me.SavesBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.SavesBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SavesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavesBox.ForeColor = System.Drawing.Color.White
        Me.SavesBox.FormattingEnabled = True
        Me.SavesBox.ItemHeight = 24
        Me.SavesBox.Location = New System.Drawing.Point(12, 46)
        Me.SavesBox.Name = "SavesBox"
        Me.SavesBox.Size = New System.Drawing.Size(320, 120)
        Me.SavesBox.TabIndex = 1
        '
        'LoadedBox
        '
        Me.LoadedBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.LoadedBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LoadedBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadedBox.ForeColor = System.Drawing.Color.White
        Me.LoadedBox.FormattingEnabled = True
        Me.LoadedBox.ItemHeight = 24
        Me.LoadedBox.Location = New System.Drawing.Point(12, 211)
        Me.LoadedBox.Name = "LoadedBox"
        Me.LoadedBox.Size = New System.Drawing.Size(252, 216)
        Me.LoadedBox.TabIndex = 2
        '
        'ModsLabel
        '
        Me.ModsLabel.AutoSize = True
        Me.ModsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModsLabel.ForeColor = System.Drawing.Color.White
        Me.ModsLabel.Location = New System.Drawing.Point(8, 184)
        Me.ModsLabel.Name = "ModsLabel"
        Me.ModsLabel.Size = New System.Drawing.Size(126, 24)
        Me.ModsLabel.TabIndex = 3
        Me.ModsLabel.Text = "Loaded Mods"
        '
        'SavesLabel
        '
        Me.SavesLabel.AutoSize = True
        Me.SavesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavesLabel.ForeColor = System.Drawing.Color.White
        Me.SavesLabel.Location = New System.Drawing.Point(8, 19)
        Me.SavesLabel.Name = "SavesLabel"
        Me.SavesLabel.Size = New System.Drawing.Size(193, 24)
        Me.SavesLabel.TabIndex = 4
        Me.SavesLabel.Text = "Saves (Loaded: Main)"
        '
        'UnloadedBox
        '
        Me.UnloadedBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.UnloadedBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UnloadedBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnloadedBox.ForeColor = System.Drawing.Color.White
        Me.UnloadedBox.FormattingEnabled = True
        Me.UnloadedBox.ItemHeight = 24
        Me.UnloadedBox.Location = New System.Drawing.Point(357, 211)
        Me.UnloadedBox.Name = "UnloadedBox"
        Me.UnloadedBox.Size = New System.Drawing.Size(252, 216)
        Me.UnloadedBox.TabIndex = 5
        '
        'UnloadedModsLabel
        '
        Me.UnloadedModsLabel.AutoSize = True
        Me.UnloadedModsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnloadedModsLabel.ForeColor = System.Drawing.Color.White
        Me.UnloadedModsLabel.Location = New System.Drawing.Point(465, 184)
        Me.UnloadedModsLabel.Name = "UnloadedModsLabel"
        Me.UnloadedModsLabel.Size = New System.Drawing.Size(144, 24)
        Me.UnloadedModsLabel.TabIndex = 6
        Me.UnloadedModsLabel.Text = "Unloaded Mods"
        '
        'LoadModBtn
        '
        Me.LoadModBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.LoadModBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LoadModBtn.FlatAppearance.BorderSize = 3
        Me.LoadModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadModBtn.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadModBtn.ForeColor = System.Drawing.Color.White
        Me.LoadModBtn.Location = New System.Drawing.Point(268, 259)
        Me.LoadModBtn.Name = "LoadModBtn"
        Me.LoadModBtn.Size = New System.Drawing.Size(83, 36)
        Me.LoadModBtn.TabIndex = 7
        Me.LoadModBtn.Text = "<-"
        Me.LoadModBtn.UseVisualStyleBackColor = False
        '
        'UnloadModBtn
        '
        Me.UnloadModBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.UnloadModBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UnloadModBtn.FlatAppearance.BorderSize = 3
        Me.UnloadModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UnloadModBtn.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnloadModBtn.ForeColor = System.Drawing.Color.White
        Me.UnloadModBtn.Location = New System.Drawing.Point(268, 301)
        Me.UnloadModBtn.Name = "UnloadModBtn"
        Me.UnloadModBtn.Size = New System.Drawing.Size(83, 36)
        Me.UnloadModBtn.TabIndex = 8
        Me.UnloadModBtn.Text = "->"
        Me.UnloadModBtn.UseVisualStyleBackColor = False
        '
        'ConfirmBox
        '
        Me.ConfirmBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.ConfirmBox.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ConfirmBox.FlatAppearance.BorderSize = 3
        Me.ConfirmBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmBox.ForeColor = System.Drawing.Color.White
        Me.ConfirmBox.Location = New System.Drawing.Point(268, 343)
        Me.ConfirmBox.Name = "ConfirmBox"
        Me.ConfirmBox.Size = New System.Drawing.Size(83, 37)
        Me.ConfirmBox.TabIndex = 11
        Me.ConfirmBox.Text = "Save"
        Me.ConfirmBox.UseVisualStyleBackColor = False
        '
        'ModsTextBox
        '
        Me.ModsTextBox.Location = New System.Drawing.Point(15, 468)
        Me.ModsTextBox.Multiline = True
        Me.ModsTextBox.Name = "ModsTextBox"
        Me.ModsTextBox.Size = New System.Drawing.Size(195, 135)
        Me.ModsTextBox.TabIndex = 12
        '
        'SettingsBox
        '
        Me.SettingsBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.SettingsBox.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SettingsBox.FlatAppearance.BorderSize = 3
        Me.SettingsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsBox.ForeColor = System.Drawing.Color.White
        Me.SettingsBox.Location = New System.Drawing.Point(383, 5)
        Me.SettingsBox.Name = "SettingsBox"
        Me.SettingsBox.Size = New System.Drawing.Size(110, 34)
        Me.SettingsBox.TabIndex = 13
        Me.SettingsBox.Text = "Settings"
        Me.SettingsBox.UseVisualStyleBackColor = False
        '
        'Saveit
        '
        Me.Saveit.Enabled = True
        Me.Saveit.Interval = 1
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ExitBtn.FlatAppearance.BorderSize = 3
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.White
        Me.ExitBtn.Location = New System.Drawing.Point(499, 5)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(110, 34)
        Me.ExitBtn.TabIndex = 14
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Newsave
        '
        Me.Newsave.Enabled = True
        Me.Newsave.Interval = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(637, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.SettingsBox)
        Me.Controls.Add(Me.ModsTextBox)
        Me.Controls.Add(Me.ConfirmBox)
        Me.Controls.Add(Me.UnloadModBtn)
        Me.Controls.Add(Me.LoadModBtn)
        Me.Controls.Add(Me.UnloadedModsLabel)
        Me.Controls.Add(Me.UnloadedBox)
        Me.Controls.Add(Me.SavesLabel)
        Me.Controls.Add(Me.ModsLabel)
        Me.Controls.Add(Me.LoadedBox)
        Me.Controls.Add(Me.SavesBox)
        Me.Controls.Add(Me.SwapBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(637, 460)
        Me.MinimumSize = New System.Drawing.Size(637, 460)
        Me.Name = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SwapBtn As Button
    Friend WithEvents SavesBox As ListBox
    Friend WithEvents LoadedBox As ListBox
    Friend WithEvents ModsLabel As Label
    Friend WithEvents SavesLabel As Label
    Friend WithEvents UnloadedBox As ListBox
    Friend WithEvents UnloadedModsLabel As Label
    Friend WithEvents LoadModBtn As Button
    Friend WithEvents UnloadModBtn As Button
    Friend WithEvents ConfirmBox As Button
    Friend WithEvents ModsTextBox As TextBox
    Friend WithEvents SettingsBox As Button
    Friend WithEvents Saveit As Timer
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Newsave As Timer
End Class
