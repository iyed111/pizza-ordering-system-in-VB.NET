Public Class Form1
    'value
    Const fine = 10
    Const classique = 14
    Const epaisse = 18
    ' Adds on value 
    Const champignion = 3
    Const olives = 2
    Const fromageSupplimentaire = 5

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles prop2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles prop3.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles prop1.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnEnvoyer_Click(sender As Object, e As EventArgs) Handles btnEnvoyer.Click
        'Function 
        Dim x As String
        Dim aprix As Integer
        Dim bprix As Integer
        Dim member As Integer





        'order connected to quantity
        If prop1.Checked = True Then
            aprix = fine * txtQte.Text
        ElseIf prop2.checked = True Then
            aprix = classique * txtQte.Text
        ElseIf prop3.checked = True Then
            aprix = epaisse * txtQte.Text

        End If







        'ajouter connected to quantity
        If chk1.Checked = True Then
            bprix = champignion * txtQte.Text
        ElseIf chk2.Checked = True Then
            bprix = olives * txtQte.Text
        ElseIf chk3.Checked = True Then
            bprix = fromageSupplimentaire * txtQte.Text


        End If




        'if member discount 
        If Me.fidel.Text = "oui" Then
            member = 5%
        Else
            Me.fidel.Text = " non"

        End If






        ' message 
        x = "Prix Totale :" & aprix + bprix - member & "  TND" & Environment.NewLine
        MessageBox.Show(x, " pizza order", MessageBoxButtons.OK)




    End Sub

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click

        Dim ingredient As String = ""
        If prop1.Checked Then
            ingredient = "croute fine"
        ElseIf prop2.checked Then
            ingredient = "croute classique"
        ElseIf prop3.checked Then
            ingredient = "croute epaisse"
        End If




        Dim IngrSupp As String = ""
        If chk1.Checked Then
            IngrSupp = IngrSupp + "champignion"
        ElseIf chk2.checked Then
            IngrSupp = IngrSupp + "olive"
        ElseIf chk3.checked Then
            IngrSupp = IngrSupp + "fromage supplimentaire"

        End If
        Dim msg As String = "*type de croute :" + ingredient + "   *ingredient supplimentaire :" + IngrSupp + "  *quantité :" + txtQte.Text
        MessageBox.Show(msg)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
