Public Class universityAdmissionsPointSystem
    Private Sub txtBoxGPA_Leave(sender As Object, e As EventArgs) Handles txtBoxGPA.Leave
        Dim param As Double

        'Checks the input to make sure it's valid (between 2.0 and 4.0) by using the TryParse method
        If Double.TryParse(txtBoxGPA.Text, param) Then
            If txtBoxGPA.Text > 4.0 Or txtBoxGPA.Text < 2.0 Then
                MessageBox.Show("Please enter in a valid GPA from 2.0 to 4.0.")

            Else
                txtBoxgpaTimes20.Text = "[" & txtBoxGPA.Text * 20 & "]"
            End If

            'Makes sure the error box doesn't show up if there is no input inside the text box
        ElseIf txtBoxGPA.Text = "" Then
            txtBoxgpaTimes20.Text = ""
        Else
            MessageBox.Show("Please enter in a valid GPA from 2.0 to 4.0.")
        End If

    End Sub

    Private Sub btnCalcTotalScore_Click(sender As Object, e As EventArgs) Handles btnCalcTotalScore.Click

        Dim totalScore As Integer
        Dim topHalf As Integer
        Dim bottomHalf As Integer

        'The first If statement focuses on the top half of point calculations since it isn't capped at a maximum of 40 points
        'Makes sure that there is a valid GPA inside the text box before calculating the total
        If (txtBoxgpaTimes20.Text = "") Then
            MessageBox.Show("Please enter in a valid GPA from 2.0 to 4.0.")
        Else
            topHalf = topHalf + (txtBoxGPA.Text * 20)

            'SAT Score
            If radioBtnSAT930to1000.Checked Then
                topHalf = topHalf + 6
            End If

            If radioBtnSAT1010to1190.Checked Then
                topHalf = topHalf + 10
            End If

            If radioBtnSAT1200to1350.Checked Then
                topHalf = topHalf + 11
            End If

            If radioBtnSAT1360to1600.Checked Then
                topHalf = topHalf + 12
            End If

            'High School Quality
            If radioBtn1.Checked Then
                topHalf = topHalf + 2
            End If

            If radioBtn2.Checked Then
                topHalf = topHalf + 4
            End If

            If radioBtn3.Checked Then
                topHalf = topHalf + 6
            End If

            If radioBtn4.Checked Then
                topHalf = topHalf + 8
            End If

            If radioBtn5.Checked Then
                topHalf = topHalf + 10
            End If

            'Difficulty of Curriculum
            If radioBtnNeg2Neg4.Checked Then
                topHalf = topHalf - 4
            End If

            If radioBtnNeg1Neg2.Checked Then
                topHalf = topHalf - 2
            End If

            If radioBtn12.Checked Then
                topHalf = topHalf + 2
            End If

            If radioBtn24.Checked Then
                topHalf = topHalf + 4
            End If

            If radioBtn36.Checked Then
                topHalf = topHalf + 6
            End If

            If radioBtn48.Checked Then
                topHalf = topHalf + 8
            End If

        End If

        'The second If statement focuses on the bottom half of point calculations since it is capped at a maximum of 40 points.
        'Again, makes sure that there is a valid GPA inside the text box before calculating the total
        If (txtBoxgpaTimes20.Text = "") Then
            MessageBox.Show("Please enter in a valid GPA from 2.0 to 4.0.")
        Else
            If checkBoxStateResident.Checked Then
                bottomHalf = bottomHalf + 10
            End If

            If checkBoxLegacy.Checked Then
                bottomHalf = bottomHalf + 4
            End If

            If checkBoxOther.Checked Then
                bottomHalf = bottomHalf + 1
            End If

            If radioBtnVeryGood.Checked Then
                bottomHalf = bottomHalf + 1
            End If

            If radioBtnExcellent.Checked Then
                bottomHalf = bottomHalf + 2
            End If

            If radioBtnOutstanding.Checked Then
                bottomHalf = bottomHalf + 3
            End If

            If checkBoxState.Checked Then
                bottomHalf = bottomHalf + 1
            End If

            If checkBoxRegional.Checked Then
                bottomHalf = bottomHalf + 2
            End If

            If checkBoxNational.Checked Then
                bottomHalf = bottomHalf + 5
            End If

            If radioBtnSocioeconomicDisadvantage.Checked Then
                bottomHalf = bottomHalf + 20
            End If

            If radioBtnMenInNursing.Checked Then
                bottomHalf = bottomHalf + 5
            End If

            If radioBtnScholarshipAthlete.Checked Then
                bottomHalf = bottomHalf + 20
            End If

            If radioBtnProvostsDiscretion.Checked Then
                bottomHalf = bottomHalf + 20
            End If

            If bottomHalf > 40 Then
                bottomHalf = 40
            End If

            totalScore = topHalf + bottomHalf

        End If

        'Displays the total score, and if the person is admitted or not.
        If totalScore >= 100 Then
            txtBoxScoreAndAdmission.Text = "Total Score: " & totalScore & vbCrLf & "" & vbCrLf & "Admitted"
        Else
            txtBoxScoreAndAdmission.Text = "Total Score: " & totalScore & vbCrLf & "" & vbCrLf & "Denied"
        End If

    End Sub
End Class