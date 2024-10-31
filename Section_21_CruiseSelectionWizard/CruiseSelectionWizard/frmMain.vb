Public Class frmMain

    Private wizardForms As Form() = {Nothing, New frmWizard1, New frmWizard2, New frmWizard3, New frmWizard4, New frmSummary}
    Private currentStep As Integer = 0
    Private allTheCruises As New CruiseCollection
    Private usersSelections As New Cruise

    Public ReadOnly Property AllCruises As CruiseCollection
        Get
            Return allTheCruises
        End Get
    End Property

    Public Property UserSelections As Cruise
        Get
            Return usersSelections
        End Get
        Set(value As Cruise)
            usersSelections = value
        End Set
    End Property

    Private Function CheckWeights() As Boolean
        If CSng(txtNumPassengers.Text) + CSng(txtRegion.Text) + CSng(txtFormal.Text) + CSng(txtAge.Text) = 100 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        If Not (IsNumeric(txtNumPassengers.Text) AndAlso IsNumeric(txtAge.Text) AndAlso IsNumeric(txtFormal.Text) AndAlso IsNumeric(txtRegion.Text)) Then
            Return
        End If

        If Not CheckWeights() Then
            lblWeights.ForeColor = Color.Red
            Return
        End If

        Cruise.SetWeights(CSng(txtNumPassengers.Text), CSng(txtRegion.Text), CSng(txtFormal.Text), CSng(txtAge.Text))
        currentStep += 1
        With wizardforms(currentStep)
            .Show()
        End With
    End Sub


    Private Sub txtNumPassengers_TextChanged(sender As Object, e As EventArgs) Handles txtNumPassengers.TextChanged
        If IsNumeric(txtNumPassengers.Text) Then
            errProvider.SetError(sender, "")
        Else
            errProvider.SetError(sender, "Input must be numeric!")
        End If
    End Sub

    Private Sub txtRegion_TextChanged(sender As Object, e As EventArgs) Handles txtRegion.TextChanged
        If IsNumeric(txtRegion.Text) Then
            errProvider.SetError(sender, "")
        Else
            errProvider.SetError(sender, "Input must be numeric!")
        End If
    End Sub

    Private Sub txtFormal_TextChanged(sender As Object, e As EventArgs) Handles txtFormal.TextChanged
        If IsNumeric(txtFormal.Text) Then
            errProvider.SetError(sender, "")
        Else
            errProvider.SetError(sender, "Input must be numeric!")
        End If
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        If IsNumeric(txtAge.Text) Then
            errProvider.SetError(sender, "")
        Else
            errProvider.SetError(sender, "Input must be numeric!")
        End If
    End Sub


    Public Sub NextStep()
        Dim top As Integer = wizardForms(currentStep).Top
        Dim left As Integer = wizardForms(currentStep).Left

        wizardForms(currentStep).Hide()
        currentStep += 1

        With wizardForms(currentStep)
            .Top = top
            .Left = left
            .Show()
        End With
    End Sub

    Public Sub PreviousStep()
        Dim top As Integer = wizardForms(currentStep).Top
        Dim left As Integer = wizardForms(currentStep).Left

        wizardForms(currentStep).Hide()

        If currentStep > 0 Then
            currentStep -= 1
        End If

        If currentStep > 0 Then
            With wizardForms(currentStep)
                .Top = top
                .Left = left
                .Show()
            End With
        End If
    End Sub



    Public Sub ClearStep()
        currentStep = 0
    End Sub






















End Class
