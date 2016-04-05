Public Class frmVerify

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = core_inc.name
        TextBox2.Text = core_inc.fname
        TextBox3.Text = address
        TextBox4.Text = tdistrict
        TextBox5.Text = pinCode
        TextBox6.Text = gender
        TextBox7.Text = religion
        TextBox8.Text = disabled
        TextBox9.Text = dob
        TextBox10.Text = contact
        TextBox11.Text = email
        TextBox12.Text = caddress
        TextBox13.Text = course
        TextBox14.Text = programme

        t1.Text = AdUnSc1
        t2.Text = AdUnSc2
        t3.Text = AdYear1
        t4.Text = AdYear2
        t5.Text = AdMarks1
        t6.Text = AdMarks2
        t7.Text = AdMMarks1
        t8.Text = AdMMarks2
        t9.Text = AdPer1
        t10.Text = AdPer2
        t11.Text = AdDeg1
        t12.Text = AdDeg2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub
End Class