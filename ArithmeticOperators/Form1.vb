Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'declaration of variables and their datatypes
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iNumber3 As Decimal

        'taking inputs from the user
        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        'for sum
        iNumber3 = iNumber1 + iNumber2
        MsgBox(iNumber1 & " + " & iNumber2 & " = " & iNumber3)

        'for the difference
        iNumber3 = iNumber1 - iNumber2
        MsgBox(iNumber1 & " - " & iNumber2 & " = " & iNumber3)

        'for the product
        iNumber3 = iNumber1 * iNumber2
        MsgBox(iNumber1 & " * " & iNumber2 & " = " & iNumber3)

        'for the quetiont
        iNumber3 = iNumber1 / iNumber2
        MsgBox(iNumber1 & " / " & iNumber2 & " = " & iNumber3)

        'the following operators are not soo popular
        'for the power operator
        iNumber3 = iNumber1 ^ iNumber2
        MsgBox(iNumber1 & " to the power of " & iNumber2 & " = " & iNumber3)

        'for DIV integer division
        iNumber3 = iNumber1 \ iNumber2
        MsgBox(iNumber1 & " \ " & iNumber2 & " = " & iNumber3 & " is floor devision")

        'for modulas operator
        iNumber3 = iNumber1 Mod iNumber2
        MsgBox(iNumber1 & "mod" & iNumber2 & " = " & iNumber3 & " is the remainder")

        MsgBox("---The End----")
    End Sub
End Class
