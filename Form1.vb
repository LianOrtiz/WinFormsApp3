Public Class Form1
    Private Sub btnShowResult_Click(sender As Object, e As EventArgs) Handles btnShowResult.Click
        Dim course As String = If(cmbCourse.SelectedItem IsNot Nothing, cmbCourse.SelectedItem.ToString(), "Not Selected")


        Dim hobbiesList As New List(Of String)
        If chkReading.Checked Then hobbiesList.Add("Reading")
        If chkSports.Checked Then hobbiesList.Add("Sports")
        If chkMusic.Checked Then hobbiesList.Add("Music")


        Dim hobbies As String = If(hobbiesList.Count > 0, String.Join(", ", hobbiesList), "None")


        Dim gender As String = "Not Selected"
        If rdoMale.Checked Then
            gender = "Male"
        ElseIf rdoFemale.Checked Then
            gender = "Female"
        End If


        lblCourseResult.Text = "Course: " & course
        lblHobbiesResult.Text = "Hobbies: " & hobbies
        lblGenderResult.Text = "Gender: " & gender
    End Sub

End Class
