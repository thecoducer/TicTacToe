Public Class Form2

    Dim mark_counter As Integer
    Dim count As Integer = 1 'count is a counter for button click
    Dim flag As Integer = 2 '-1 means draw, 1 means X and 0 means O

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Select()
        Me.player1.Text = StrConv(Form1.player1_name.Text, VbStrConv.ProperCase)
        Me.player2.Text = StrConv(Form1.player2_name.Text, VbStrConv.ProperCase)
        GroupBox1.Text = "Make a mark!"
        mark_counter = 0
    End Sub

    Private Sub Box_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        Dim b As Button = sender
        If mark_counter = 0 And b.Text = "" Then
            GroupBox1.Text = "It's " + StrConv(player2.Text, VbStrConv.ProperCase) + "'s turn to place O"
            b.Text = "X"
            mark_counter = 1
            Check_possibilities()
            count = count + 1
        ElseIf mark_counter = 1 And b.Text = "" Then
            GroupBox1.Text = "It's " + StrConv(player1.Text, VbStrConv.ProperCase) + "'s turn to place X"
            b.Text = "O"
            mark_counter = 0
            Check_possibilities()
            count = count + 1
        End If
    End Sub

    Private Function Check_possibilities()
        'Player X's win possibilities
        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            flag = 1
            Button1.BackColor = Color.LightCoral
            Button5.BackColor = Color.LightCoral
            Button9.BackColor = Color.LightCoral
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            flag = 1
            Button3.BackColor = Color.LightCoral
            Button5.BackColor = Color.LightCoral
            Button7.BackColor = Color.LightCoral
        ElseIf Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            flag = 1
            Button1.BackColor = Color.LightCoral
            Button2.BackColor = Color.LightCoral
            Button3.BackColor = Color.LightCoral
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            flag = 1
            Button4.BackColor = Color.LightCoral
            Button5.BackColor = Color.LightCoral
            Button6.BackColor = Color.LightCoral
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            flag = 1
            Button7.BackColor = Color.LightCoral
            Button8.BackColor = Color.LightCoral
            Button9.BackColor = Color.LightCoral
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            flag = 1
            Button1.BackColor = Color.LightCoral
            Button4.BackColor = Color.LightCoral
            Button7.BackColor = Color.LightCoral
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            flag = 1
            Button2.BackColor = Color.LightCoral
            Button5.BackColor = Color.LightCoral
            Button8.BackColor = Color.LightCoral
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            flag = 1
            Button3.BackColor = Color.LightCoral
            Button6.BackColor = Color.LightCoral
            Button9.BackColor = Color.LightCoral
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            flag = 0
            Button1.BackColor = Color.MediumAquamarine
            Button5.BackColor = Color.MediumAquamarine
            Button9.BackColor = Color.MediumAquamarine
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            flag = 0
            Button3.BackColor = Color.MediumAquamarine
            Button5.BackColor = Color.MediumAquamarine
            Button7.BackColor = Color.MediumAquamarine
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            flag = 0
            Button1.BackColor = Color.MediumAquamarine
            Button2.BackColor = Color.MediumAquamarine
            Button3.BackColor = Color.MediumAquamarine
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            flag = 0
            Button4.BackColor = Color.MediumAquamarine
            Button5.BackColor = Color.MediumAquamarine
            Button6.BackColor = Color.MediumAquamarine
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            flag = 0
            Button7.BackColor = Color.MediumAquamarine
            Button8.BackColor = Color.MediumAquamarine
            Button9.BackColor = Color.MediumAquamarine
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            flag = 0
            Button1.BackColor = Color.MediumAquamarine
            Button4.BackColor = Color.MediumAquamarine
            Button7.BackColor = Color.MediumAquamarine
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            flag = 0
            Button2.BackColor = Color.MediumAquamarine
            Button5.BackColor = Color.MediumAquamarine
            Button8.BackColor = Color.MediumAquamarine
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            flag = 0
            Button3.BackColor = Color.MediumAquamarine
            Button6.BackColor = Color.MediumAquamarine
            Button9.BackColor = Color.MediumAquamarine
        ElseIf count = 9 Then
            flag = -1
        End If

        If flag = 1 Then
            MsgBox("㊗️ " + player1.Text + " won!")
            Update_score(flag)
            Reset_field()
        ElseIf flag = 0 Then
            MsgBox("㊗️ " + player2.Text + " won!")
            Update_score(flag)
            Reset_field()
        ElseIf flag = -1 Then
            MsgBox("Draw!")
            Reset_field()
        End If
    End Function

    Private Function Update_score(ByVal flag As Integer)
        If flag = 1 Then
            score_x.Text = score_x.Text + 5
        ElseIf flag = 0 Then
            score_o.Text = score_o.Text + 5
        End If
    End Function

    Private Function Reset_field()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        GroupBox1.Text = "Make a mark!"
        mark_counter = 0
        flag = 2
        count = 1

        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        Button5.BackColor = Color.Transparent
        Button6.BackColor = Color.Transparent
        Button7.BackColor = Color.Transparent
        Button8.BackColor = Color.Transparent
        Button9.BackColor = Color.Transparent
    End Function

    Private Sub restart_Click(sender As Object, e As EventArgs) Handles restart.Click
        Application.Restart()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show(
    "Developed by Mayukh Datta
        (@thecoducer)
        - Version 1.0, 2018
        - www.thecoducer.com",
    "About WowCalci",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button2,
    0, '0 is default otherwise use MessageBoxOptions Enum
    "https://thecoducer.github.io/",
    "contact")
    End Sub

End Class