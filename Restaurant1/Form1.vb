
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlOnButtonPosition.Height = btnDrinks.Height
        pnlOnButtonPosition.Top = btnDrinks.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = True
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub



    Private Sub btnPudding_Click(sender As Object, e As EventArgs) Handles btnPudding.Click
        pnlOnButtonPosition.Height = btnPudding.Height
        pnlOnButtonPosition.Top = btnPudding.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = True
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub



    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        pnlOnButtonPosition.Height = btnMyCart.Height
        pnlOnButtonPosition.Top = btnMyCart.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = True
        pnlAboutUs.Visible = False
    End Sub



    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlOnButtonPosition.Height = btnAboutUs.Height
        pnlOnButtonPosition.Top = btnAboutUs.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = True
    End Sub

    Private Sub btnFoods_Click_1(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlOnButtonPosition.Height = btnFoods.Height
        pnlOnButtonPosition.Top = btnFoods.Top
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub
End Class
