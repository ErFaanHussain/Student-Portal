Public Class frmDocUpload

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmRegistration.Show()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()
        PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmRegistration.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmVerify.Show()
        Me.Hide()
        frmVerify.TextBox1.Text = frmRegistration.txtName.Text
        frmVerify.TextBox2.Text = frmRegistration.txtFName.Text
        frmVerify.TextBox3.Text = frmRegistration.txtResidence.Text
    End Sub
End Class