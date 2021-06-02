Public Class Responsive

    Private Resizer As New Resizer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Resizer.FindAllControls(Me)
        Me.Location = New Point((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2, (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2)
        Me.Pnl_Container.Size = New Size(Me.ClientSize.Width - 20, Me.ClientSize.Height - 20)

        Resizer.FindAllControls(Me.Pnl_Container)

        Me.DisplayWidth.Text = My.Computer.Screen.Bounds.Size.Width
        Me.DisplayHeight.Text = My.Computer.Screen.Bounds.Size.Height

        Me.ScreenWidth.Text = My.Computer.Screen.WorkingArea.Width
        Me.ScreenHeight.Text = My.Computer.Screen.WorkingArea.Height

        Me.FormWidth.Text = Me.Width
        Me.FormHeight.Text = Me.Height

        Me.InnerWidth.Text = Me.ClientSize.Width
        Me.InnerHeight.Text = Me.ClientSize.Height

        Me.PanelWidth.Text = Me.Pnl_Wrapper.Width
        Me.PanelHeight.Text = Me.Pnl_Wrapper.Height

        Me.DisplayRatio.Text = (Strings.Format((My.Computer.Screen.Bounds.Size.Width / My.Computer.Screen.Bounds.Size.Height), "0.0000000000"))
        Me.ScreenRatio.Text = (Strings.Format((My.Computer.Screen.WorkingArea.Width / My.Computer.Screen.WorkingArea.Height), "0.0000000000"))
        Me.Lbl_Header.Text = "Responsive Window - Size(" & Me.Width & " X " & Me.Height & ") - Position(" & Me.Left & " X " & Me.Top & ")"
        Me.InnerRatio.Text = (Strings.Format((Me.ClientSize.Width / Me.ClientSize.Height), "0.0000000000"))
        Me.FormRatio.Text = (Strings.Format((Me.Width / Me.ClientSize.Height), "0.0000000000"))
    End Sub

    Private Sub Btn480X320_Click(sender As System.Object, e As System.EventArgs) Handles Btn_480X320.Click
        Me.Size = New Size(480, 320)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_720X480_Click(sender As System.Object, e As System.EventArgs) Handles Btn_720X480.Click
        Me.Size = New Size(720, 480)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_800X600_Click(sender As System.Object, e As System.EventArgs) Handles Btn_800X600.Click
        Me.Size = New Size(800, 600)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1024X768_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1024X768.Click
        Me.Size = New Size(1024, 768)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1152X864_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1152X864.Click
        Me.Size = New Size(1152, 864)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1280X720_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1280X720.Click
        Me.Size = New Size(1280, 720)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1280X960_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1280X960.Click
        Me.Size = New Size(1280, 960)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1366X768_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1366X768.Click
        Me.Size = New Size(1366, 768)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1440X900_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1440X900.Click
        Me.Size = New Size(1440, 900)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1600X1200_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1600X1200.Click
        Me.Size = New Size(1600, 1200)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1680X1050_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1680X1050.Click
        Me.Size = New Size(1680, 1050)
        Me.From_Refresh()
    End Sub

    Private Sub Btn_1920X1080_Click(sender As System.Object, e As System.EventArgs) Handles Btn_1920X1080.Click
        Me.Size = New Size(1920, 1080)
        Me.From_Refresh()
    End Sub

    Private Sub Pic_Refresh_Click(sender As System.Object, e As System.EventArgs) Handles Pic_Refresh.Click
        Me.Pnl_Container.Size = New Size(Me.ClientSize.Width - 20, Me.ClientSize.Height - 20)

        Me.DisplayWidth.Text = My.Computer.Screen.Bounds.Size.Width
        Me.DisplayHeight.Text = My.Computer.Screen.Bounds.Size.Height

        Me.ScreenWidth.Text = My.Computer.Screen.WorkingArea.Width
        Me.ScreenHeight.Text = My.Computer.Screen.WorkingArea.Height

        Me.FormWidth.Text = Me.Width
        Me.FormHeight.Text = Me.Height

        Me.InnerWidth.Text = Me.ClientSize.Width
        Me.InnerHeight.Text = Me.ClientSize.Height

        Me.PanelWidth.Text = Me.Pnl_Wrapper.Width
        Me.PanelHeight.Text = Me.Pnl_Wrapper.Height

        Me.DisplayRatio.Text = (Strings.Format((My.Computer.Screen.Bounds.Size.Width / My.Computer.Screen.Bounds.Size.Height), "0.0000000000"))
        Me.ScreenRatio.Text = (Strings.Format((My.Computer.Screen.WorkingArea.Width / My.Computer.Screen.WorkingArea.Height), "0.0000000000"))
        Me.FormRatio.Text = (Strings.Format((Me.Width / Me.ClientSize.Height), "0.0000000000"))
        Me.InnerRatio.Text = (Strings.Format((Me.ClientSize.Width / Me.ClientSize.Height), "0.0000000000"))

        Resizer.ResizeAllControls(Me.Pnl_Container)
        Me.Location = New Point((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2, (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2)
        Lbl_Header.Text = "Responsive Window - Size(" & Me.Width & " X " & Me.Height & ") - Position(" & Me.Left & " X " & Me.Top & ")"
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Resizer.ResizeAllControls(Me)

        Me.Location = New Point((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2, (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2)
        Me.Pnl_Container.Size = New Size(Me.ClientSize.Width - 20, Me.ClientSize.Height - 20)
        Resizer.ResizeAllControls(Me.Pnl_Container)

        Me.DisplayWidth.Text = My.Computer.Screen.Bounds.Size.Width
        Me.DisplayHeight.Text = My.Computer.Screen.Bounds.Size.Height

        Me.ScreenWidth.Text = My.Computer.Screen.WorkingArea.Width
        Me.ScreenHeight.Text = My.Computer.Screen.WorkingArea.Height

        Me.FormWidth.Text = Me.Width
        Me.FormHeight.Text = Me.Height

        Me.InnerWidth.Text = Me.ClientSize.Width
        Me.InnerHeight.Text = Me.ClientSize.Height

        Me.PanelWidth.Text = Me.Pnl_Wrapper.Width
        Me.PanelHeight.Text = Me.Pnl_Wrapper.Height

        Me.DisplayRatio.Text = (Strings.Format((My.Computer.Screen.Bounds.Size.Width / My.Computer.Screen.Bounds.Size.Height), "0.0000000000"))
        Me.ScreenRatio.Text = (Strings.Format((My.Computer.Screen.WorkingArea.Width / My.Computer.Screen.WorkingArea.Height), "0.0000000000"))
        Me.Lbl_Header.Text = "Responsive Window - Size(" & Me.Width & " X " & Me.Height & ") - Position(" & Me.Left & " X " & Me.Top & ")"
        Me.InnerRatio.Text = (Strings.Format((Me.ClientSize.Width / Me.ClientSize.Height), "0.0000000000"))
        Me.FormRatio.Text = (Strings.Format((Me.Width / Me.ClientSize.Height), "0.0000000000"))
    End Sub

    Private Function From_Refresh()
        Me.Location = New Point((My.Computer.Screen.WorkingArea.Width - Me.Width) / 2, (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2)
        Me.Pnl_Container.Size = New Size(Me.ClientSize.Width - 20, Me.ClientSize.Height - 20)
        Resizer.ResizeAllControls(Me.Pnl_Container)

        Me.DisplayWidth.Text = My.Computer.Screen.Bounds.Size.Width
        Me.DisplayHeight.Text = My.Computer.Screen.Bounds.Size.Height

        Me.ScreenWidth.Text = My.Computer.Screen.WorkingArea.Width
        Me.ScreenHeight.Text = My.Computer.Screen.WorkingArea.Height

        Me.FormWidth.Text = Me.Width
        Me.FormHeight.Text = Me.Height

        Me.InnerWidth.Text = Me.ClientSize.Width
        Me.InnerHeight.Text = Me.ClientSize.Height

        Me.PanelWidth.Text = Me.Pnl_Wrapper.Width
        Me.PanelHeight.Text = Me.Pnl_Wrapper.Height

        Me.DisplayRatio.Text = (Strings.Format((My.Computer.Screen.Bounds.Size.Width / My.Computer.Screen.Bounds.Size.Height), "0.0000000000"))
        Me.ScreenRatio.Text = (Strings.Format((My.Computer.Screen.WorkingArea.Width / My.Computer.Screen.WorkingArea.Height), "0.0000000000"))
        Lbl_Header.Text = "Responsive Window - Size(" & Me.Width & " X " & Me.Height & ") - Position(" & Me.Left & " X " & Me.Top & ")"
        Me.InnerRatio.Text = (Strings.Format((Me.ClientSize.Width / Me.ClientSize.Height), "0.0000000000"))
        Me.FormRatio.Text = (Strings.Format((Me.Width / Me.ClientSize.Height), "0.0000000000"))

        Return True
    End Function
End Class
