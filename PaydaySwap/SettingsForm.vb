Imports System
Imports System.IO

Public Class SettingsForm
    Private Sub ChangeGame_Click(sender As Object, e As EventArgs) Handles ChangeGame.Click
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath

        If FolderDialog.ShowDialog() = DialogResult.OK Then
            GameBox.Text = FolderDialog.SelectedPath
        End If
    End Sub

    Private Sub FolderDialog_HelpRequest(sender As Object, e As EventArgs) Handles FolderDialog.HelpRequest
    End Sub

    Private Sub ChangeSave_Click(sender As Object, e As EventArgs) Handles ChangeSave.Click
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath

        If FolderDialog.ShowDialog() = DialogResult.OK Then
            SaveBox.Text = FolderDialog.SelectedPath
        End If
    End Sub

    Private Sub HowtoLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HowtoLabel.LinkClicked
        Process.Start("http://i.imgur.com/HsDW6UR.png")
    End Sub

    Private Sub DoneBtn_Click(sender As Object, e As EventArgs) Handles DoneBtn.Click
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath

        My.Computer.FileSystem.WriteAllText((Path & "\Path.txt"), SaveBox.Text, False)
        My.Computer.FileSystem.WriteAllText((Path & "\GameDir.txt"), GameBox.Text, False)
        Main.Show()
        Me.Close()
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath
        Dim GPath As String
        Dim SPath As String

        Using sr As New StreamReader(Path & "\GameDir.txt")
            GPath = sr.ReadLine()
            If GPath <> "" Then
                GameBox.Text = (GPath)
            End If

        End Using
        Using sr2 As New StreamReader(Path & "\Path.txt")
            SPath = sr2.ReadLine()
            If SPath <> "" Then
                SaveBox.Text = (SPath)
            End If
        End Using
    End Sub
End Class