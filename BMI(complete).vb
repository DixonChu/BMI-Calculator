Public Class Form1
    Dim h As Double
    Dim w As Double
    Dim t As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblBMI.Text = ""
        txtHeight.Clear()
        txtWeight.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        h = txtHeight.Text
        w = txtWeight.Text
        t = w / (h * h)

        lblBMI.Text = String.Format("{0:f}", t)

        If t <= 18.4 Then
            lblBMI.BackColor = Color.Red
        ElseIf t <= 24.9 Then
            lblBMI.BackColor = Color.Green
        ElseIf t <= 29.9 Then
            lblBMI.BackColor = Color.Yellow
        ElseIf t >= 30.0 Then
            lblBMI.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
