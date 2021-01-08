Public Class FORM1
    Private Sub FORM1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged

    End Sub

    Private Sub txtMonthlyIntRate_TextChanged(sender As Object, e As EventArgs) Handles txtMonthlyIntRate.TextChanged


    End Sub

    Private Sub txtAnnualIntRate_TextChanged(sender As Object, e As EventArgs) Handles txtAnnualIntRate.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtMonthlyIntRate.Text = (txtAnnualIntRate.Text / 12).ToString("#.##") * 10.0
        txtPayment.Text = (txtPrincipal.Text * (txtMonthlyIntRate.Text * (1 + txtMonthlyIntRate.Text) ^ (txtYears.Text * 12))) / ((1 + txtMonthlyIntRate.Text) ^ ((txtYears.Text * 12) - 1))
        'txtSimpleIntRate.Text = (txtPrincipal.Text * ((1 + txtMonthlyIntRate.Text) ^ (txtYears.Text * 12)) - txtPayment.Text) \ (txtMonthlyIntRate.Text((1 + txtMonthlyIntRate.Text) ^ (txtYears.Text * 12) - 1))
        'Payments For Schedule 15 years
        txt15x2.Text = (txtPrincipal.Text * (lbl2Percent.Text * (1 + lbl2Percent.Text) ^ (lbl15Years.Text * 12))) / ((1 + lbl2Percent.Text) ^ ((lbl15Years.Text * 12) - 1))
        txt15x3.Text = (txtPrincipal.Text * (lbl3Percent.Text * (1 + lbl3Percent.Text) ^ (lbl15Years.Text * 12))) / ((1 + lbl3Percent.Text) ^ ((lbl15Years.Text * 12) - 1))
        txt15x4.Text = (txtPrincipal.Text * (lbl4Percent.Text * (1 + lbl4Percent.Text) ^ (lbl15Years.Text * 12))) / ((1 + lbl4Percent.Text) ^ ((lbl15Years.Text * 12) - 1))
        txt15x5.Text = (txtPrincipal.Text * (lbl5Percent.Text * (1 + lbl5Percent.Text) ^ (lbl15Years.Text * 12))) / ((1 + lbl5Percent.Text) ^ ((lbl15Years.Text * 12) - 1))
        txt15x6.Text = (txtPrincipal.Text * (lbl6Percent.Text * (1 + lbl6Percent.Text) ^ (lbl15Years.Text * 12))) / ((1 + lbl6Percent.Text) ^ ((lbl15Years.Text * 12) - 1))
        txt15x7.Text = (txtPrincipal.Text * (lbl7Percent.Text * (1 + lbl7Percent.Text) ^ (lbl15Years.Text * 12))) / ((1 + lbl7Percent.Text) ^ ((lbl15Years.Text * 12) - 1))
        txt15x8.Text = (txtPrincipal.Text * (lbl8Percent.Text * (1 + lbl8Percent.Text) ^ (lbl15Years.Text * 12))) / ((1 + lbl8Percent.Text) ^ ((lbl15Years.Text * 12) - 1))
        'Payments For Schedule 20 years
        txt20x2.Text = (txtPrincipal.Text * (lbl2Percent.Text * (1 + lbl2Percent.Text) ^ (lbl20Years.Text * 12))) / ((1 + lbl2Percent.Text) ^ ((lbl20Years.Text * 12) - 1))
        txt20x3.Text = (txtPrincipal.Text * (lbl3Percent.Text * (1 + lbl3Percent.Text) ^ (lbl20Years.Text * 12))) / ((1 + lbl3Percent.Text) ^ ((lbl20Years.Text * 12) - 1))
        txt20x4.Text = (txtPrincipal.Text * (lbl4Percent.Text * (1 + lbl4Percent.Text) ^ (lbl20Years.Text * 12))) / ((1 + lbl4Percent.Text) ^ ((lbl20Years.Text * 12) - 1))
        txt20x5.Text = (txtPrincipal.Text * (lbl5Percent.Text * (1 + lbl5Percent.Text) ^ (lbl20Years.Text * 12))) / ((1 + lbl5Percent.Text) ^ ((lbl20Years.Text * 12) - 1))
        txt20x6.Text = (txtPrincipal.Text * (lbl6Percent.Text * (1 + lbl6Percent.Text) ^ (lbl20Years.Text * 12))) / ((1 + lbl6Percent.Text) ^ ((lbl20Years.Text * 12) - 1))
        txt20x7.Text = (txtPrincipal.Text * (lbl7Percent.Text * (1 + lbl7Percent.Text) ^ (lbl20Years.Text * 12))) / ((1 + lbl7Percent.Text) ^ ((lbl20Years.Text * 12) - 1))
        txt20x8.Text = (txtPrincipal.Text * (lbl8Percent.Text * (1 + lbl8Percent.Text) ^ (lbl20Years.Text * 12))) / ((1 + lbl8Percent.Text) ^ ((lbl20Years.Text * 12) - 1))
        'Payments For Schedule 25 years
        txt25x2.Text = (txtPrincipal.Text * (lbl2Percent.Text * (1 + lbl2Percent.Text) ^ (lbl25Years.Text * 12))) / ((1 + lbl2Percent.Text) ^ ((lbl25Years.Text * 12) - 1))
        txt25x3.Text = (txtPrincipal.Text * (lbl3Percent.Text * (1 + lbl3Percent.Text) ^ (lbl25Years.Text * 12))) / ((1 + lbl3Percent.Text) ^ ((lbl25Years.Text * 12) - 1))
        txt25x4.Text = (txtPrincipal.Text * (lbl4Percent.Text * (1 + lbl4Percent.Text) ^ (lbl25Years.Text * 12))) / ((1 + lbl4Percent.Text) ^ ((lbl25Years.Text * 12) - 1))
        txt25x5.Text = (txtPrincipal.Text * (lbl5Percent.Text * (1 + lbl5Percent.Text) ^ (lbl25Years.Text * 12))) / ((1 + lbl5Percent.Text) ^ ((lbl25Years.Text * 12) - 1))
        txt25x6.Text = (txtPrincipal.Text * (lbl6Percent.Text * (1 + lbl6Percent.Text) ^ (lbl25Years.Text * 12))) / ((1 + lbl6Percent.Text) ^ ((lbl25Years.Text * 12) - 1))
        txt25x7.Text = (txtPrincipal.Text * (lbl7Percent.Text * (1 + lbl7Percent.Text) ^ (lbl25Years.Text * 12))) / ((1 + lbl7Percent.Text) ^ ((lbl25Years.Text * 12) - 1))
        txt25x8.Text = (txtPrincipal.Text * (lbl8Percent.Text * (1 + lbl8Percent.Text) ^ (lbl25Years.Text * 12))) / ((1 + lbl8Percent.Text) ^ ((lbl25Years.Text * 12) - 1))
        'Payments For Schedule 30 years
        txt30x2.Text = (txtPrincipal.Text * (lbl2Percent.Text * (1 + lbl2Percent.Text) ^ (lbl30Years.Text * 12))) / ((1 + lbl2Percent.Text) ^ ((lbl30Years.Text * 12) - 1))
        txt30x3.Text = (txtPrincipal.Text * (lbl3Percent.Text * (1 + lbl3Percent.Text) ^ (lbl30Years.Text * 12))) / ((1 + lbl3Percent.Text) ^ ((lbl30Years.Text * 12) - 1))
        txt30x4.Text = (txtPrincipal.Text * (lbl4Percent.Text * (1 + lbl4Percent.Text) ^ (lbl30Years.Text * 12))) / ((1 + lbl4Percent.Text) ^ ((lbl30Years.Text * 12) - 1))
        txt30x5.Text = (txtPrincipal.Text * (lbl5Percent.Text * (1 + lbl5Percent.Text) ^ (lbl30Years.Text * 12))) / ((1 + lbl5Percent.Text) ^ ((lbl30Years.Text * 12) - 1))
        txt30x6.Text = (txtPrincipal.Text * (lbl6Percent.Text * (1 + lbl6Percent.Text) ^ (lbl30Years.Text * 12))) / ((1 + lbl6Percent.Text) ^ ((lbl30Years.Text * 12) - 1))
        txt30x7.Text = (txtPrincipal.Text * (lbl7Percent.Text * (1 + lbl7Percent.Text) ^ (lbl30Years.Text * 12))) / ((1 + lbl7Percent.Text) ^ ((lbl30Years.Text * 12) - 1))
        txt30x8.Text = (txtPrincipal.Text * (lbl8Percent.Text * (1 + lbl8Percent.Text) ^ (lbl30Years.Text * 12))) / ((1 + lbl8Percent.Text) ^ ((lbl30Years.Text * 12) - 1))



    End Sub

    Private Sub lblLoanAmount_Click(sender As Object, e As EventArgs) Handles lblPrincipal.Click

    End Sub

    Private Sub txtPrincipal_TextChanged(sender As Object, e As EventArgs) Handles txtPrincipal.TextChanged

    End Sub

    Private Sub lblSimpleInt_Click(sender As Object, e As EventArgs) Handles lblSimpleInt.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
