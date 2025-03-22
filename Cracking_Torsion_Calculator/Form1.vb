Public Class Form1

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        aboutForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        On Error GoTo HandleError

        Dim b As Double = Convert.ToDouble(inputWidth.Text)
        Dim h As Double = Convert.ToDouble(inputHeight.Text)
        Dim cc As Double = Convert.ToDouble(inputClearCover.Text)
        Dim fc As Double = Convert.ToDouble(inputFC.Text)

        Dim phi As Double
        If radPhi_075.Checked Then
            phi = 0.75
        ElseIf radPhi_085.Checked Then
            phi = 0.85
        End If

        Dim Acp As Double = b * h
        Dim Pcp As Double = 2.0 * (b + h)

        Dim rootfc As Double = Math.Sqrt(fc)

        Dim phiTcr As Double = phi * 4.0 * rootfc * Acp ^ 2 / Pcp

        outputAcp.Text = Acp.ToString("0.00")
        outputPcp.Text = Pcp.ToString("0.00")
        outputTcr_lbinch.Text = phiTcr.ToString("0.00")
        outputTcr_kipft.Text = (phiTcr / 12000).ToString("0.00")

        Exit Sub

HandleError:
        MsgBox("An error has occured. Please check all input values and try again", vbOKOnly, "Oh, I am sorry!")

    End Sub
End Class
