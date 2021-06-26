Imports System
Imports System.IO

Public Class Main
    Dim line As String
    Dim templine As String
    Dim selectedline As String
    Dim firstlaunch As Boolean = False
    Dim mainline As Boolean = False
    Dim closeprogram As Boolean = False
    Dim Readytosave As Boolean = False
    Dim savefound As Boolean = False
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    Private Sub SwapBtn_Click(sender As Object, e As EventArgs) Handles SwapBtn.Click
        If SavesBox.SelectedItem = "" Then
            Return
        End If

        If SavesBox.SelectedItem = line Then
            Return
        End If
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath
        Dim SavePath As String
        Dim GamePath As String


        Using sr2 As New StreamReader(Path & "\Path.txt")
            SavePath = sr2.ReadToEnd()
        End Using

        Using sr3 As New StreamReader(Path & "\GameDir.txt")
            GamePath = sr3.ReadToEnd()
        End Using


        Try
            For Each Line4 As String In File.ReadLines(Path & "\Save Settings\" & line & ".txt")
                If Line4 <> "" Then
                    If My.Computer.FileSystem.DirectoryExists(GamePath & "\mods\" & Line4) Then
                        System.IO.Directory.Delete((GamePath & "\mods\" & Line4), True)
                    End If
                End If
            Next
        Catch ex As Exception
        Finally
        End Try

        My.Computer.FileSystem.RenameFile(SavePath & "\save098.sav", line)

        My.Computer.FileSystem.RenameFile(SavePath & "\" & SavesBox.SelectedItem, "save098.sav")
        My.Computer.FileSystem.WriteAllText((Path & "\PaydaySaveSwap.txt"), SavesBox.SelectedItem, False)

        Dim files() As String = IO.Directory.GetFiles(SavePath)

        SavesBox.Items.Clear()

        Using sr As New StreamReader(Path & "\PaydaySaveSwap.txt")
            line = sr.ReadToEnd()
        End Using

        For Each file As String In files
            If System.IO.Path.GetFileNameWithoutExtension(file) <> "000" And System.IO.Path.GetFileNameWithoutExtension(file) <> "save098" And System.IO.Path.GetFileNameWithoutExtension(file) <> "save000" Then

                Dim S As String
                S = (System.IO.Path.GetFileNameWithoutExtension(file))

                Dim answer As Char
                answer = S.Substring(0, 1)
                If answer <> ";" Then
                    SavesBox.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
                End If
            End If
        Next
        LoadedBox.Items.Clear()
        UnloadedBox.Items.Clear()

        SavesBox.SelectedItem = line
        SavesBox.Items.Add(line)

        Try
            For Each Line2 As String In File.ReadLines(Path & "\Save Settings\" & line & ".txt")
                If Line2 <> "" Then
                    LoadedBox.Items.Add(Line2)
                End If
            Next
        Catch ex As Exception
        Finally
        End Try

        Try
            For Each Dir As String In Directory.GetDirectories(Path & "\Mods")
                For Each Line2 As String In File.ReadLines(Path & "\Save Settings\" & line & ".txt")
                    UnloadedBox.Items.Remove(Line2)
                Next

                Dim S As String
                S = System.IO.Path.GetFileNameWithoutExtension(Dir)
                UnloadedBox.Items.Add(S)
            Next
        Catch ex As Exception
        Finally
        End Try

        Try
            For Each itemz As String In LoadedBox.Items
                UnloadedBox.Items.Remove(itemz)
            Next
            For Each Line3 As String In File.ReadLines(Path & "\Save Settings\" & line & ".txt")
                If Line3 <> "" Then
                    My.Computer.FileSystem.CreateDirectory(Path & "\Mods\" & Line3)
                    My.Computer.FileSystem.CopyDirectory(Path & "\Mods\" & Line3, GamePath & "\mods\" & Line3, True)
                End If
            Next
        Catch ex As Exception
        Finally
        End Try
        SavesLabel.Text = ("Saves (Loaded: " & line & ")")
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath
        Dim SavePath As String

        Using sr3 As New StreamReader(Path & "\Path.txt")
            If sr3.ReadLine = "" Then
                SettingsForm.Show()
                Me.Close()
                Return
            End If

        End Using

        Using sr2 As New StreamReader(Path & "\Path.txt")
            SavePath = (sr2.ReadLine)
        End Using

        Using sr As New StreamReader(Path & "\PaydaySaveSwap.txt")
            line = sr.ReadToEnd()
            If line = "" Then
                firstlaunch = True
                Dim message, title, defaultValue As String
                Dim myValue As Object
                message = "Name your current save"
                title = "Save Manager"
                defaultValue = "Unnamed Save"
                myValue = InputBox(message, title, defaultValue)
                If myValue Is "" Then myValue = defaultValue
                line = myValue
                templine = myValue
            End If


        End Using

        If firstlaunch = False Then
            Dim files() As String = IO.Directory.GetFiles(SavePath)

            SavesBox.Items.Add(line)
            For Each file2 As String In files
                If System.IO.Path.GetFileNameWithoutExtension(file2) <> "000" And System.IO.Path.GetFileNameWithoutExtension(file2) <> "save098" And System.IO.Path.GetFileNameWithoutExtension(file2) <> "save000" Then

                    Dim S As String
                    S = (System.IO.Path.GetFileNameWithoutExtension(file2))

                    Dim answer As Char
                    answer = S.Substring(0, 1)
                    If answer <> ";" Then
                        SavesBox.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file2))

                        If File.Exists(Path & "\Save Settings\" & (System.IO.Path.GetFileNameWithoutExtension(file2) & ".txt")) = False Then
                            savefound = True
                            Dim fs As FileStream = File.Create(Path & "\Save Settings\" & (System.IO.Path.GetFileNameWithoutExtension(file2) & ".txt"))
                            Newsave.Enabled = True
                        End If

                    End If
                End If
            Next

            If File.Exists(Path & "\Save Settings\" & SavesBox.SelectedItem & ".txt") = False Then
                Dim fs As FileStream = File.Create(Path & "\Save Settings\" & SavesBox.SelectedItem & ".txt")
            End If


            Try
                For Each Line2 As String In File.ReadLines(Path & "\Save Settings\" & line & ".txt")
                    If Line2 <> "" Then
                        LoadedBox.Items.Add(Line2)
                    End If
                Next
            Catch ex As Exception
            Finally
            End Try

            Try
                For Each Dir As String In Directory.GetDirectories(Path & "\Mods")
                    For Each Line2 As String In File.ReadLines(Path & "\Save Settings\" & line & ".txt")
                        UnloadedBox.Items.Remove(Line2)
                    Next

                    Dim S As String
                    S = System.IO.Path.GetFileNameWithoutExtension(Dir)
                    UnloadedBox.Items.Add(S)
                Next
            Catch ex As Exception
            Finally
            End Try


            selectedline = line
            For Each itemz As String In LoadedBox.Items
                UnloadedBox.Items.Remove(itemz)
            Next

            SavesLabel.Text = ("Saves (Loaded: " & line & ")")
            SavesBox.SelectedItem = line
        End If

    End Sub

    Private Sub LoadModBtn_Click(sender As Object, e As EventArgs) Handles LoadModBtn.Click
        If UnloadedBox.SelectedItem <> "" Then
            LoadedBox.Items.Add(UnloadedBox.SelectedItem)
            UnloadedBox.Items.Remove(UnloadedBox.SelectedItem)
        End If
    End Sub

    Private Sub UnloadModBtn_Click(sender As Object, e As EventArgs) Handles UnloadModBtn.Click
        If LoadedBox.SelectedItem <> "" Then
            UnloadedBox.Items.Add(LoadedBox.SelectedItem)
            LoadedBox.Items.Remove(LoadedBox.SelectedItem)
        End If
    End Sub

    Private Sub SteamLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("http://steamcommunity.com/id/IKNCU/")
    End Sub

    Private Sub GroupLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("http://steamcommunity.com/groups/HeroesofHelheim")
    End Sub

    Private Sub ConfirmBox_Click(sender As Object, e As EventArgs) Handles ConfirmBox.Click
        If SavesBox.SelectedItem = "" Then
            SavesBox.SelectedItem = line
        End If

        ModsTextBox.Text = ""
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath

        Dim savepath As String
        Dim gamepath As String

        Using sr2 As New StreamReader(Path & "\Path.txt")
            savepath = sr2.ReadToEnd()
        End Using

        Using sr3 As New StreamReader(Path & "\GameDir.txt")
            gamepath = sr3.ReadToEnd()
        End Using


        For i = 0 To LoadedBox.Items.Count - 1
            ModsTextBox.Text &= LoadedBox.Items(i).ToString & Environment.NewLine
        Next

        My.Computer.FileSystem.WriteAllText((Path & "\Save Settings\" & SavesBox.SelectedItem & ".txt"), ModsTextBox.Text, False)

        For Each Line4 As String In UnloadedBox.Items
            If Line4 <> "" Then
                If My.Computer.FileSystem.DirectoryExists(gamepath & "\mods\" & Line4) Then
                    System.IO.Directory.Delete((gamepath & "\mods\" & Line4), True)
                End If
            End If
        Next

        For Each Line3 As String In File.ReadLines(Path & "\Save Settings\" & line & ".txt")
            If Line3 <> "" Then
                My.Computer.FileSystem.CreateDirectory(Path & "\Mods\" & Line3)
                My.Computer.FileSystem.CopyDirectory(Path & "\Mods\" & Line3, gamepath & "\mods\" & Line3, True)
            End If
        Next

    End Sub

    Private Sub SavesBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SavesBox.SelectedIndexChanged
        If SavesBox.SelectedItem = "" Then
            Return
        End If

        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath

        Dim SavePath As String


        Using sr2 As New StreamReader(Path & "\Path.txt")
            SavePath = sr2.ReadToEnd()
        End Using


        LoadedBox.Items.Clear()
        UnloadedBox.Items.Clear()

        Try
            For Each Line2 As String In File.ReadLines(Path & "\Save Settings\" & SavesBox.SelectedItem & ".txt")
                If Line2 <> "" Then
                    LoadedBox.Items.Add(Line2)
                End If
            Next
        Catch ex As Exception
        Finally
        End Try

        Try
            For Each Dir As String In Directory.GetDirectories(Path & "\Mods")
                For Each Line2 As String In File.ReadLines(Path & "\Save Settings\" & SavesBox.SelectedItem & ".txt")
                    UnloadedBox.Items.Remove(Line2)
                Next

                Dim S As String
                S = System.IO.Path.GetFileNameWithoutExtension(Dir)
                UnloadedBox.Items.Add(S)
            Next
        Catch ex As Exception
        Finally
        End Try



        For Each itemz As String In LoadedBox.Items
            UnloadedBox.Items.Remove(itemz)
        Next
    End Sub

    Private Sub SettingsBox_Click(sender As Object, e As EventArgs) Handles SettingsBox.Click
        SettingsForm.Show()
        Me.Close()
    End Sub

    Private Sub Saveit_Tick(sender As Object, e As EventArgs) Handles Saveit.Tick
        Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath

        If templine <> "" Then
            Readytosave = True
        End If
        If Readytosave = True Then
            Saveit.Enabled = False
            Dim fs As FileStream = File.Create(Path & "\Save Settings\" & templine & ".txt")
            My.Computer.FileSystem.WriteAllText((Path & "\PaydaySaveSwap.txt"), templine, False)
            MsgBox("Relaunch the program")
            Me.Close()
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub Newsave_Tick(sender As Object, e As EventArgs) Handles Newsave.Tick
        If savefound = True Then
            Dim Path As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
            Path = New Uri(Path).LocalPath

            Newsave.Enabled = False
            MsgBox("New save found, relaunch the program")
            Me.Close()
        End If
    End Sub
End Class