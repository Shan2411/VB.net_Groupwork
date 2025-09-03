
Public Class Form2

    Dim string1stnum As String
    Dim string2ndnum As String

    Dim num1 As Integer
    Dim num2 As Integer


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Enter
        Me.SelectNextControl(TextBox1, True, True, True, True)
        TextBox1.ReadOnly = True
        TextBox1.TabStop = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "8"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
        Else 'if its false'
            string1stnum = "8"
            TextBox1.Text &= string1stnum
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "9"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
        Else 'if its false'
            string1stnum = "9"
            TextBox1.Text &= string1stnum
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "7"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
        Else 'if its false'
            string1stnum = "7"
            TextBox1.Text &= string1stnum
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "5"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
            ClearNumberActive = False
        Else 'if its false'
            string1stnum = "5"
            TextBox1.Text &= string1stnum
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "1"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
        Else 'if its false'
            string1stnum = "1"
            TextBox1.Text &= string1stnum
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "4"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
        Else 'if its false'
            string1stnum = "4"
            TextBox1.Text &= string1stnum
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "6"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
        Else 'if its false'
            string1stnum = "6"
            TextBox1.Text &= string1stnum
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "2"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
            operation = ""

        Else 'if its false'
            string1stnum = "2"
            TextBox1.Text &= string1stnum
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "3"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
            'operation = "" this solves equal button bug when clearnumber is active but equals button calculates based on the operation previously selected'
        Else 'if its false'
            string1stnum = "3"
            TextBox1.Text &= string1stnum
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If ClearNumberActive Then 'if its true'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            string1stnum = "0"
            TextBox1.Text &= string1stnum
            ClearNumberActive = False
            is1stNumEmpty = False
            operation = ""
        Else 'if its false'
            string1stnum = "0"
            TextBox1.Text &= string1stnum
        End If
    End Sub

    Dim equals As New Equals()
    Dim result As Integer
    Dim is1stNumEmpty As Boolean = True ''''
    Dim ClearNumberActive As Boolean = False ''
    Dim operation As String = ""

    'add button'
    Public Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If is1stNumEmpty Then 'TRUE'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox2.Text = num1 & " + "
            TextBox3.Text = num1
            is1stNumEmpty = False
            operation = "add"
        ElseIf Not is1stNumEmpty Then 'FALSE'  "we can add fif condition for if 1stnum empty inside buttons"
            num2 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox2.Text = num1 & "  + " & num2 & " ="
            result = num1 + num2
            TextBox1.Text = result
            is1stNumEmpty = True
            operation = "add"
            ClearNumberActive = True
        End If
    End Sub

    'subtract button'
    Public Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If is1stNumEmpty Then
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox2.Text = num1 & " - "
            TextBox3.Text = num1
            is1stNumEmpty = False
            operation = "subtract"
        Else
            num2 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox2.Text = num1 & " - " & num2 & " ="
            result = num1 - num2
            TextBox1.Text = result
            is1stNumEmpty = True
            operation = "subtract"
            ClearNumberActive = True
        End If
    End Sub


    'multiply button'
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If is1stNumEmpty Then 'TRUE'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox2.Text = num1 & " * "
            is1stNumEmpty = False
            operation = "multiply"
        ElseIf Not is1stNumEmpty Then 'FALSE'
            num2 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox2.Text = num1 & " * " & num2 & " ="
            result = num1 * num2
            TextBox1.Text = result
            is1stNumEmpty = True
            ClearNumberActive = True
        End If
    End Sub

    'divide button'
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If is1stNumEmpty Then 'TRUE'
            num1 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox2.Text = num1 & " / "
            is1stNumEmpty = False
            operation = "divide"
        ElseIf Not is1stNumEmpty Then 'FALSE'
            num2 = Val(TextBox1.Text)
            TextBox1.Text = ""
            TextBox2.Text = num1 & " / " & num2 & " ="
            result = num1 / num2
            TextBox1.Text = result
            is1stNumEmpty = True
            ClearNumberActive = True
        End If
    End Sub

    'Equals button'
    Public Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If operation = "" Then
            TextBox3.Text = "Invalid: no operation selected"
            Return
        End If

        If TextBox1.Text = "" Then
            TextBox3.Text = "Enter a number"
            Return
        End If

        num2 = Val(TextBox1.Text)
        TextBox1.Text = ""

        Select Case operation
            Case "add"
                result = num1 + num2
                TextBox2.Text = num1 & " + " & num2 & " ="
            Case "subtract"
                result = num1 - num2
                TextBox2.Text = num1 & " - " & num2 & " ="
            Case "multiply"
                result = num1 * num2
                TextBox2.Text = num1 & " * " & num2 & " ="
            Case "divide"
                If num2 = 0 Then
                    TextBox1.Text = "Error"
                    TextBox2.Text = num1 & " / 0 ="
                    TextBox3.Text = "Cannot divide by 0"
                    Return
                End If
                result = num1 / num2
                TextBox2.Text = num1 & " / " & num2 & " ="
        End Select

        TextBox1.Text = result
        TextBox3.Text = ""
        num1 = result   ' Save result in num1 to allow chaining (e.g. result - 5 =)
        is1stNumEmpty = False
        ClearNumberActive = True
        operation = ""  ' Clear operation to prevent repeating it without user input
    End Sub


    'DEL'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
    End Sub
    'CLEAR'
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        is1stNumEmpty = True ''''
        ClearNumberActive = False ''
        operation = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        num1 = 0
        num2 = 0
    End Sub
End Class

Public Class Equals
    Dim result As Integer

End Class

