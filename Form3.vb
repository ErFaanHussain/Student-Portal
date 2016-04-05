Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Aqua
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Continue Submit..", vbYesNo)
        If (MsgBoxResult.Ok) Then
            MsgBox("Form Submitted Successfully.")
            Form1.Show()
            Me.Hide()
            Form1.TextBox1.Clear()
            Form1.TextBox10.Clear()
            Form1.TextBox11.Clear()
            Form1.TextBox12.Clear()
            Form1.TextBox13.Clear()
            Form1.TextBox14.Clear()
            Form1.TextBox15.Clear()
            Form1.TextBox16.Clear()
            Form1.TextBox17.Clear()
            Form1.TextBox18.Clear()
            Form1.TextBox19.Clear()
            Form1.TextBox2.Clear()
            Form1.TextBox20.Clear()
            Form1.TextBox3.Clear()
            Form1.TextBox3.Clear()
            Form1.TextBox4.Clear()
            Form1.TextBox5.Clear()
            Form1.TextBox6.Clear()
            Form1.TextBox7.Clear()
            Form1.TextBox8.Clear()
            Form1.TextBox9.Clear()
            Form1.ComboBox1.SelectedIndex = 0
            Form1.ComboBox2.SelectedIndex = 0
            Form1.ComboBox3.SelectedIndex = 0
            Form1.ComboBox4.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Aqua
    End Sub
End Class