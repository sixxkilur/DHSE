#Region "Copyright Bullet Labs 2013 by Sixxkilur"
'This Form1.vb was created by Sixxkilur, on 4/10/2013 at 5:11 PM
'While using Lasted edited by Sixxkilur on 7/4/2013,  at 7:31 PM
#End Region

#Region "Directives"
Imports System.IO
#End Region

Public Class Form1

    Dim CourseName As String
    Dim FolderPath As String
    Dim AUN As String = (System.Environment.UserName)

#Region "Main System"

    Dim DS As String = "\"

    Dim UDir As String = "Unit"
    Dim I As Integer = 0
    Dim DB As String = "DB"
    Dim IP As String = "IP"

    Dim IExistString As String = "Initial Directory" & "              " & FolderPath & "                   " & "already Exist No Directory Created"
    Dim ICreateString As String = "Initial  Directory" & "        " & FolderPath & "                  " & "Created"

    Dim DPExistString As String = "Degree Plan Directory" & "               " & "Of User Choice" & "                  " & "already Exist No Directory Created"
    Dim DPCreateString As String = "Degree Plan Directory" & "          " & "Of User Choice" & "                " & "Created"

    Dim CExistString As String = "Course Directory" & "               " & CourseName & "                  " & "already Exist No Directory Created"
    Dim CCreateString As String = "Course Directory" & "          " & CourseName & "                  " & "Created"

    Dim UExist As String = "Unit Directory" & "              " & UDir & CStr(I + 1) & "                   " & "already Exist No Directory Created"
    Dim UCreate As String = "Unit  Directory" & "        " & UDir & CStr(I + 1) & "                  " & "Created"

    Dim IPExist As String = "Unit Directory" & "              " & IP & "                   " & "already Exist No Directory Created"
    Dim IPreate As String = "Unit  Directory" & "        " & IP & "                  " & "Created"

    Dim DBExist As String = "Unit Directory" & "              " & DB & "                   " & "already Exist No Directory Created"
    Dim DBCreate As String = "Unit  Directory" & "        " & DB & "                  " & "Created"

    Dim DPA As String = "Associate 's"
    Dim DPB As String = "Bachelor’s"
    Dim DPM As String = "Master's"

    Sub CreateDir()

        Try
            'Main Directory
            If Directory.Exists(FolderPath) = False Then
                My.Computer.FileSystem.CreateDirectory(FolderPath)
                ListBox1.Items.Add(ICreateString)
            Else
                ListBox1.Items.Add(IExistString)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        CheckDPlan()
    End Sub

    Sub CheckDPlan()
        Try
            'Main Directory
            'If Directory.Exists(FolderPath) = True Then

            'End If
            If RadioButton1.Checked Then
                'Associates
                I = 0
                'Degree Plan
                If Directory.Exists(FolderPath & DS & DPA) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA)
                    ListBox1.Items.Add(DPCreateString)
                Else
                    ListBox1.Items.Add(DPExistString)
                End If

                'CourseName
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName)
                    ListBox1.Items.Add(CCreateString)
                Else
                    ListBox1.Items.Add(CExistString)
                End If

                'Unit 1
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 2
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 3
                I = I + 1
                'TextBox1.Text = CStr(I)
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 4
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If
                'Unit 5
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPA & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If
                'End If

                'Bachelor's
                I = 0
            ElseIf RadioButton2.Checked Then
                'Degree Plan
                If Directory.Exists(FolderPath & DS & DPB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB)
                    ListBox1.Items.Add(DPCreateString)
                Else
                    ListBox1.Items.Add(DPExistString)
                End If

                'CourseName
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName)
                    ListBox1.Items.Add(CCreateString)
                Else
                    ListBox1.Items.Add(CExistString)
                End If

                'Unit 1
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 2
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 3
                I = I + 1
                'TextBox1.Text = CStr(I)
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 4
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If
                'Unit 5
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPB & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Master's
                I = 0
            ElseIf RadioButton3.Checked Then
                'Degree Plan
                If Directory.Exists(FolderPath & DS & DPM) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM)
                    ListBox1.Items.Add(DPCreateString)
                Else
                    ListBox1.Items.Add(DPExistString)
                End If

                'CourseName
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName)
                    ListBox1.Items.Add(CCreateString)
                Else
                    ListBox1.Items.Add(CExistString)
                End If

                'Unit 1
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 2
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 3
                I = I + 1
                'TextBox1.Text = CStr(I)
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If

                'Unit 4
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If
                'Unit 5
                I = I + 1
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I)) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I))
                    ListBox1.Items.Add(UCreate)
                Else
                    ListBox1.Items.Add(UExist)
                End If
                'IP
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & IP)
                    ListBox1.Items.Add(IPreate)

                Else
                    ListBox1.Items.Add(IPExist)
                End If
                'DB
                If Directory.Exists(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB) = False Then
                    My.Computer.FileSystem.CreateDirectory(FolderPath & DS & DPM & DS & CourseName & DS & UDir & " " & CStr(I) & DS & DB)
                    ListBox1.Items.Add(DBCreate)

                Else
                    ListBox1.Items.Add(DBExist)
                End If
            End If
            'ListBox1.Items.Add(IExistString)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Other Control Functions"

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources._1
        Me.Text = ProductName & "   " & "v" & ProductVersion & "         " & "Username" & "  " & AUN
        TextBox1.Text = My.Settings.Dname
        TextBox2.Text = My.Settings.Cname

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim ofd As New FolderBrowserDialog

        ofd.Description = "Please Select your Initial Course Directory"

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            FolderPath = ofd.SelectedPath
            TextBox1.Text = FolderPath
        End If

        My.Settings.Dname = FolderPath
        My.Settings.Save()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FolderPath = TextBox1.Text
        CourseName = TextBox2.Text
        My.Settings.Dname = TextBox1.Text
        My.Settings.Cname = TextBox2.Text
        My.Settings.Save()
        ListBox1.Items.Clear()
        CreateDir()
    End Sub

#End Region

End Class