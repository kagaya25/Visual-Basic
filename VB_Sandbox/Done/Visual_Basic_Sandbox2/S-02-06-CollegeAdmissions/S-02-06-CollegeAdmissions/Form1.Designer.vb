﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollegeAdmissions
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollegeAdmissions))
    Me.Label3 = New System.Windows.Forms.Label()
    Me.grpAlumni = New System.Windows.Forms.GroupBox()
    Me.chkAlumni1 = New System.Windows.Forms.CheckBox()
    Me.chkAlumni4 = New System.Windows.Forms.CheckBox()
    Me.grpEssay = New System.Windows.Forms.GroupBox()
    Me.radEssay3 = New System.Windows.Forms.RadioButton()
    Me.radEssay2 = New System.Windows.Forms.RadioButton()
    Me.radEssay1 = New System.Windows.Forms.RadioButton()
    Me.grpLeadership = New System.Windows.Forms.GroupBox()
    Me.chkLeadership5 = New System.Windows.Forms.CheckBox()
    Me.chkLeadership2 = New System.Windows.Forms.CheckBox()
    Me.chkLeadership1 = New System.Windows.Forms.CheckBox()
    Me.grpMisc = New System.Windows.Forms.GroupBox()
    Me.radMiscProvot20 = New System.Windows.Forms.RadioButton()
    Me.radMiscAthlete20 = New System.Windows.Forms.RadioButton()
    Me.radMisc5 = New System.Windows.Forms.RadioButton()
    Me.radMiscSocio20 = New System.Windows.Forms.RadioButton()
    Me.grpGeography = New System.Windows.Forms.GroupBox()
    Me.chkGeography2 = New System.Windows.Forms.CheckBox()
    Me.chkGeography6 = New System.Windows.Forms.CheckBox()
    Me.chkGeography10 = New System.Windows.Forms.CheckBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.grpHighSchool = New System.Windows.Forms.GroupBox()
    Me.radSchool10 = New System.Windows.Forms.RadioButton()
    Me.radSchool8 = New System.Windows.Forms.RadioButton()
    Me.radSchool6 = New System.Windows.Forms.RadioButton()
    Me.radSchool4 = New System.Windows.Forms.RadioButton()
    Me.radSchool2 = New System.Windows.Forms.RadioButton()
    Me.radSchool0 = New System.Windows.Forms.RadioButton()
    Me.grpCurriculum = New System.Windows.Forms.GroupBox()
    Me.radCurriculum8 = New System.Windows.Forms.RadioButton()
    Me.radCurriculum6 = New System.Windows.Forms.RadioButton()
    Me.radCurriculum4 = New System.Windows.Forms.RadioButton()
    Me.radCurriculum2 = New System.Windows.Forms.RadioButton()
    Me.radCurriculum0 = New System.Windows.Forms.RadioButton()
    Me.radCurriculumNegative2 = New System.Windows.Forms.RadioButton()
    Me.radCurriculumNegative4 = New System.Windows.Forms.RadioButton()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.txtGPAPoints = New System.Windows.Forms.TextBox()
    Me.txtGPAScore = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.radSat0 = New System.Windows.Forms.RadioButton()
    Me.radSat6 = New System.Windows.Forms.RadioButton()
    Me.radSat10 = New System.Windows.Forms.RadioButton()
    Me.radSat11 = New System.Windows.Forms.RadioButton()
    Me.radSat12 = New System.Windows.Forms.RadioButton()
    Me.grpSAT = New System.Windows.Forms.GroupBox()
    Me.grpAlumni.SuspendLayout
    Me.grpEssay.SuspendLayout
    Me.grpLeadership.SuspendLayout
    Me.grpMisc.SuspendLayout
    Me.grpGeography.SuspendLayout
    Me.grpHighSchool.SuspendLayout
    Me.grpCurriculum.SuspendLayout
    Me.grpSAT.SuspendLayout
    Me.SuspendLayout
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.Label3.Location = New System.Drawing.Point(266, 237)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(129, 13)
    Me.Label3.TabIndex = 23
    Me.Label3.Text = "Maximum of 40 points"
    '
    'grpAlumni
    '
    Me.grpAlumni.Controls.Add(Me.chkAlumni1)
    Me.grpAlumni.Controls.Add(Me.chkAlumni4)
    Me.grpAlumni.Location = New System.Drawing.Point(20, 375)
    Me.grpAlumni.Name = "grpAlumni"
    Me.grpAlumni.Size = New System.Drawing.Size(200, 100)
    Me.grpAlumni.TabIndex = 9
    Me.grpAlumni.TabStop = false
    Me.grpAlumni.Text = "Alumni"
    '
    'chkAlumni1
    '
    Me.chkAlumni1.AutoSize = true
    Me.chkAlumni1.Location = New System.Drawing.Point(6, 66)
    Me.chkAlumni1.Name = "chkAlumni1"
    Me.chkAlumni1.Size = New System.Drawing.Size(178, 17)
    Me.chkAlumni1.TabIndex = 1
    Me.chkAlumni1.Tag = "1"
    Me.chkAlumni1.Text = "Other (grandparents, siblings) [1]"
    Me.chkAlumni1.UseVisualStyleBackColor = true
    '
    'chkAlumni4
    '
    Me.chkAlumni4.AutoSize = true
    Me.chkAlumni4.Location = New System.Drawing.Point(6, 30)
    Me.chkAlumni4.Name = "chkAlumni4"
    Me.chkAlumni4.Size = New System.Drawing.Size(181, 17)
    Me.chkAlumni4.TabIndex = 0
    Me.chkAlumni4.Tag = "4"
    Me.chkAlumni4.Text = "Legacy (parents, stepparents) [4]"
    Me.chkAlumni4.UseVisualStyleBackColor = true
    '
    'grpEssay
    '
    Me.grpEssay.Controls.Add(Me.radEssay3)
    Me.grpEssay.Controls.Add(Me.radEssay2)
    Me.grpEssay.Controls.Add(Me.radEssay1)
    Me.grpEssay.Location = New System.Drawing.Point(251, 264)
    Me.grpEssay.Name = "grpEssay"
    Me.grpEssay.Size = New System.Drawing.Size(144, 100)
    Me.grpEssay.TabIndex = 10
    Me.grpEssay.TabStop = false
    Me.grpEssay.Tag = "2"
    Me.grpEssay.Text = "Essay"
    '
    'radEssay3
    '
    Me.radEssay3.AutoSize = true
    Me.radEssay3.Location = New System.Drawing.Point(11, 66)
    Me.radEssay3.Name = "radEssay3"
    Me.radEssay3.Size = New System.Drawing.Size(97, 17)
    Me.radEssay3.TabIndex = 2
    Me.radEssay3.TabStop = true
    Me.radEssay3.Tag = "3"
    Me.radEssay3.Text = "Outstanding [3]"
    Me.radEssay3.UseVisualStyleBackColor = true
    '
    'radEssay2
    '
    Me.radEssay2.AutoSize = true
    Me.radEssay2.Location = New System.Drawing.Point(11, 41)
    Me.radEssay2.Name = "radEssay2"
    Me.radEssay2.Size = New System.Drawing.Size(83, 17)
    Me.radEssay2.TabIndex = 1
    Me.radEssay2.TabStop = true
    Me.radEssay2.Tag = "2"
    Me.radEssay2.Text = "Excellent [2]"
    Me.radEssay2.UseVisualStyleBackColor = true
    '
    'radEssay1
    '
    Me.radEssay1.AutoSize = true
    Me.radEssay1.Location = New System.Drawing.Point(11, 16)
    Me.radEssay1.Name = "radEssay1"
    Me.radEssay1.Size = New System.Drawing.Size(90, 17)
    Me.radEssay1.TabIndex = 0
    Me.radEssay1.TabStop = true
    Me.radEssay1.Tag = "1"
    Me.radEssay1.Text = "Very Good [1]"
    Me.radEssay1.UseVisualStyleBackColor = true
    '
    'grpLeadership
    '
    Me.grpLeadership.Controls.Add(Me.chkLeadership5)
    Me.grpLeadership.Controls.Add(Me.chkLeadership2)
    Me.grpLeadership.Controls.Add(Me.chkLeadership1)
    Me.grpLeadership.Location = New System.Drawing.Point(251, 375)
    Me.grpLeadership.Name = "grpLeadership"
    Me.grpLeadership.Size = New System.Drawing.Size(144, 100)
    Me.grpLeadership.TabIndex = 11
    Me.grpLeadership.TabStop = false
    Me.grpLeadership.Text = "Leadership and Service"
    '
    'chkLeadership5
    '
    Me.chkLeadership5.AutoSize = true
    Me.chkLeadership5.Location = New System.Drawing.Point(6, 67)
    Me.chkLeadership5.Name = "chkLeadership5"
    Me.chkLeadership5.Size = New System.Drawing.Size(80, 17)
    Me.chkLeadership5.TabIndex = 2
    Me.chkLeadership5.Tag = "5"
    Me.chkLeadership5.Text = "National [5]"
    Me.chkLeadership5.UseVisualStyleBackColor = true
    '
    'chkLeadership2
    '
    Me.chkLeadership2.AutoSize = true
    Me.chkLeadership2.Location = New System.Drawing.Point(6, 43)
    Me.chkLeadership2.Name = "chkLeadership2"
    Me.chkLeadership2.Size = New System.Drawing.Size(83, 17)
    Me.chkLeadership2.TabIndex = 1
    Me.chkLeadership2.Tag = "2"
    Me.chkLeadership2.Text = "Regional [2]"
    Me.chkLeadership2.UseVisualStyleBackColor = true
    '
    'chkLeadership1
    '
    Me.chkLeadership1.AutoSize = true
    Me.chkLeadership1.Location = New System.Drawing.Point(6, 19)
    Me.chkLeadership1.Name = "chkLeadership1"
    Me.chkLeadership1.Size = New System.Drawing.Size(66, 17)
    Me.chkLeadership1.TabIndex = 0
    Me.chkLeadership1.Tag = "1"
    Me.chkLeadership1.Text = "State [1]"
    Me.chkLeadership1.UseVisualStyleBackColor = true
    '
    'grpMisc
    '
    Me.grpMisc.Controls.Add(Me.radMiscProvot20)
    Me.grpMisc.Controls.Add(Me.radMiscAthlete20)
    Me.grpMisc.Controls.Add(Me.radMisc5)
    Me.grpMisc.Controls.Add(Me.radMiscSocio20)
    Me.grpMisc.Location = New System.Drawing.Point(432, 264)
    Me.grpMisc.Name = "grpMisc"
    Me.grpMisc.Size = New System.Drawing.Size(205, 211)
    Me.grpMisc.TabIndex = 12
    Me.grpMisc.TabStop = false
    Me.grpMisc.Text = "Miscellaneous"
    '
    'radMiscProvot20
    '
    Me.radMiscProvot20.AutoSize = true
    Me.radMiscProvot20.Location = New System.Drawing.Point(11, 174)
    Me.radMiscProvot20.Name = "radMiscProvot20"
    Me.radMiscProvot20.Size = New System.Drawing.Size(132, 17)
    Me.radMiscProvot20.TabIndex = 3
    Me.radMiscProvot20.TabStop = true
    Me.radMiscProvot20.Tag = "20"
    Me.radMiscProvot20.Text = "Provot's discretion [20]"
    Me.radMiscProvot20.UseVisualStyleBackColor = true
    '
    'radMiscAthlete20
    '
    Me.radMiscAthlete20.AutoSize = true
    Me.radMiscAthlete20.Location = New System.Drawing.Point(11, 129)
    Me.radMiscAthlete20.Name = "radMiscAthlete20"
    Me.radMiscAthlete20.Size = New System.Drawing.Size(137, 17)
    Me.radMiscAthlete20.TabIndex = 2
    Me.radMiscAthlete20.TabStop = true
    Me.radMiscAthlete20.Tag = "20"
    Me.radMiscAthlete20.Text = "Scholarship Athlete [20]"
    Me.radMiscAthlete20.UseVisualStyleBackColor = true
    '
    'radMisc5
    '
    Me.radMisc5.AutoSize = true
    Me.radMisc5.Location = New System.Drawing.Point(11, 84)
    Me.radMisc5.Name = "radMisc5"
    Me.radMisc5.Size = New System.Drawing.Size(111, 17)
    Me.radMisc5.TabIndex = 1
    Me.radMisc5.TabStop = true
    Me.radMisc5.Tag = "5"
    Me.radMisc5.Text = "Men in Nursing [5]"
    Me.radMisc5.UseVisualStyleBackColor = true
    '
    'radMiscSocio20
    '
    Me.radMiscSocio20.AutoSize = true
    Me.radMiscSocio20.Location = New System.Drawing.Point(11, 39)
    Me.radMiscSocio20.Name = "radMiscSocio20"
    Me.radMiscSocio20.Size = New System.Drawing.Size(188, 17)
    Me.radMiscSocio20.TabIndex = 0
    Me.radMiscSocio20.TabStop = true
    Me.radMiscSocio20.Tag = "20"
    Me.radMiscSocio20.Text = "Socioeconomic Disadvantage [20]"
    Me.radMiscSocio20.UseVisualStyleBackColor = true
    '
    'grpGeography
    '
    Me.grpGeography.Controls.Add(Me.chkGeography2)
    Me.grpGeography.Controls.Add(Me.chkGeography6)
    Me.grpGeography.Controls.Add(Me.chkGeography10)
    Me.grpGeography.Location = New System.Drawing.Point(20, 264)
    Me.grpGeography.Name = "grpGeography"
    Me.grpGeography.Size = New System.Drawing.Size(200, 100)
    Me.grpGeography.TabIndex = 22
    Me.grpGeography.TabStop = false
    Me.grpGeography.Text = "Geography"
    '
    'chkGeography2
    '
    Me.chkGeography2.AutoSize = true
    Me.chkGeography2.Location = New System.Drawing.Point(6, 66)
    Me.chkGeography2.Name = "chkGeography2"
    Me.chkGeography2.Size = New System.Drawing.Size(154, 17)
    Me.chkGeography2.TabIndex = 2
    Me.chkGeography2.Tag = "2"
    Me.chkGeography2.Text = "Underrepresented State [2]"
    Me.chkGeography2.UseVisualStyleBackColor = true
    '
    'chkGeography6
    '
    Me.chkGeography6.AutoSize = true
    Me.chkGeography6.Location = New System.Drawing.Point(6, 42)
    Me.chkGeography6.Name = "chkGeography6"
    Me.chkGeography6.Size = New System.Drawing.Size(190, 17)
    Me.chkGeography6.TabIndex = 1
    Me.chkGeography6.Tag = "6"
    Me.chkGeography6.Text = "Underrepresented State County [6]"
    Me.chkGeography6.UseVisualStyleBackColor = true
    '
    'chkGeography10
    '
    Me.chkGeography10.AutoSize = true
    Me.chkGeography10.Location = New System.Drawing.Point(6, 19)
    Me.chkGeography10.Name = "chkGeography10"
    Me.chkGeography10.Size = New System.Drawing.Size(117, 17)
    Me.chkGeography10.TabIndex = 0
    Me.chkGeography10.Tag = "10"
    Me.chkGeography10.Text = "State Resident [10]"
    Me.chkGeography10.UseVisualStyleBackColor = true
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(18, 217)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(616, 13)
    Me.Label2.TabIndex = 21
    Me.Label2.Text = resources.GetString("Label2.Text")
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(483, 73)
    Me.txtOutput.Multiline = true
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = true
    Me.txtOutput.Size = New System.Drawing.Size(110, 65)
    Me.txtOutput.TabIndex = 20
    '
    'grpHighSchool
    '
    Me.grpHighSchool.Controls.Add(Me.radSchool10)
    Me.grpHighSchool.Controls.Add(Me.radSchool8)
    Me.grpHighSchool.Controls.Add(Me.radSchool6)
    Me.grpHighSchool.Controls.Add(Me.radSchool4)
    Me.grpHighSchool.Controls.Add(Me.radSchool2)
    Me.grpHighSchool.Controls.Add(Me.radSchool0)
    Me.grpHighSchool.Location = New System.Drawing.Point(173, 73)
    Me.grpHighSchool.Name = "grpHighSchool"
    Me.grpHighSchool.Size = New System.Drawing.Size(130, 136)
    Me.grpHighSchool.TabIndex = 13
    Me.grpHighSchool.TabStop = false
    Me.grpHighSchool.Text = "High School Quality"
    '
    'radSchool10
    '
    Me.radSchool10.AutoSize = true
    Me.radSchool10.Location = New System.Drawing.Point(72, 90)
    Me.radSchool10.Name = "radSchool10"
    Me.radSchool10.Size = New System.Drawing.Size(52, 17)
    Me.radSchool10.TabIndex = 5
    Me.radSchool10.TabStop = true
    Me.radSchool10.Tag = "10"
    Me.radSchool10.Text = "5 [10]"
    Me.radSchool10.UseVisualStyleBackColor = true
    '
    'radSchool8
    '
    Me.radSchool8.AutoSize = true
    Me.radSchool8.Location = New System.Drawing.Point(73, 57)
    Me.radSchool8.Name = "radSchool8"
    Me.radSchool8.Size = New System.Drawing.Size(46, 17)
    Me.radSchool8.TabIndex = 4
    Me.radSchool8.TabStop = true
    Me.radSchool8.Tag = "8"
    Me.radSchool8.Text = "4 [8]"
    Me.radSchool8.UseVisualStyleBackColor = true
    '
    'radSchool6
    '
    Me.radSchool6.AutoSize = true
    Me.radSchool6.Location = New System.Drawing.Point(73, 21)
    Me.radSchool6.Name = "radSchool6"
    Me.radSchool6.Size = New System.Drawing.Size(46, 17)
    Me.radSchool6.TabIndex = 3
    Me.radSchool6.TabStop = true
    Me.radSchool6.Tag = "6"
    Me.radSchool6.Text = "3 [6]"
    Me.radSchool6.UseVisualStyleBackColor = true
    '
    'radSchool4
    '
    Me.radSchool4.AutoSize = true
    Me.radSchool4.Location = New System.Drawing.Point(11, 93)
    Me.radSchool4.Name = "radSchool4"
    Me.radSchool4.Size = New System.Drawing.Size(46, 17)
    Me.radSchool4.TabIndex = 2
    Me.radSchool4.TabStop = true
    Me.radSchool4.Tag = "4"
    Me.radSchool4.Text = "2 [4]"
    Me.radSchool4.UseVisualStyleBackColor = true
    '
    'radSchool2
    '
    Me.radSchool2.AutoSize = true
    Me.radSchool2.Location = New System.Drawing.Point(11, 57)
    Me.radSchool2.Name = "radSchool2"
    Me.radSchool2.Size = New System.Drawing.Size(46, 17)
    Me.radSchool2.TabIndex = 1
    Me.radSchool2.TabStop = true
    Me.radSchool2.Tag = "2"
    Me.radSchool2.Text = "1 [2]"
    Me.radSchool2.UseVisualStyleBackColor = true
    '
    'radSchool0
    '
    Me.radSchool0.AutoSize = true
    Me.radSchool0.Location = New System.Drawing.Point(11, 21)
    Me.radSchool0.Name = "radSchool0"
    Me.radSchool0.Size = New System.Drawing.Size(46, 17)
    Me.radSchool0.TabIndex = 0
    Me.radSchool0.TabStop = true
    Me.radSchool0.Tag = "0"
    Me.radSchool0.Text = "0 [0]"
    Me.radSchool0.UseVisualStyleBackColor = true
    '
    'grpCurriculum
    '
    Me.grpCurriculum.Controls.Add(Me.radCurriculum8)
    Me.grpCurriculum.Controls.Add(Me.radCurriculum6)
    Me.grpCurriculum.Controls.Add(Me.radCurriculum4)
    Me.grpCurriculum.Controls.Add(Me.radCurriculum2)
    Me.grpCurriculum.Controls.Add(Me.radCurriculum0)
    Me.grpCurriculum.Controls.Add(Me.radCurriculumNegative2)
    Me.grpCurriculum.Controls.Add(Me.radCurriculumNegative4)
    Me.grpCurriculum.Location = New System.Drawing.Point(322, 73)
    Me.grpCurriculum.Name = "grpCurriculum"
    Me.grpCurriculum.Size = New System.Drawing.Size(139, 136)
    Me.grpCurriculum.TabIndex = 14
    Me.grpCurriculum.TabStop = false
    Me.grpCurriculum.Text = "Difficulty of Curriculum"
    '
    'radCurriculum8
    '
    Me.radCurriculum8.AutoSize = true
    Me.radCurriculum8.Location = New System.Drawing.Point(82, 81)
    Me.radCurriculum8.Name = "radCurriculum8"
    Me.radCurriculum8.Size = New System.Drawing.Size(46, 17)
    Me.radCurriculum8.TabIndex = 6
    Me.radCurriculum8.TabStop = true
    Me.radCurriculum8.Tag = "8"
    Me.radCurriculum8.Text = "4 [8]"
    Me.radCurriculum8.UseVisualStyleBackColor = true
    '
    'radCurriculum6
    '
    Me.radCurriculum6.AutoSize = true
    Me.radCurriculum6.Location = New System.Drawing.Point(82, 51)
    Me.radCurriculum6.Name = "radCurriculum6"
    Me.radCurriculum6.Size = New System.Drawing.Size(46, 17)
    Me.radCurriculum6.TabIndex = 5
    Me.radCurriculum6.TabStop = true
    Me.radCurriculum6.Tag = "6"
    Me.radCurriculum6.Text = "3 [6]"
    Me.radCurriculum6.UseVisualStyleBackColor = true
    '
    'radCurriculum4
    '
    Me.radCurriculum4.AutoSize = true
    Me.radCurriculum4.Location = New System.Drawing.Point(82, 21)
    Me.radCurriculum4.Name = "radCurriculum4"
    Me.radCurriculum4.Size = New System.Drawing.Size(46, 17)
    Me.radCurriculum4.TabIndex = 4
    Me.radCurriculum4.TabStop = true
    Me.radCurriculum4.Tag = "4"
    Me.radCurriculum4.Text = "2 [4]"
    Me.radCurriculum4.UseVisualStyleBackColor = true
    '
    'radCurriculum2
    '
    Me.radCurriculum2.AutoSize = true
    Me.radCurriculum2.Location = New System.Drawing.Point(11, 111)
    Me.radCurriculum2.Name = "radCurriculum2"
    Me.radCurriculum2.Size = New System.Drawing.Size(46, 17)
    Me.radCurriculum2.TabIndex = 3
    Me.radCurriculum2.TabStop = true
    Me.radCurriculum2.Tag = "2"
    Me.radCurriculum2.Text = "1 [2]"
    Me.radCurriculum2.UseVisualStyleBackColor = true
    '
    'radCurriculum0
    '
    Me.radCurriculum0.AutoSize = true
    Me.radCurriculum0.Location = New System.Drawing.Point(11, 81)
    Me.radCurriculum0.Name = "radCurriculum0"
    Me.radCurriculum0.Size = New System.Drawing.Size(46, 17)
    Me.radCurriculum0.TabIndex = 2
    Me.radCurriculum0.TabStop = true
    Me.radCurriculum0.Tag = "0"
    Me.radCurriculum0.Text = "0 [0]"
    Me.radCurriculum0.UseVisualStyleBackColor = true
    '
    'radCurriculumNegative2
    '
    Me.radCurriculumNegative2.AutoSize = true
    Me.radCurriculumNegative2.Location = New System.Drawing.Point(11, 51)
    Me.radCurriculumNegative2.Name = "radCurriculumNegative2"
    Me.radCurriculumNegative2.Size = New System.Drawing.Size(52, 17)
    Me.radCurriculumNegative2.TabIndex = 1
    Me.radCurriculumNegative2.TabStop = true
    Me.radCurriculumNegative2.Tag = "-2"
    Me.radCurriculumNegative2.Text = "-1 [-2]"
    Me.radCurriculumNegative2.UseVisualStyleBackColor = true
    '
    'radCurriculumNegative4
    '
    Me.radCurriculumNegative4.AutoSize = true
    Me.radCurriculumNegative4.Location = New System.Drawing.Point(11, 21)
    Me.radCurriculumNegative4.Name = "radCurriculumNegative4"
    Me.radCurriculumNegative4.Size = New System.Drawing.Size(52, 17)
    Me.radCurriculumNegative4.TabIndex = 0
    Me.radCurriculumNegative4.TabStop = true
    Me.radCurriculumNegative4.Tag = "-4"
    Me.radCurriculumNegative4.Text = "-2 [-4]"
    Me.radCurriculumNegative4.UseVisualStyleBackColor = true
    '
    'btnCalculate
    '
    Me.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnCalculate.Location = New System.Drawing.Point(483, 20)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(110, 35)
    Me.btnCalculate.TabIndex = 18
    Me.btnCalculate.Text = "Calculate Score"
    Me.btnCalculate.UseVisualStyleBackColor = false
    '
    'txtGPAPoints
    '
    Me.txtGPAPoints.Location = New System.Drawing.Point(363, 20)
    Me.txtGPAPoints.Name = "txtGPAPoints"
    Me.txtGPAPoints.ReadOnly = true
    Me.txtGPAPoints.Size = New System.Drawing.Size(47, 20)
    Me.txtGPAPoints.TabIndex = 17
    '
    'txtGPAScore
    '
    Me.txtGPAScore.Location = New System.Drawing.Point(293, 20)
    Me.txtGPAScore.Name = "txtGPAScore"
    Me.txtGPAScore.Size = New System.Drawing.Size(54, 20)
    Me.txtGPAScore.TabIndex = 16
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(199, 23)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(88, 13)
    Me.Label1.TabIndex = 15
    Me.Label1.Text = "Enter GPA Score"
    '
    'radSat0
    '
    Me.radSat0.AutoSize = true
    Me.radSat0.Location = New System.Drawing.Point(11, 21)
    Me.radSat0.Name = "radSat0"
    Me.radSat0.Size = New System.Drawing.Size(79, 17)
    Me.radSat0.TabIndex = 0
    Me.radSat0.TabStop = true
    Me.radSat0.Tag = "0"
    Me.radSat0.Text = "400-920 [0]"
    Me.radSat0.UseVisualStyleBackColor = true
    '
    'radSat6
    '
    Me.radSat6.AutoSize = true
    Me.radSat6.Location = New System.Drawing.Point(11, 44)
    Me.radSat6.Name = "radSat6"
    Me.radSat6.Size = New System.Drawing.Size(85, 17)
    Me.radSat6.TabIndex = 1
    Me.radSat6.TabStop = true
    Me.radSat6.Tag = "6"
    Me.radSat6.Text = "930-1000 [6]"
    Me.radSat6.UseVisualStyleBackColor = true
    '
    'radSat10
    '
    Me.radSat10.AutoSize = true
    Me.radSat10.Location = New System.Drawing.Point(11, 67)
    Me.radSat10.Name = "radSat10"
    Me.radSat10.Size = New System.Drawing.Size(97, 17)
    Me.radSat10.TabIndex = 2
    Me.radSat10.TabStop = true
    Me.radSat10.Tag = "10"
    Me.radSat10.Text = "1010-1190 [10]"
    Me.radSat10.UseVisualStyleBackColor = true
    '
    'radSat11
    '
    Me.radSat11.AutoSize = true
    Me.radSat11.Location = New System.Drawing.Point(11, 90)
    Me.radSat11.Name = "radSat11"
    Me.radSat11.Size = New System.Drawing.Size(97, 17)
    Me.radSat11.TabIndex = 3
    Me.radSat11.TabStop = true
    Me.radSat11.Tag = "11"
    Me.radSat11.Text = "1200-1350 [11]"
    Me.radSat11.UseVisualStyleBackColor = true
    '
    'radSat12
    '
    Me.radSat12.AutoSize = true
    Me.radSat12.Location = New System.Drawing.Point(11, 113)
    Me.radSat12.Name = "radSat12"
    Me.radSat12.Size = New System.Drawing.Size(97, 17)
    Me.radSat12.TabIndex = 4
    Me.radSat12.TabStop = true
    Me.radSat12.Tag = "12"
    Me.radSat12.Text = "1360-1600 [12]"
    Me.radSat12.UseVisualStyleBackColor = true
    '
    'grpSAT
    '
    Me.grpSAT.Controls.Add(Me.radSat12)
    Me.grpSAT.Controls.Add(Me.radSat11)
    Me.grpSAT.Controls.Add(Me.radSat10)
    Me.grpSAT.Controls.Add(Me.radSat6)
    Me.grpSAT.Controls.Add(Me.radSat0)
    Me.grpSAT.Location = New System.Drawing.Point(20, 73)
    Me.grpSAT.Name = "grpSAT"
    Me.grpSAT.Size = New System.Drawing.Size(136, 136)
    Me.grpSAT.TabIndex = 19
    Me.grpSAT.TabStop = false
    Me.grpSAT.Text = "SAT"
    '
    'frmCollegeAdmissions
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(658, 497)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.grpAlumni)
    Me.Controls.Add(Me.grpEssay)
    Me.Controls.Add(Me.grpLeadership)
    Me.Controls.Add(Me.grpMisc)
    Me.Controls.Add(Me.grpGeography)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.grpHighSchool)
    Me.Controls.Add(Me.grpCurriculum)
    Me.Controls.Add(Me.grpSAT)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.txtGPAPoints)
    Me.Controls.Add(Me.txtGPAScore)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmCollegeAdmissions"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "College Admissions"
    Me.grpAlumni.ResumeLayout(false)
    Me.grpAlumni.PerformLayout
    Me.grpEssay.ResumeLayout(false)
    Me.grpEssay.PerformLayout
    Me.grpLeadership.ResumeLayout(false)
    Me.grpLeadership.PerformLayout
    Me.grpMisc.ResumeLayout(false)
    Me.grpMisc.PerformLayout
    Me.grpGeography.ResumeLayout(false)
    Me.grpGeography.PerformLayout
    Me.grpHighSchool.ResumeLayout(false)
    Me.grpHighSchool.PerformLayout
    Me.grpCurriculum.ResumeLayout(false)
    Me.grpCurriculum.PerformLayout
    Me.grpSAT.ResumeLayout(false)
    Me.grpSAT.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents Label3 As Label
  Friend WithEvents grpAlumni As GroupBox
  Friend WithEvents chkAlumni1 As CheckBox
  Friend WithEvents chkAlumni4 As CheckBox
  Friend WithEvents grpEssay As GroupBox
  Friend WithEvents radEssay3 As RadioButton
  Friend WithEvents radEssay2 As RadioButton
  Friend WithEvents radEssay1 As RadioButton
  Friend WithEvents grpLeadership As GroupBox
  Friend WithEvents chkLeadership5 As CheckBox
  Friend WithEvents chkLeadership2 As CheckBox
  Friend WithEvents chkLeadership1 As CheckBox
  Friend WithEvents grpMisc As GroupBox
  Friend WithEvents radMiscProvot20 As RadioButton
  Friend WithEvents radMiscAthlete20 As RadioButton
  Friend WithEvents radMisc5 As RadioButton
  Friend WithEvents radMiscSocio20 As RadioButton
  Friend WithEvents grpGeography As GroupBox
  Friend WithEvents chkGeography2 As CheckBox
  Friend WithEvents chkGeography6 As CheckBox
  Friend WithEvents chkGeography10 As CheckBox
  Friend WithEvents Label2 As Label
  Friend WithEvents txtOutput As TextBox
  Friend WithEvents grpHighSchool As GroupBox
  Friend WithEvents radSchool10 As RadioButton
  Friend WithEvents radSchool8 As RadioButton
  Friend WithEvents radSchool6 As RadioButton
  Friend WithEvents radSchool4 As RadioButton
  Friend WithEvents radSchool2 As RadioButton
  Friend WithEvents radSchool0 As RadioButton
  Friend WithEvents grpCurriculum As GroupBox
  Friend WithEvents radCurriculum8 As RadioButton
  Friend WithEvents radCurriculum6 As RadioButton
  Friend WithEvents radCurriculum4 As RadioButton
  Friend WithEvents radCurriculum2 As RadioButton
  Friend WithEvents radCurriculum0 As RadioButton
  Friend WithEvents radCurriculumNegative2 As RadioButton
  Friend WithEvents radCurriculumNegative4 As RadioButton
  Friend WithEvents btnCalculate As Button
  Friend WithEvents txtGPAPoints As TextBox
  Friend WithEvents txtGPAScore As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents radSat0 As RadioButton
  Friend WithEvents radSat6 As RadioButton
  Friend WithEvents radSat10 As RadioButton
  Friend WithEvents radSat11 As RadioButton
  Friend WithEvents radSat12 As RadioButton
  Friend WithEvents grpSAT As GroupBox
End Class
