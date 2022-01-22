<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class universityAdmissionsPointSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblGPAScore = New System.Windows.Forms.Label()
        Me.txtBoxgpaTimes20 = New System.Windows.Forms.TextBox()
        Me.radioBtnSAT400to920 = New System.Windows.Forms.RadioButton()
        Me.radioBtnSAT930to1000 = New System.Windows.Forms.RadioButton()
        Me.radioBtnSAT1010to1190 = New System.Windows.Forms.RadioButton()
        Me.radioBtnSAT1200to1350 = New System.Windows.Forms.RadioButton()
        Me.radioBtnSAT1360to1600 = New System.Windows.Forms.RadioButton()
        Me.groupBoxSAT = New System.Windows.Forms.GroupBox()
        Me.groupBoxhighSchoolQuality = New System.Windows.Forms.GroupBox()
        Me.radioBtn5 = New System.Windows.Forms.RadioButton()
        Me.radioBtn4 = New System.Windows.Forms.RadioButton()
        Me.radioBtn2 = New System.Windows.Forms.RadioButton()
        Me.radioBtn1 = New System.Windows.Forms.RadioButton()
        Me.radioBtn3 = New System.Windows.Forms.RadioButton()
        Me.radioBtn0 = New System.Windows.Forms.RadioButton()
        Me.groupBoxdifficultyOfCurriculum = New System.Windows.Forms.GroupBox()
        Me.radioBtn48 = New System.Windows.Forms.RadioButton()
        Me.radioBtn36 = New System.Windows.Forms.RadioButton()
        Me.radioBtn24 = New System.Windows.Forms.RadioButton()
        Me.radioBtn00 = New System.Windows.Forms.RadioButton()
        Me.radioBtnNeg1Neg2 = New System.Windows.Forms.RadioButton()
        Me.radioBtn12 = New System.Windows.Forms.RadioButton()
        Me.radioBtnNeg2Neg4 = New System.Windows.Forms.RadioButton()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.btnCalcTotalScore = New System.Windows.Forms.Button()
        Me.txtBoxScoreAndAdmission = New System.Windows.Forms.TextBox()
        Me.groupBoxGeography = New System.Windows.Forms.GroupBox()
        Me.checkBoxUnderrepresented = New System.Windows.Forms.CheckBox()
        Me.checkBoxStateResident = New System.Windows.Forms.CheckBox()
        Me.groupBoxAlumni = New System.Windows.Forms.GroupBox()
        Me.checkBoxOther = New System.Windows.Forms.CheckBox()
        Me.checkBoxLegacy = New System.Windows.Forms.CheckBox()
        Me.groupBoxEssay = New System.Windows.Forms.GroupBox()
        Me.radioBtnOutstanding = New System.Windows.Forms.RadioButton()
        Me.radioBtnExcellent = New System.Windows.Forms.RadioButton()
        Me.radioBtnVeryGood = New System.Windows.Forms.RadioButton()
        Me.groupBoxLeadershipAndService = New System.Windows.Forms.GroupBox()
        Me.checkBoxNational = New System.Windows.Forms.CheckBox()
        Me.checkBoxRegional = New System.Windows.Forms.CheckBox()
        Me.checkBoxState = New System.Windows.Forms.CheckBox()
        Me.groupBoxMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.radioBtnProvostsDiscretion = New System.Windows.Forms.RadioButton()
        Me.radioBtnScholarshipAthlete = New System.Windows.Forms.RadioButton()
        Me.radioBtnMenInNursing = New System.Windows.Forms.RadioButton()
        Me.radioBtnSocioeconomicDisadvantage = New System.Windows.Forms.RadioButton()
        Me.lblMaxPoints = New System.Windows.Forms.Label()
        Me.txtBoxGPA = New System.Windows.Forms.TextBox()
        Me.groupBoxSAT.SuspendLayout()
        Me.groupBoxhighSchoolQuality.SuspendLayout()
        Me.groupBoxdifficultyOfCurriculum.SuspendLayout()
        Me.groupBoxGeography.SuspendLayout()
        Me.groupBoxAlumni.SuspendLayout()
        Me.groupBoxEssay.SuspendLayout()
        Me.groupBoxLeadershipAndService.SuspendLayout()
        Me.groupBoxMiscellaneous.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGPAScore
        '
        Me.lblGPAScore.AutoSize = True
        Me.lblGPAScore.Location = New System.Drawing.Point(255, 25)
        Me.lblGPAScore.Name = "lblGPAScore"
        Me.lblGPAScore.Size = New System.Drawing.Size(63, 13)
        Me.lblGPAScore.TabIndex = 0
        Me.lblGPAScore.Text = "GPA Score:"
        '
        'txtBoxgpaTimes20
        '
        Me.txtBoxgpaTimes20.Location = New System.Drawing.Point(392, 22)
        Me.txtBoxgpaTimes20.Name = "txtBoxgpaTimes20"
        Me.txtBoxgpaTimes20.ReadOnly = True
        Me.txtBoxgpaTimes20.Size = New System.Drawing.Size(56, 20)
        Me.txtBoxgpaTimes20.TabIndex = 2
        '
        'radioBtnSAT400to920
        '
        Me.radioBtnSAT400to920.AutoSize = True
        Me.radioBtnSAT400to920.Location = New System.Drawing.Point(6, 19)
        Me.radioBtnSAT400to920.Name = "radioBtnSAT400to920"
        Me.radioBtnSAT400to920.Size = New System.Drawing.Size(79, 17)
        Me.radioBtnSAT400to920.TabIndex = 3
        Me.radioBtnSAT400to920.TabStop = True
        Me.radioBtnSAT400to920.Text = "400-920 [0]"
        Me.radioBtnSAT400to920.UseVisualStyleBackColor = True
        '
        'radioBtnSAT930to1000
        '
        Me.radioBtnSAT930to1000.AutoSize = True
        Me.radioBtnSAT930to1000.Location = New System.Drawing.Point(6, 42)
        Me.radioBtnSAT930to1000.Name = "radioBtnSAT930to1000"
        Me.radioBtnSAT930to1000.Size = New System.Drawing.Size(85, 17)
        Me.radioBtnSAT930to1000.TabIndex = 4
        Me.radioBtnSAT930to1000.TabStop = True
        Me.radioBtnSAT930to1000.Text = "930-1000 [6]"
        Me.radioBtnSAT930to1000.UseVisualStyleBackColor = True
        '
        'radioBtnSAT1010to1190
        '
        Me.radioBtnSAT1010to1190.AutoSize = True
        Me.radioBtnSAT1010to1190.Location = New System.Drawing.Point(6, 65)
        Me.radioBtnSAT1010to1190.Name = "radioBtnSAT1010to1190"
        Me.radioBtnSAT1010to1190.Size = New System.Drawing.Size(97, 17)
        Me.radioBtnSAT1010to1190.TabIndex = 5
        Me.radioBtnSAT1010to1190.TabStop = True
        Me.radioBtnSAT1010to1190.Text = "1010-1190 [10]"
        Me.radioBtnSAT1010to1190.UseVisualStyleBackColor = True
        '
        'radioBtnSAT1200to1350
        '
        Me.radioBtnSAT1200to1350.AutoSize = True
        Me.radioBtnSAT1200to1350.Location = New System.Drawing.Point(6, 88)
        Me.radioBtnSAT1200to1350.Name = "radioBtnSAT1200to1350"
        Me.radioBtnSAT1200to1350.Size = New System.Drawing.Size(97, 17)
        Me.radioBtnSAT1200to1350.TabIndex = 6
        Me.radioBtnSAT1200to1350.TabStop = True
        Me.radioBtnSAT1200to1350.Text = "1200-1350 [11]"
        Me.radioBtnSAT1200to1350.UseVisualStyleBackColor = True
        '
        'radioBtnSAT1360to1600
        '
        Me.radioBtnSAT1360to1600.AutoSize = True
        Me.radioBtnSAT1360to1600.Location = New System.Drawing.Point(6, 111)
        Me.radioBtnSAT1360to1600.Name = "radioBtnSAT1360to1600"
        Me.radioBtnSAT1360to1600.Size = New System.Drawing.Size(97, 17)
        Me.radioBtnSAT1360to1600.TabIndex = 7
        Me.radioBtnSAT1360to1600.TabStop = True
        Me.radioBtnSAT1360to1600.Text = "1360-1600 [12]"
        Me.radioBtnSAT1360to1600.UseVisualStyleBackColor = True
        '
        'groupBoxSAT
        '
        Me.groupBoxSAT.Controls.Add(Me.radioBtnSAT1360to1600)
        Me.groupBoxSAT.Controls.Add(Me.radioBtnSAT1200to1350)
        Me.groupBoxSAT.Controls.Add(Me.radioBtnSAT1010to1190)
        Me.groupBoxSAT.Controls.Add(Me.radioBtnSAT930to1000)
        Me.groupBoxSAT.Controls.Add(Me.radioBtnSAT400to920)
        Me.groupBoxSAT.Location = New System.Drawing.Point(12, 74)
        Me.groupBoxSAT.Name = "groupBoxSAT"
        Me.groupBoxSAT.Size = New System.Drawing.Size(168, 136)
        Me.groupBoxSAT.TabIndex = 8
        Me.groupBoxSAT.TabStop = False
        Me.groupBoxSAT.Text = "SAT"
        '
        'groupBoxhighSchoolQuality
        '
        Me.groupBoxhighSchoolQuality.Controls.Add(Me.radioBtn5)
        Me.groupBoxhighSchoolQuality.Controls.Add(Me.radioBtn4)
        Me.groupBoxhighSchoolQuality.Controls.Add(Me.radioBtn2)
        Me.groupBoxhighSchoolQuality.Controls.Add(Me.radioBtn1)
        Me.groupBoxhighSchoolQuality.Controls.Add(Me.radioBtn3)
        Me.groupBoxhighSchoolQuality.Controls.Add(Me.radioBtn0)
        Me.groupBoxhighSchoolQuality.Location = New System.Drawing.Point(186, 74)
        Me.groupBoxhighSchoolQuality.Name = "groupBoxhighSchoolQuality"
        Me.groupBoxhighSchoolQuality.Size = New System.Drawing.Size(168, 136)
        Me.groupBoxhighSchoolQuality.TabIndex = 9
        Me.groupBoxhighSchoolQuality.TabStop = False
        Me.groupBoxhighSchoolQuality.Text = "High School Quality"
        '
        'radioBtn5
        '
        Me.radioBtn5.AutoSize = True
        Me.radioBtn5.Location = New System.Drawing.Point(86, 111)
        Me.radioBtn5.Name = "radioBtn5"
        Me.radioBtn5.Size = New System.Drawing.Size(52, 17)
        Me.radioBtn5.TabIndex = 13
        Me.radioBtn5.TabStop = True
        Me.radioBtn5.Text = "5 [10]"
        Me.radioBtn5.UseVisualStyleBackColor = True
        '
        'radioBtn4
        '
        Me.radioBtn4.AutoSize = True
        Me.radioBtn4.Location = New System.Drawing.Point(86, 65)
        Me.radioBtn4.Name = "radioBtn4"
        Me.radioBtn4.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn4.TabIndex = 12
        Me.radioBtn4.TabStop = True
        Me.radioBtn4.Text = "4 [8]"
        Me.radioBtn4.UseVisualStyleBackColor = True
        '
        'radioBtn2
        '
        Me.radioBtn2.AutoSize = True
        Me.radioBtn2.Location = New System.Drawing.Point(6, 111)
        Me.radioBtn2.Name = "radioBtn2"
        Me.radioBtn2.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn2.TabIndex = 11
        Me.radioBtn2.TabStop = True
        Me.radioBtn2.Text = "2 [4]"
        Me.radioBtn2.UseVisualStyleBackColor = True
        '
        'radioBtn1
        '
        Me.radioBtn1.AutoSize = True
        Me.radioBtn1.Location = New System.Drawing.Point(6, 65)
        Me.radioBtn1.Name = "radioBtn1"
        Me.radioBtn1.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn1.TabIndex = 10
        Me.radioBtn1.TabStop = True
        Me.radioBtn1.Text = "1 [2]"
        Me.radioBtn1.UseVisualStyleBackColor = True
        '
        'radioBtn3
        '
        Me.radioBtn3.AutoSize = True
        Me.radioBtn3.Location = New System.Drawing.Point(86, 19)
        Me.radioBtn3.Name = "radioBtn3"
        Me.radioBtn3.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn3.TabIndex = 9
        Me.radioBtn3.TabStop = True
        Me.radioBtn3.Text = "3 [6]"
        Me.radioBtn3.UseVisualStyleBackColor = True
        '
        'radioBtn0
        '
        Me.radioBtn0.AutoSize = True
        Me.radioBtn0.Location = New System.Drawing.Point(6, 19)
        Me.radioBtn0.Name = "radioBtn0"
        Me.radioBtn0.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn0.TabIndex = 8
        Me.radioBtn0.TabStop = True
        Me.radioBtn0.Text = "0 [0]"
        Me.radioBtn0.UseVisualStyleBackColor = True
        '
        'groupBoxdifficultyOfCurriculum
        '
        Me.groupBoxdifficultyOfCurriculum.Controls.Add(Me.radioBtn48)
        Me.groupBoxdifficultyOfCurriculum.Controls.Add(Me.radioBtn36)
        Me.groupBoxdifficultyOfCurriculum.Controls.Add(Me.radioBtn24)
        Me.groupBoxdifficultyOfCurriculum.Controls.Add(Me.radioBtn00)
        Me.groupBoxdifficultyOfCurriculum.Controls.Add(Me.radioBtnNeg1Neg2)
        Me.groupBoxdifficultyOfCurriculum.Controls.Add(Me.radioBtn12)
        Me.groupBoxdifficultyOfCurriculum.Controls.Add(Me.radioBtnNeg2Neg4)
        Me.groupBoxdifficultyOfCurriculum.Location = New System.Drawing.Point(360, 74)
        Me.groupBoxdifficultyOfCurriculum.Name = "groupBoxdifficultyOfCurriculum"
        Me.groupBoxdifficultyOfCurriculum.Size = New System.Drawing.Size(168, 136)
        Me.groupBoxdifficultyOfCurriculum.TabIndex = 14
        Me.groupBoxdifficultyOfCurriculum.TabStop = False
        Me.groupBoxdifficultyOfCurriculum.Text = "Difficulty of Curriculum"
        '
        'radioBtn48
        '
        Me.radioBtn48.AutoSize = True
        Me.radioBtn48.Location = New System.Drawing.Point(87, 42)
        Me.radioBtn48.Name = "radioBtn48"
        Me.radioBtn48.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn48.TabIndex = 14
        Me.radioBtn48.TabStop = True
        Me.radioBtn48.Text = "4 [8]"
        Me.radioBtn48.UseVisualStyleBackColor = True
        '
        'radioBtn36
        '
        Me.radioBtn36.AutoSize = True
        Me.radioBtn36.Location = New System.Drawing.Point(87, 19)
        Me.radioBtn36.Name = "radioBtn36"
        Me.radioBtn36.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn36.TabIndex = 13
        Me.radioBtn36.TabStop = True
        Me.radioBtn36.Text = "3 [6]"
        Me.radioBtn36.UseVisualStyleBackColor = True
        '
        'radioBtn24
        '
        Me.radioBtn24.AutoSize = True
        Me.radioBtn24.Location = New System.Drawing.Point(6, 111)
        Me.radioBtn24.Name = "radioBtn24"
        Me.radioBtn24.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn24.TabIndex = 12
        Me.radioBtn24.TabStop = True
        Me.radioBtn24.Text = "2 [4]"
        Me.radioBtn24.UseVisualStyleBackColor = True
        '
        'radioBtn00
        '
        Me.radioBtn00.AutoSize = True
        Me.radioBtn00.Location = New System.Drawing.Point(6, 65)
        Me.radioBtn00.Name = "radioBtn00"
        Me.radioBtn00.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn00.TabIndex = 11
        Me.radioBtn00.TabStop = True
        Me.radioBtn00.Text = "0 [0]"
        Me.radioBtn00.UseVisualStyleBackColor = True
        '
        'radioBtnNeg1Neg2
        '
        Me.radioBtnNeg1Neg2.AutoSize = True
        Me.radioBtnNeg1Neg2.Location = New System.Drawing.Point(6, 42)
        Me.radioBtnNeg1Neg2.Name = "radioBtnNeg1Neg2"
        Me.radioBtnNeg1Neg2.Size = New System.Drawing.Size(52, 17)
        Me.radioBtnNeg1Neg2.TabIndex = 10
        Me.radioBtnNeg1Neg2.TabStop = True
        Me.radioBtnNeg1Neg2.Text = "-1 [-2]"
        Me.radioBtnNeg1Neg2.UseVisualStyleBackColor = True
        '
        'radioBtn12
        '
        Me.radioBtn12.AutoSize = True
        Me.radioBtn12.Location = New System.Drawing.Point(6, 88)
        Me.radioBtn12.Name = "radioBtn12"
        Me.radioBtn12.Size = New System.Drawing.Size(46, 17)
        Me.radioBtn12.TabIndex = 9
        Me.radioBtn12.TabStop = True
        Me.radioBtn12.Text = "1 [2]"
        Me.radioBtn12.UseVisualStyleBackColor = True
        '
        'radioBtnNeg2Neg4
        '
        Me.radioBtnNeg2Neg4.AutoSize = True
        Me.radioBtnNeg2Neg4.Location = New System.Drawing.Point(6, 19)
        Me.radioBtnNeg2Neg4.Name = "radioBtnNeg2Neg4"
        Me.radioBtnNeg2Neg4.Size = New System.Drawing.Size(52, 17)
        Me.radioBtnNeg2Neg4.TabIndex = 8
        Me.radioBtnNeg2Neg4.TabStop = True
        Me.radioBtnNeg2Neg4.Text = "-2 [-4]"
        Me.radioBtnNeg2Neg4.UseVisualStyleBackColor = True
        '
        'lblDivider
        '
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(12, 213)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(776, 2)
        Me.lblDivider.TabIndex = 15
        '
        'btnCalcTotalScore
        '
        Me.btnCalcTotalScore.Location = New System.Drawing.Point(546, 29)
        Me.btnCalcTotalScore.Name = "btnCalcTotalScore"
        Me.btnCalcTotalScore.Size = New System.Drawing.Size(218, 36)
        Me.btnCalcTotalScore.TabIndex = 16
        Me.btnCalcTotalScore.Text = "Calculate Total Score"
        Me.btnCalcTotalScore.UseVisualStyleBackColor = True
        '
        'txtBoxScoreAndAdmission
        '
        Me.txtBoxScoreAndAdmission.Location = New System.Drawing.Point(546, 92)
        Me.txtBoxScoreAndAdmission.Multiline = True
        Me.txtBoxScoreAndAdmission.Name = "txtBoxScoreAndAdmission"
        Me.txtBoxScoreAndAdmission.Size = New System.Drawing.Size(217, 63)
        Me.txtBoxScoreAndAdmission.TabIndex = 17
        '
        'groupBoxGeography
        '
        Me.groupBoxGeography.Controls.Add(Me.checkBoxUnderrepresented)
        Me.groupBoxGeography.Controls.Add(Me.checkBoxStateResident)
        Me.groupBoxGeography.Location = New System.Drawing.Point(12, 261)
        Me.groupBoxGeography.Name = "groupBoxGeography"
        Me.groupBoxGeography.Size = New System.Drawing.Size(197, 97)
        Me.groupBoxGeography.TabIndex = 9
        Me.groupBoxGeography.TabStop = False
        Me.groupBoxGeography.Text = "Geography"
        '
        'checkBoxUnderrepresented
        '
        Me.checkBoxUnderrepresented.AutoSize = True
        Me.checkBoxUnderrepresented.Location = New System.Drawing.Point(6, 42)
        Me.checkBoxUnderrepresented.Name = "checkBoxUnderrepresented"
        Me.checkBoxUnderrepresented.Size = New System.Drawing.Size(126, 17)
        Me.checkBoxUnderrepresented.TabIndex = 1
        Me.checkBoxUnderrepresented.Text = "Underrepresented [0]"
        Me.checkBoxUnderrepresented.UseVisualStyleBackColor = True
        '
        'checkBoxStateResident
        '
        Me.checkBoxStateResident.AutoSize = True
        Me.checkBoxStateResident.Location = New System.Drawing.Point(6, 19)
        Me.checkBoxStateResident.Name = "checkBoxStateResident"
        Me.checkBoxStateResident.Size = New System.Drawing.Size(117, 17)
        Me.checkBoxStateResident.TabIndex = 0
        Me.checkBoxStateResident.Text = "State Resident [10]"
        Me.checkBoxStateResident.UseVisualStyleBackColor = True
        '
        'groupBoxAlumni
        '
        Me.groupBoxAlumni.Controls.Add(Me.checkBoxOther)
        Me.groupBoxAlumni.Controls.Add(Me.checkBoxLegacy)
        Me.groupBoxAlumni.Location = New System.Drawing.Point(12, 364)
        Me.groupBoxAlumni.Name = "groupBoxAlumni"
        Me.groupBoxAlumni.Size = New System.Drawing.Size(197, 97)
        Me.groupBoxAlumni.TabIndex = 10
        Me.groupBoxAlumni.TabStop = False
        Me.groupBoxAlumni.Text = "Alumni"
        '
        'checkBoxOther
        '
        Me.checkBoxOther.AutoSize = True
        Me.checkBoxOther.Location = New System.Drawing.Point(6, 42)
        Me.checkBoxOther.Name = "checkBoxOther"
        Me.checkBoxOther.Size = New System.Drawing.Size(178, 17)
        Me.checkBoxOther.TabIndex = 1
        Me.checkBoxOther.Text = "Other (grandparents, siblings) [1]"
        Me.checkBoxOther.UseVisualStyleBackColor = True
        '
        'checkBoxLegacy
        '
        Me.checkBoxLegacy.AutoSize = True
        Me.checkBoxLegacy.Location = New System.Drawing.Point(6, 19)
        Me.checkBoxLegacy.Name = "checkBoxLegacy"
        Me.checkBoxLegacy.Size = New System.Drawing.Size(181, 17)
        Me.checkBoxLegacy.TabIndex = 0
        Me.checkBoxLegacy.Text = "Legacy (parents, stepparents) [4]"
        Me.checkBoxLegacy.UseVisualStyleBackColor = True
        '
        'groupBoxEssay
        '
        Me.groupBoxEssay.Controls.Add(Me.radioBtnOutstanding)
        Me.groupBoxEssay.Controls.Add(Me.radioBtnExcellent)
        Me.groupBoxEssay.Controls.Add(Me.radioBtnVeryGood)
        Me.groupBoxEssay.Location = New System.Drawing.Point(272, 261)
        Me.groupBoxEssay.Name = "groupBoxEssay"
        Me.groupBoxEssay.Size = New System.Drawing.Size(200, 97)
        Me.groupBoxEssay.TabIndex = 10
        Me.groupBoxEssay.TabStop = False
        Me.groupBoxEssay.Text = "Essay"
        '
        'radioBtnOutstanding
        '
        Me.radioBtnOutstanding.AutoSize = True
        Me.radioBtnOutstanding.Location = New System.Drawing.Point(6, 65)
        Me.radioBtnOutstanding.Name = "radioBtnOutstanding"
        Me.radioBtnOutstanding.Size = New System.Drawing.Size(97, 17)
        Me.radioBtnOutstanding.TabIndex = 10
        Me.radioBtnOutstanding.TabStop = True
        Me.radioBtnOutstanding.Text = "Outstanding [3]"
        Me.radioBtnOutstanding.UseVisualStyleBackColor = True
        '
        'radioBtnExcellent
        '
        Me.radioBtnExcellent.AutoSize = True
        Me.radioBtnExcellent.Location = New System.Drawing.Point(6, 42)
        Me.radioBtnExcellent.Name = "radioBtnExcellent"
        Me.radioBtnExcellent.Size = New System.Drawing.Size(83, 17)
        Me.radioBtnExcellent.TabIndex = 9
        Me.radioBtnExcellent.TabStop = True
        Me.radioBtnExcellent.Text = "Excellent [2]"
        Me.radioBtnExcellent.UseVisualStyleBackColor = True
        '
        'radioBtnVeryGood
        '
        Me.radioBtnVeryGood.AutoSize = True
        Me.radioBtnVeryGood.Location = New System.Drawing.Point(6, 19)
        Me.radioBtnVeryGood.Name = "radioBtnVeryGood"
        Me.radioBtnVeryGood.Size = New System.Drawing.Size(90, 17)
        Me.radioBtnVeryGood.TabIndex = 8
        Me.radioBtnVeryGood.TabStop = True
        Me.radioBtnVeryGood.Text = "Very Good [1]"
        Me.radioBtnVeryGood.UseVisualStyleBackColor = True
        '
        'groupBoxLeadershipAndService
        '
        Me.groupBoxLeadershipAndService.Controls.Add(Me.checkBoxNational)
        Me.groupBoxLeadershipAndService.Controls.Add(Me.checkBoxRegional)
        Me.groupBoxLeadershipAndService.Controls.Add(Me.checkBoxState)
        Me.groupBoxLeadershipAndService.Location = New System.Drawing.Point(272, 364)
        Me.groupBoxLeadershipAndService.Name = "groupBoxLeadershipAndService"
        Me.groupBoxLeadershipAndService.Size = New System.Drawing.Size(200, 97)
        Me.groupBoxLeadershipAndService.TabIndex = 10
        Me.groupBoxLeadershipAndService.TabStop = False
        Me.groupBoxLeadershipAndService.Text = "Leadership and Service"
        '
        'checkBoxNational
        '
        Me.checkBoxNational.AutoSize = True
        Me.checkBoxNational.Location = New System.Drawing.Point(6, 65)
        Me.checkBoxNational.Name = "checkBoxNational"
        Me.checkBoxNational.Size = New System.Drawing.Size(80, 17)
        Me.checkBoxNational.TabIndex = 2
        Me.checkBoxNational.Text = "National [5]"
        Me.checkBoxNational.UseVisualStyleBackColor = True
        '
        'checkBoxRegional
        '
        Me.checkBoxRegional.AutoSize = True
        Me.checkBoxRegional.Location = New System.Drawing.Point(6, 42)
        Me.checkBoxRegional.Name = "checkBoxRegional"
        Me.checkBoxRegional.Size = New System.Drawing.Size(83, 17)
        Me.checkBoxRegional.TabIndex = 1
        Me.checkBoxRegional.Text = "Regional [2]"
        Me.checkBoxRegional.UseVisualStyleBackColor = True
        '
        'checkBoxState
        '
        Me.checkBoxState.AutoSize = True
        Me.checkBoxState.Location = New System.Drawing.Point(6, 19)
        Me.checkBoxState.Name = "checkBoxState"
        Me.checkBoxState.Size = New System.Drawing.Size(66, 17)
        Me.checkBoxState.TabIndex = 0
        Me.checkBoxState.Text = "State [1]"
        Me.checkBoxState.UseVisualStyleBackColor = True
        '
        'groupBoxMiscellaneous
        '
        Me.groupBoxMiscellaneous.Controls.Add(Me.radioBtnProvostsDiscretion)
        Me.groupBoxMiscellaneous.Controls.Add(Me.radioBtnScholarshipAthlete)
        Me.groupBoxMiscellaneous.Controls.Add(Me.radioBtnMenInNursing)
        Me.groupBoxMiscellaneous.Controls.Add(Me.radioBtnSocioeconomicDisadvantage)
        Me.groupBoxMiscellaneous.Location = New System.Drawing.Point(514, 261)
        Me.groupBoxMiscellaneous.Name = "groupBoxMiscellaneous"
        Me.groupBoxMiscellaneous.Size = New System.Drawing.Size(247, 200)
        Me.groupBoxMiscellaneous.TabIndex = 11
        Me.groupBoxMiscellaneous.TabStop = False
        Me.groupBoxMiscellaneous.Text = "Miscellaneous"
        '
        'radioBtnProvostsDiscretion
        '
        Me.radioBtnProvostsDiscretion.AutoSize = True
        Me.radioBtnProvostsDiscretion.Location = New System.Drawing.Point(6, 164)
        Me.radioBtnProvostsDiscretion.Name = "radioBtnProvostsDiscretion"
        Me.radioBtnProvostsDiscretion.Size = New System.Drawing.Size(137, 17)
        Me.radioBtnProvostsDiscretion.TabIndex = 11
        Me.radioBtnProvostsDiscretion.TabStop = True
        Me.radioBtnProvostsDiscretion.Text = "Provost's discretion [20]"
        Me.radioBtnProvostsDiscretion.UseVisualStyleBackColor = True
        '
        'radioBtnScholarshipAthlete
        '
        Me.radioBtnScholarshipAthlete.AutoSize = True
        Me.radioBtnScholarshipAthlete.Location = New System.Drawing.Point(6, 112)
        Me.radioBtnScholarshipAthlete.Name = "radioBtnScholarshipAthlete"
        Me.radioBtnScholarshipAthlete.Size = New System.Drawing.Size(136, 17)
        Me.radioBtnScholarshipAthlete.TabIndex = 10
        Me.radioBtnScholarshipAthlete.TabStop = True
        Me.radioBtnScholarshipAthlete.Text = "Scholarship athlete [20]"
        Me.radioBtnScholarshipAthlete.UseVisualStyleBackColor = True
        '
        'radioBtnMenInNursing
        '
        Me.radioBtnMenInNursing.AutoSize = True
        Me.radioBtnMenInNursing.Location = New System.Drawing.Point(6, 65)
        Me.radioBtnMenInNursing.Name = "radioBtnMenInNursing"
        Me.radioBtnMenInNursing.Size = New System.Drawing.Size(109, 17)
        Me.radioBtnMenInNursing.TabIndex = 9
        Me.radioBtnMenInNursing.TabStop = True
        Me.radioBtnMenInNursing.Text = "Men in nursing [5]"
        Me.radioBtnMenInNursing.UseVisualStyleBackColor = True
        '
        'radioBtnSocioeconomicDisadvantage
        '
        Me.radioBtnSocioeconomicDisadvantage.AutoSize = True
        Me.radioBtnSocioeconomicDisadvantage.Location = New System.Drawing.Point(6, 19)
        Me.radioBtnSocioeconomicDisadvantage.Name = "radioBtnSocioeconomicDisadvantage"
        Me.radioBtnSocioeconomicDisadvantage.Size = New System.Drawing.Size(186, 17)
        Me.radioBtnSocioeconomicDisadvantage.TabIndex = 8
        Me.radioBtnSocioeconomicDisadvantage.TabStop = True
        Me.radioBtnSocioeconomicDisadvantage.Text = "Socioeconomic disadvantage [20]"
        Me.radioBtnSocioeconomicDisadvantage.UseVisualStyleBackColor = True
        '
        'lblMaxPoints
        '
        Me.lblMaxPoints.AutoSize = True
        Me.lblMaxPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxPoints.Location = New System.Drawing.Point(309, 232)
        Me.lblMaxPoints.Name = "lblMaxPoints"
        Me.lblMaxPoints.Size = New System.Drawing.Size(109, 13)
        Me.lblMaxPoints.TabIndex = 18
        Me.lblMaxPoints.Text = "Maximum of 40 points"
        '
        'txtBoxGPA
        '
        Me.txtBoxGPA.Location = New System.Drawing.Point(324, 22)
        Me.txtBoxGPA.Name = "txtBoxGPA"
        Me.txtBoxGPA.Size = New System.Drawing.Size(56, 20)
        Me.txtBoxGPA.TabIndex = 19
        '
        'universityAdmissionsPointSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 474)
        Me.Controls.Add(Me.txtBoxGPA)
        Me.Controls.Add(Me.lblMaxPoints)
        Me.Controls.Add(Me.groupBoxMiscellaneous)
        Me.Controls.Add(Me.groupBoxLeadershipAndService)
        Me.Controls.Add(Me.groupBoxEssay)
        Me.Controls.Add(Me.groupBoxAlumni)
        Me.Controls.Add(Me.groupBoxGeography)
        Me.Controls.Add(Me.txtBoxScoreAndAdmission)
        Me.Controls.Add(Me.btnCalcTotalScore)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.groupBoxdifficultyOfCurriculum)
        Me.Controls.Add(Me.groupBoxhighSchoolQuality)
        Me.Controls.Add(Me.groupBoxSAT)
        Me.Controls.Add(Me.txtBoxgpaTimes20)
        Me.Controls.Add(Me.lblGPAScore)
        Me.Name = "universityAdmissionsPointSystem"
        Me.Text = "University Admissions Point System"
        Me.groupBoxSAT.ResumeLayout(false)
        Me.groupBoxSAT.PerformLayout
        Me.groupBoxhighSchoolQuality.ResumeLayout(false)
        Me.groupBoxhighSchoolQuality.PerformLayout
        Me.groupBoxdifficultyOfCurriculum.ResumeLayout(false)
        Me.groupBoxdifficultyOfCurriculum.PerformLayout
        Me.groupBoxGeography.ResumeLayout(false)
        Me.groupBoxGeography.PerformLayout
        Me.groupBoxAlumni.ResumeLayout(false)
        Me.groupBoxAlumni.PerformLayout
        Me.groupBoxEssay.ResumeLayout(false)
        Me.groupBoxEssay.PerformLayout
        Me.groupBoxLeadershipAndService.ResumeLayout(false)
        Me.groupBoxLeadershipAndService.PerformLayout
        Me.groupBoxMiscellaneous.ResumeLayout(false)
        Me.groupBoxMiscellaneous.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents lblGPAScore As Label
    Friend WithEvents txtBoxgpaTimes20 As TextBox
    Friend WithEvents radioBtnSAT400to920 As RadioButton
    Friend WithEvents radioBtnSAT930to1000 As RadioButton
    Friend WithEvents radioBtnSAT1010to1190 As RadioButton
    Friend WithEvents radioBtnSAT1200to1350 As RadioButton
    Friend WithEvents radioBtnSAT1360to1600 As RadioButton
    Friend WithEvents groupBoxSAT As GroupBox
    Friend WithEvents groupBoxhighSchoolQuality As GroupBox
    Friend WithEvents radioBtn5 As RadioButton
    Friend WithEvents radioBtn4 As RadioButton
    Friend WithEvents radioBtn2 As RadioButton
    Friend WithEvents radioBtn1 As RadioButton
    Friend WithEvents radioBtn3 As RadioButton
    Friend WithEvents radioBtn0 As RadioButton
    Friend WithEvents groupBoxdifficultyOfCurriculum As GroupBox
    Friend WithEvents radioBtn36 As RadioButton
    Friend WithEvents radioBtn24 As RadioButton
    Friend WithEvents radioBtn00 As RadioButton
    Friend WithEvents radioBtnNeg1Neg2 As RadioButton
    Friend WithEvents radioBtn12 As RadioButton
    Friend WithEvents radioBtnNeg2Neg4 As RadioButton
    Friend WithEvents radioBtn48 As RadioButton
    Friend WithEvents lblDivider As Label
    Friend WithEvents btnCalcTotalScore As Button
    Friend WithEvents txtBoxScoreAndAdmission As TextBox
    Friend WithEvents groupBoxGeography As GroupBox
    Friend WithEvents checkBoxUnderrepresented As CheckBox
    Friend WithEvents checkBoxStateResident As CheckBox
    Friend WithEvents groupBoxAlumni As GroupBox
    Friend WithEvents checkBoxOther As CheckBox
    Friend WithEvents checkBoxLegacy As CheckBox
    Friend WithEvents groupBoxEssay As GroupBox
    Friend WithEvents radioBtnOutstanding As RadioButton
    Friend WithEvents radioBtnExcellent As RadioButton
    Friend WithEvents radioBtnVeryGood As RadioButton
    Friend WithEvents groupBoxLeadershipAndService As GroupBox
    Friend WithEvents checkBoxNational As CheckBox
    Friend WithEvents checkBoxRegional As CheckBox
    Friend WithEvents checkBoxState As CheckBox
    Friend WithEvents groupBoxMiscellaneous As GroupBox
    Friend WithEvents radioBtnScholarshipAthlete As RadioButton
    Friend WithEvents radioBtnMenInNursing As RadioButton
    Friend WithEvents radioBtnSocioeconomicDisadvantage As RadioButton
    Friend WithEvents radioBtnProvostsDiscretion As RadioButton
    Friend WithEvents lblMaxPoints As Label
    Friend WithEvents txtBoxGPA As TextBox
End Class
