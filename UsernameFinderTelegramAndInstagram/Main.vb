Public Class Main
    Public StateProgram As Boolean = False
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnStart.Select()
    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        StateProgram = True
        If TextNoChar.Text <> "" Then
            If RadInstagram.Checked Then
                Dim item As String
                For J = 65 To 90
                    For K = 65 To 90
                        For R = 65 To 90
                            item = TextChar.Text & Chr(J).ToString.ToLower & Chr(K).ToString.ToLower & Chr(R).ToString.ToLower
                            ListGenUsers.Items.Add(item)
                            item = ""
                        Next R
                        Application.DoEvents()
                        For NumberR = 48 To 57
                            item = TextChar.Text & Chr(J).ToString.ToLower & Chr(K).ToString.ToLower & NumberR
                            ListGenUsers.Items.Add(item)
                            item = ""
                        Next NumberR
                    Next K
                    Application.DoEvents()
                    For NumberK = 48 To 57
                        item = TextChar.Text & Chr(J).ToString.ToLower & NumberK & NumberK
                        ListGenUsers.Items.Add(item)
                        item = ""
                    Next NumberK
                Next J
                Application.DoEvents()
                For NumberJ = 48 To 57
                    item = TextChar.Text & NumberJ & NumberJ & NumberJ
                    ListGenUsers.Items.Add(item)
                    item = ""
                Next NumberJ
            End If
            Server.Show()
            ' End Generator

            For User As Integer = 0 To ListGenUsers.Items.Count - 1
                If StateProgram = True Then
                    ListGenUsers.SetSelected(User, True)
                    Dim UItem As String = ListGenUsers.SelectedItem
                    If FinderIg(UItem) = True Then
                        ListProccess.Items.Add(UItem).SubItems.Add(UItem.Length)
                    End If
                    Application.DoEvents()
                Else
                    Application.DoEvents()
                    Exit For
                End If
                Label3.Text = "Digged: " & ListProccess.Items.Count
            Next
        End If
    End Sub

    Private Sub BtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStop.Click
        StateProgram = False
    End Sub

    Public Function FinderTele(ByVal Username As String) As Boolean
        Server.Web1.Navigate("https://t.me/" & Username)
        Do While Server.Web1.ReadyState <> WebBrowserReadyState.Complete Or Server.Web1.IsBusy = True : Application.DoEvents() : Loop
        Server.Web1.Navigate("javascript:alert('sdd');")
        For L As Integer = 0 To (Server.Web1.Document.GetElementsByTagName("div").Count - 1)
            If Server.Web1.Document.GetElementsByTagName("div")(L).GetAttribute("className").ToString() = "tgme_page_description" Then
                If Server.Web1.Document.GetElementsByTagName("div")(L).InnerText.IndexOf("If you have Telegram, you can contact") > 0 Then
                    FinderTele = True
                Else
                    FinderTele = False
                End If
            End If
        Next
    End Function
    Public Function FinderIg(ByVal Username As String) As Boolean
        'Setting Web site 

        ' Goto Websites
        Server.Web1.Navigate("https://instausername.com/availability?q=" & Username)
        Do While Server.Web1.ReadyState <> WebBrowserReadyState.Complete Or Server.Web1.IsBusy = True : Application.DoEvents() : Loop
        Server.Web1.ScriptErrorsSuppressed = True
        For L As Integer = 0 To Server.Web1.Document.GetElementsByTagName("input").Count - 1
            If Server.Web1.Document.GetElementsByTagName("div")(L).GetAttribute("className").ToString = "frm--msg sccs" Then
                FinderIg = True
                Exit For
            Else
                FinderIg = False
            End If
        Next
        '00aua
    End Function


    Private Sub BtnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click
        Dim sfd As New SaveFileDialog()
        sfd.Title = "Save Username"
        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim File As String = sfd.FileName
            If File.IndexOf(".txt") = 0 Then File &= ".txt"
            Dim sw As New System.IO.StreamWriter(File)

            For Line As Integer = 0 To ListProccess.Items.Count - 1
                sw.WriteLine(ListProccess.Items(Line).Text)
                Application.DoEvents()
            Next
            sw.Close()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(ListProccess.SelectedItems(0).Text)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim p As New Process
        Process.Start("https://www.instagram.com/" & ListProccess.SelectedItems(0).Text & "/")
    End Sub

    Private Sub CheckingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckingToolStripMenuItem.Click
        Dim User As String = "muq.2002"
        Dim Checker As Boolean = False
        Server.Web1.Navigate("https://instausername.com/availability?q=" & User)
        Do While Server.Web1.ReadyState <> WebBrowserReadyState.Complete Or Server.Web1.IsBusy = True : Application.DoEvents() : Loop
        For L As Integer = 0 To Server.Web1.Document.GetElementsByTagName("input").Count - 1
            If Server.Web1.Document.GetElementsByTagName("div")(L).GetAttribute("className").ToString = "frm--msg sccs" Then
                Checker = True
                Exit For
            Else
                Checker = False
            End If
        Next
    End Sub
End Class
