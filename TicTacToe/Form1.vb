Public Class Form1

    Private Sub player1_name_Enter(sender As Object, e As EventArgs) Handles player1_name.Enter
        If player1_name.Text = "enter player x's name" Then
            player1_name.Text = ""
        End If
    End Sub

    Private Sub player2_name_Enter(sender As Object, e As EventArgs) Handles player2_name.Enter
        If player2_name.Text = "enter player o's name" Then
            player2_name.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_next.Select()
    End Sub

    Private Sub player1_name_Leave(sender As Object, e As EventArgs) Handles player1_name.Leave
        If player1_name.Text = "" Then
            player1_name.Text = "enter player x's name"
        End If
    End Sub

    Private Sub player2_name_Leave(sender As Object, e As EventArgs) Handles player2_name.Leave
        If player2_name.Text = "" Then
            player2_name.Text = "enter player o's name"
        End If
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        btn_next.Select() 'focus the next button the form area is clicked

        If player1_name.Text = "" Then
            player1_name.Text = "enter player x's name"
        ElseIf player2_name.Text = "" Then
            player2_name.Text = "enter player o's name"
        End If
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If (player1_name.Text = "" Or player1_name.Text = "enter player x's name") And (player2_name.Text = "" Or player2_name.Text = "enter player o's name") Then
            MsgBox("Enter the player's name.")
        ElseIf player1_name.Text = "" Or player1_name.Text = "enter player x's name" Then
            MsgBox("Enter the Player X's name.")
        ElseIf player2_name.Text = "" Or player2_name.Text = "enter player o's name" Then
            MsgBox("Enter the Player O's name.")
        ElseIf player1_name.Text = player2_name.Text Then
            MsgBox("Both the player's name cannot be the same!")
        ElseIf player1_name.Text.Length > 10 Or player2_name.Text.Length > 10 Then
            MsgBox("Kindly keep names upto 10 chars.")
        ElseIf ContainsSpecialChars(player1_name.Text) Or ContainsSpecialChars(player2_name.Text) Then
            MsgBox("Names cannot contain special characters.")
        Else
            Me.Hide()
            Dim Form2 As New Form2
            Form2.Show()
            Me.Close()
        End If
    End Sub

    Function ContainsSpecialChars(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    Private Sub player1_name_KeyDown(sender As Object, e As KeyEventArgs) Handles player1_name.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            player2_name.Select()
        End If
    End Sub

    Private Sub player2_name_KeyDown(sender As Object, e As KeyEventArgs) Handles player2_name.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            btn_next.Select()
            btn_next.PerformClick()
        End If
    End Sub

End Class
