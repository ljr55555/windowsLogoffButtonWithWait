Public Class Form1
    Dim iLogOffDelay As Integer = 30
    Dim boolSlashes As Boolean = True
    'MessageBox.Show(My.Computer.Info.OSFullName)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim osVer As Version = Environment.OSVersion.Version
        If boolSlashes Then
            'MessageBox.Show("shutdown /l /f /t " & iLogOffDelay)
            Shell("shutdown /l /f /t " & iLogOffDelay)
        Else
            'MessageBox.Show("shutdown -l -f -t " & iLogOffDelay)
            Shell("shutdown -l -f -t " & iLogOffDelay)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        'MessageBox.Show("shutdown /a")
        Shell("shutdown -a")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
