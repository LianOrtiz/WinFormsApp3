<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblGenderResult = New Label()
        lblHobbiesResult = New Label()
        lblCourseResult = New Label()
        chkMusic = New CheckBox()
        chkSports = New CheckBox()
        chkReading = New CheckBox()
        cmbCourse = New ComboBox()
        grpGender = New GroupBox()
        rdoFemale = New RadioButton()
        rdoMale = New RadioButton()
        btnShowResult = New Button()
        grpGender.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblGenderResult
        ' 
        lblGenderResult.AutoSize = True
        lblGenderResult.Location = New Point(281, 38)
        lblGenderResult.Name = "lblGenderResult"
        lblGenderResult.Size = New Size(60, 20)
        lblGenderResult.TabIndex = 0
        lblGenderResult.Text = "Gender:"
        ' 
        ' lblHobbiesResult
        ' 
        lblHobbiesResult.AutoSize = True
        lblHobbiesResult.Location = New Point(281, 73)
        lblHobbiesResult.Name = "lblHobbiesResult"
        lblHobbiesResult.Size = New Size(68, 20)
        lblHobbiesResult.TabIndex = 1
        lblHobbiesResult.Text = "Hobbies:"
        ' 
        ' lblCourseResult
        ' 
        lblCourseResult.AutoSize = True
        lblCourseResult.Location = New Point(281, 114)
        lblCourseResult.Name = "lblCourseResult"
        lblCourseResult.Size = New Size(57, 20)
        lblCourseResult.TabIndex = 2
        lblCourseResult.Text = "Course:"
        ' 
        ' chkMusic
        ' 
        chkMusic.AutoSize = True
        chkMusic.Location = New Point(114, 169)
        chkMusic.Name = "chkMusic"
        chkMusic.Size = New Size(69, 24)
        chkMusic.TabIndex = 3
        chkMusic.Text = "Music"
        chkMusic.UseVisualStyleBackColor = True
        ' 
        ' chkSports
        ' 
        chkSports.AutoSize = True
        chkSports.Location = New Point(304, 169)
        chkSports.Name = "chkSports"
        chkSports.Size = New Size(73, 24)
        chkSports.TabIndex = 4
        chkSports.Text = "Sports"
        chkSports.UseVisualStyleBackColor = True
        ' 
        ' chkReading
        ' 
        chkReading.AutoSize = True
        chkReading.Location = New Point(487, 169)
        chkReading.Name = "chkReading"
        chkReading.Size = New Size(86, 24)
        chkReading.TabIndex = 5
        chkReading.Text = "Reading"
        chkReading.UseVisualStyleBackColor = True
        ' 
        ' cmbCourse
        ' 
        cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {"BSIT", "BSHRM", "BSA", "BEED", "BSED", "BSBA", "BSMT", "BSCE"})
        cmbCourse.Location = New Point(281, 210)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(151, 28)
        cmbCourse.TabIndex = 6
        ' 
        ' grpGender
        ' 
        grpGender.Controls.Add(rdoFemale)
        grpGender.Controls.Add(rdoMale)
        grpGender.Location = New Point(234, 256)
        grpGender.Name = "grpGender"
        grpGender.Size = New Size(250, 125)
        grpGender.TabIndex = 7
        grpGender.TabStop = False
        grpGender.Text = "Gender"
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Location = New Point(86, 66)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(78, 24)
        rdoFemale.TabIndex = 1
        rdoFemale.TabStop = True
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Location = New Point(86, 36)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(63, 24)
        rdoMale.TabIndex = 0
        rdoMale.TabStop = True
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' btnShowResult
        ' 
        btnShowResult.Location = New Point(293, 399)
        btnShowResult.Name = "btnShowResult"
        btnShowResult.Size = New Size(119, 29)
        btnShowResult.TabIndex = 8
        btnShowResult.Text = "Show Result"
        btnShowResult.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnShowResult)
        Controls.Add(grpGender)
        Controls.Add(cmbCourse)
        Controls.Add(chkReading)
        Controls.Add(chkSports)
        Controls.Add(chkMusic)
        Controls.Add(lblCourseResult)
        Controls.Add(lblHobbiesResult)
        Controls.Add(lblGenderResult)
        Name = "Form1"
        Text = "Form1"
        grpGender.ResumeLayout(False)
        grpGender.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGenderResult As Label
    Friend WithEvents lblHobbiesResult As Label
    Friend WithEvents lblCourseResult As Label
    Friend WithEvents chkMusic As CheckBox
    Friend WithEvents chkSports As CheckBox
    Friend WithEvents chkReading As CheckBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents btnShowResult As Button

End Class
