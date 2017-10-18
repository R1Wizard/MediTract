Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SingQUotes = 0
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtWithPs.TextChanged
        If RdoHyphens.Checked = True Then
            Call StripHyphens()
        End If
        If RdoPeriods.Checked = True Then
            Call StripToPeriods()
        End If


    End Sub

    Private Sub txtNoPs_TextChanged(sender As Object, e As EventArgs) Handles txtNoPs.TextChanged
        Call SetList()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtList.Text = ""
        txtNoPs.Text = ""
        txtWithPs.Text = ""
        txtList.Text = ""
        txtNoPs.Text = ""
        txtWithPs.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SingQUotes = 1
        Call SetList()
        SingQUotes = 0

    End Sub

    Private Sub txtList_TextChanged(sender As Object, e As EventArgs) Handles txtList.TextChanged

    End Sub

    Private Sub RdoPeriods_CheckedChanged(sender As Object, e As EventArgs) Handles RdoPeriods.CheckedChanged

    End Sub
End Class
