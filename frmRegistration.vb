Public Class frmRegistration
    Private Sub frmRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbPinCode.Items.Add("Pin Code")
        cbProgramme.Items.Add("Select Course First")
        Dim arr As String
        For i = 0 To core_inc.districts.Length - 1
            Try
                arr = core_inc.districts(i)
                cbDistrict.Items.Add(arr)
            Catch ex As System.IndexOutOfRangeException
                MsgBox("Something went wrong")
            End Try

        Next i
        cbCourse.SelectedIndex = 0
        cbDistrict.SelectedIndex = 0
        cbPinCode.SelectedIndex = 0
        cbReligion.SelectedIndex = 0
        cbCategory.SelectedIndex = 0
        cbProgramme.SelectedIndex = 0
        lblDegree1.Visible = False
        lblDegree.Visible = False
        lblDegree2.Visible = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectImage.Click
        OpenFileDialog1.ShowDialog()
        'PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Try

            Dim bm_source As New Bitmap(Image.FromFile(OpenFileDialog1.FileName))
            Dim bm_dest As New Bitmap(CInt(108), CInt(120))
            Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1)
            PictureBox1.Image = bm_dest
            Label17.Hide()
        Catch ex As System.IO.FileNotFoundException
            MsgBox("Please Select an Image", vbCancel, vbOK)
        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If ((txtName.Text.Length = 0) Or (txtFName.Text.Length = 0) Or (txtResidence.Text.Length = 0) Or (cbDistrict.Text.Length = 0) _
            Or (cbPinCode.Text.Length = 0) Or (DTPdob.Text.Length = 0) Or (Not rdMale.Checked And Not rdFemale.Checked) _
            Or (cbReligion.SelectedItem = "Select") Or (cbCategory.SelectedItem = "Select") Or (cbCourse.SelectedItem = "Select") _
            Or (Not rdDisabledYes.Checked And Not rdDisabledNo.Checked) Or (txtContact.Text.Length = 0) Or (txtEmail.Text.Length = 0) _
            Or (txtCAddress.Text.Length = 0) Or (txtADUniSch1.Text.Length = 0) Or (txtADUniSch2.Text.Length = 0) Or (txtADYear1.Text.Length = 0) Or (txtADYear2.Text.Length = 0) _
            Or (txtADMMarks1.Text.Length = 0) Or (txtADMMarks2.Text.Length = 0) Or (txtADMarks1.Text.Length = 0) Or (txtADMarks2.Text.Length = 0)) Then
            MsgBox("Some details missing, Please review and enter all the details")

        Else
            core_inc.name = txtName.Text
            fname = txtFName.Text
            address = txtResidence.Text
            dob = DTPdob.Text
            tdistrict = cbDistrict.Text
            pinCode = cbPinCode.Text

            If (rdMale.Checked) Then
                gender = "male"
            ElseIf (rdFemale.Checked) Then
                gender = "Female"
            End If
            religion = cbReligion.Text
            If (rdDisabledYes.Checked) Then
                disabled = "Yes"
            ElseIf (rdDisabledNo.Checked) Then
                disabled = "No"
            End If
            contact = txtContact.Text
            email = txtEmail.Text
            caddress = txtCAddress.Text
            course = cbCourse.Text
            programme = cbProgramme.Text
            AdUnSc1 = txtADUniSch1.Text
            AdUnSc2 = txtADUniSch2.Text
            AdYear1 = txtADYear1.Text
            AdYear2 = txtADYear2.Text
            AdMarks1 = txtADMarks1.Text
            AdMarks2 = txtADMarks2.Text
            AdMMarks1 = txtADMMarks1.Text
            AdMMarks2 = txtADMMarks2.Text
            AdPer1 = txtADPer1.Text
            AdPer2 = txtADPer2.Text
            AdDeg1 = lblDegree1.Text
            AdDeg2 = lblDegree2.Text
            Me.Hide()
            frmDocUpload.Show()

        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCourse.SelectedIndexChanged
        If (cbCourse.SelectedItem = "Computer Science") Then
            cbProgramme.Items.Clear()
            cbProgramme.Items.Add("Select Programme")
            cbProgramme.SelectedIndex = 0
            cbProgramme.Items.Add("MCA")
            cbProgramme.Items.Add("B-Tech CSE")

        ElseIf (cbCourse.SelectedItem = "B-Tech") Then
            cbProgramme.Items.Clear()
            cbProgramme.Items.Add("Select Programme")
            cbProgramme.SelectedIndex = 0
            cbProgramme.Items.Add("Civil Engineering")
            cbProgramme.Items.Add("Mechanical Engineering")
            cbProgramme.Items.Add("Electrical Engineering")
            cbProgramme.Items.Add("E&C Engineering")
        ElseIf (cbCourse.SelectedItem = "Business Studies") Then
            cbProgramme.Items.Clear()
            cbProgramme.Items.Add("Select Programme")
            cbProgramme.SelectedIndex = 0
            cbProgramme.Items.Add("BBA")
            cbProgramme.Items.Add("MBA")
            cbProgramme.Items.Add("PhD")
        ElseIf (cbCourse.SelectedItem = "MA") Then
            cbProgramme.Items.Clear()
            cbProgramme.Items.Add("Select Programme")
            cbProgramme.SelectedIndex = 0
            cbProgramme.Items.Add("Arabic")
            cbProgramme.Items.Add("Islamic Studies")
            cbProgramme.Items.Add("Mass Comm & Journalism")
        ElseIf (cbCourse.SelectedItem = "MSc") Then
            cbProgramme.Items.Clear()
            cbProgramme.Items.Add("Select Programme")
            cbProgramme.SelectedIndex = 0
            cbProgramme.Items.Add("Food Technology")
            cbProgramme.Items.Add("Mathematics")
            cbProgramme.Items.Add("Information Technology")
        ElseIf (cbCourse.SelectedItem = "Select") Then
            cbProgramme.Items.Clear()
            cbProgramme.Items.Add("Select Course First")
            cbProgramme.SelectedIndex = 0
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtFName.Clear()
        txtResidence.Clear()
        txtContact.Clear()
        txtADUniSch1.Clear()
        txtADYear1.Clear()
        txtADPer1.Clear()
        txtEmail.Clear()
        txtCAddress.Clear()
        txtADPer2.Clear()
        txtADYear2.Clear()
        txtADUniSch2.Clear()

    End Sub

    Private Sub cbDistrict_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbDistrict.SelectedIndexChanged
        If (cbDistrict.SelectedItem = "Srinagar") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesSrinagar.Length - 1
                cbPinCode.Items.Add(pinCodesSrinagar(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Pulwama") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesPulwama.Length - 1
                cbPinCode.Items.Add(pinCodesPulwama(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Anantnag") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesAnantnag.Length - 1
                cbPinCode.Items.Add(pinCodesAnantnag(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Budgam") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesBudgam.Length - 1
                cbPinCode.Items.Add(pinCodesBudgam(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Baramulla") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesBaramulla.Length - 1
                cbPinCode.Items.Add(pinCodesBaramulla(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Kupwara") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesKupwara.Length - 1
                cbPinCode.Items.Add(pinCodesKupwara(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Kulgam") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesKulgam.Length - 1
                cbPinCode.Items.Add(pinCodesKulgam(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Bandipora") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesBandipora.Length - 1
                cbPinCode.Items.Add(pinCodesBandipora(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Ganderbal") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesGanderbal.Length - 1
                cbPinCode.Items.Add(pinCodesGanderbal(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Shopian") Then
            cbPinCode.Items.Clear()
            For i = 0 To core_inc.pinCodesShopian.Length - 1
                cbPinCode.Items.Add(pinCodesShopian(i))
            Next i
        ElseIf (cbDistrict.SelectedItem = "Select District") Then
            cbPinCode.Items.Clear()
            cbPinCode.Items.Add("Pin Code")
            cbPinCode.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtName.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (txtName.Text.Length > 0) Then
                txtFName.Focus()
            Else
                MsgBox("Please enter name", vbOKCancel)
            End If
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "[^ A-Z]") Then
            MsgBox("only characters allowed")
            txtName.Clear()
        End If
    End Sub


    Private Sub txtFName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFName.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(txtFName.Text, "[^ A-Z]") Then
            MsgBox("Only Characters Allowed")
            txtFName.Clear()
        End If
    End Sub

    Private Sub txtFName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFName.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (txtFName.Text.Length > 0) Then
                txtResidence.Focus()
            Else
                MsgBox("Please Enter Father's Name", vbOKCancel)
            End If
        End If
    End Sub

    Private Sub txtResidence_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResidence.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(txtResidence.Text, "[^ A-Z]") Then
            MsgBox("Only Characters Allowed")
            txtResidence.Clear()
        End If
    End Sub

    Private Sub txtResidence_KeyUp(sender As Object, e As KeyEventArgs) Handles txtResidence.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (txtResidence.Text.Length > 0) Then
                cbDistrict.Focus()
            Else
                MsgBox("Please Enter your address", vbOKCancel)
            End If
        End If
    End Sub

    Private Sub cbDistrict_KeyUp(sender As Object, e As KeyEventArgs) Handles cbDistrict.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (Not cbDistrict.Text = "Select District") Then
                cbPinCode.Focus()
            Else
                MsgBox("Please select District", vbOKCancel)
            End If
        End If
    End Sub


    Private Sub cbPinCode_KeyUp(sender As Object, e As KeyEventArgs) Handles cbPinCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (Not cbPinCode.Text = "Pin Code") Then
                DTPdob.Focus()
            Else
                MsgBox("Please enter/select PinCode", vbOKCancel)
            End If
        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged

    End Sub

    Private Sub txtContact_KeyUp(sender As Object, e As KeyEventArgs) Handles txtContact.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (txtContact.Text.Length = 10) Then
                txtEmail.Focus()
            Else
                MsgBox("Please Enter your contact number", vbOKCancel)
            End If
        End If
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(txtContact.Text, "[^0-9]") Then
            txtContact.Text = ""
            MsgBox("Only Numbers Allowed")
        End If
    End Sub


    Private Sub txtEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (txtEmail.Text.Length > 1) Then
                txtCAddress.Focus()
            Else
                MsgBox("Please Enter your email", vbOKCancel)
            End If
        End If
    End Sub

    Private Sub txtCAddress_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCAddress.KeyUp
        If e.KeyCode = Keys.Enter Then
            If (txtCAddress.Text.Length > 1) Then
                txtADUniSch1.Focus()
            Else
                MsgBox("Please enter your Correpondence Address", vbOKCancel)
            End If
        End If
    End Sub

    Private Sub cbProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgramme.SelectedIndexChanged
        If (cbProgramme.SelectedItem = "Civil Engineering") Or (cbProgramme.SelectedItem = "Mechanical Engineering") Or (cbProgramme.SelectedItem = "Electrical Engineering") Or (cbProgramme.SelectedItem = "E&C Engineering") Or (cbProgramme.SelectedItem = "B-Tech CSE") Or (cbProgramme.SelectedItem = "BBA") Then
            lblDegree.Visible = True
            lblDegree1.Visible = True
            lblDegree1.Text = "10th"
            lblDegree2.Visible = True
            lblDegree2.Text = "12th"
        ElseIf (cbProgramme.SelectedItem = "Food Technology") Or (cbProgramme.SelectedItem = "Mathematics") _
             Or (cbProgramme.SelectedItem = "Information Technology") Or (cbProgramme.SelectedItem = "MCA") _
             Or (cbProgramme.SelectedItem = "Arabic") Or (cbProgramme.SelectedItem = "Islamic Studies") _
             Or (cbProgramme.SelectedItem = "Mass Comm & Journalism") Then
            lblDegree.Visible = True
            lblDegree1.Visible = True
            lblDegree1.Text = "12th"
            lblDegree2.Visible = True
            lblDegree2.Text = "Graduation"
        ElseIf (cbProgramme.SelectedItem = "MBA") Then
            lblDegree.Visible = True
            lblDegree1.Visible = True
            lblDegree1.Text = "12th"
            lblDegree2.Visible = True
            lblDegree2.Text = "Graduation/BBA"
        ElseIf (cbProgramme.SelectedItem = "PhD") Then
            lblDegree.Visible = True
            lblDegree1.Visible = True
            lblDegree1.Text = "Graduation/BBA"
            lblDegree2.Visible = True
            lblDegree2.Text = "Masters/MBA"
        ElseIf (cbProgramme.SelectedItem = "Select Programme") Or (cbCourse.SelectedItem = "Select") Then
            lblDegree.Visible = False
            lblDegree1.Visible = False
            lblDegree2.Visible = False
        End If

    End Sub

    Private Sub txtADMMarks1_TextChanged(sender As Object, e As EventArgs) Handles txtADMMarks1.TextChanged
        Dim per1 As Integer
        Dim perr1 As String
        per1 = Val(txtADMarks1.Text) / Val(txtADMMarks1.Text) * 100
        perr1 = per1.ToString()

        txtADPer1.Text = perr1 + "%"


    End Sub

    Private Sub txtADMMarks2_TextChanged(sender As Object, e As EventArgs) Handles txtADMMarks2.TextChanged
        Dim per2 As Integer
        Dim perr2 As String

        per2 = Val(txtADMarks2.Text) / Val(txtADMMarks2.Text) * 100
        perr2 = per2.ToString
        txtADPer2.Text = perr2 + "%"

    End Sub
End Class