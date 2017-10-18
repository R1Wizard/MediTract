

Module Module1

    Public SingQUotes As Integer



    Public Sub StripToPeriods()

        Form1.txtNoPs.Text = ""
        Form1.txtList.Text = ""

        Dim Nums As String() = Form1.txtWithPs.Text.Split(vbCrLf)
        Dim Tstr As String
        'Dim Tcount As Integer
        Dim Ploc As Integer
        Dim TempStr As String = ""
        For Each Tstr In Nums
            If Tstr.Length > 1 Then

                TempStr = Replace(Tstr, vbLf, "")
                If InStr(TempStr, vbTab) Then TempStr = Replace(TempStr, vbTab, "")
                If InStr(TempStr, " ") Then TempStr = Replace(TempStr, " ", "")
                If InStr(UCase(TempStr), "A") Then TempStr = Replace(UCase(TempStr), "A", "")
                    If InStr(UCase(TempStr), "B") Then TempStr = Replace(UCase(TempStr), "B", "")
                    If InStr(UCase(TempStr), "C") Then TempStr = Replace(UCase(TempStr), "C", "")
                    If InStr(UCase(TempStr), "D") Then TempStr = Replace(UCase(TempStr), "D", "")
                    If InStr(UCase(TempStr), "E") Then TempStr = Replace(UCase(TempStr), "E", "")
                    If InStr(UCase(TempStr), "F") Then TempStr = Replace(UCase(TempStr), "F", "")
                    Ploc = Strings.InStr(TempStr, ".")
                    Form1.txtNoPs.Text = Form1.txtNoPs.Text & Mid(TempStr, Ploc + 1) & vbCrLf


                End If

        Next



    End Sub

    Public Sub StripHyphens()




        Dim Nums As String() = Form1.txtWithPs.Text.Split(vbCrLf)
        Dim Tstr As String
        'Dim Tcount As Integer
        Dim Ploc As Integer
        Dim TempStr As String = ""
        For Each Tstr In Nums
            If Tstr.Length > 0 Then

                TempStr = Replace(Tstr, vbLf, "")
                If InStr(TempStr, vbTab) Then TempStr = Replace(TempStr, vbTab, "")
                If InStr(TempStr, " ") Then TempStr = Replace(TempStr, " ", "")
                Ploc = Strings.InStr(TempStr, "-")
                Form1.txtNoPs.Text = Form1.txtNoPs.Text & Mid(TempStr, Ploc + 1) & vbCrLf


            End If

        Next




    End Sub








    Public Sub SetList()
        Dim Nums As String() = Form1.txtNoPs.Text.Split(vbCrLf)
        Dim List As String = "("
        Dim Tstr As String = ""
        Dim Tcnt As Integer = 0
        Dim TempStr As String = ""
        Dim TTstr As String = ""

        For Each Tstr In Nums

            If Tstr.Length > 0 Then

                TTstr = Trim(Tstr)

                If SingQUotes = 1 Then TempStr = "'" & Replace(TTstr, vbLf, "") & "'"
                If SingQUotes = 0 Then TempStr = Replace(TTstr, vbLf, "")

                List = List & TempStr & ","

                Tcnt = Tcnt + 1

            End If

        Next
        Form1.lblCount.Text = "COUNT" & vbCrLf & Tcnt
        Application.DoEvents()
        List = Left(List, List.Length - 1) & ")"
        Form1.txtList.Text = List
TRYAGAIN:
        Try
            ' My.Computer.Clipboard.Clear()
            'My.Computer.Clipboard.SetText(List)

        Catch ex As Exception
            'GoTo TRYAGAIN


        End Try


    End Sub


End Module
