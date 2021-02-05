Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picDeepDish.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblConfirmation.Click

    End Sub

    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        picDeepDish.Visible = True
        picThinCrust.Visible = False
        btnSelectPizza.Enabled = True
    End Sub

    Private Sub btnExitWindow_Click(sender As Object, e As EventArgs) Handles btnExitWindow.Click
        Close()
    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        btnDeepDish.Enabled = False
        btnSelectPizza.Enabled = False
        btnThinCrust.Enabled = False
        lblDescription.Visible = False
        lblConfirmation.Visible = True
        btnExitWindow.Enabled = True
    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        picThinCrust.Visible = True
        picDeepDish.Visible = False
        btnSelectPizza.Enabled = True
    End Sub
End Class
