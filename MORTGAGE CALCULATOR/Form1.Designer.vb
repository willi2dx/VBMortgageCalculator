<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTopTitle = New System.Windows.Forms.Label()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.lblANNUALINTERESTRATE = New System.Windows.Forms.Label()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtAnnualIntRate = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.lblMonthlyIntRate = New System.Windows.Forms.Label()
        Me.txtMonthlyIntRate = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSimpleInt = New System.Windows.Forms.Label()
        Me.txtSimpleIntRate = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.lblSign1 = New System.Windows.Forms.Label()
        Me.lblSign2 = New System.Windows.Forms.Label()
        Me.lblSign3 = New System.Windows.Forms.Label()
        Me.lblSign4 = New System.Windows.Forms.Label()
        Me.lblSign5 = New System.Windows.Forms.Label()
        Me.lblBottomTitle = New System.Windows.Forms.Label()
        Me.lblSideTitle = New System.Windows.Forms.Label()
        Me.lbl15Years = New System.Windows.Forms.Label()
        Me.lbl20Years = New System.Windows.Forms.Label()
        Me.lbl25Years = New System.Windows.Forms.Label()
        Me.lbl30Years = New System.Windows.Forms.Label()
        Me.lbl2Percent = New System.Windows.Forms.Label()
        Me.lbl3Percent = New System.Windows.Forms.Label()
        Me.lbl4Percent = New System.Windows.Forms.Label()
        Me.lbl5Percent = New System.Windows.Forms.Label()
        Me.lbl6Percent = New System.Windows.Forms.Label()
        Me.lbl7Percent = New System.Windows.Forms.Label()
        Me.lbl8Percent = New System.Windows.Forms.Label()
        Me.txt15x2 = New System.Windows.Forms.TextBox()
        Me.txt15x3 = New System.Windows.Forms.TextBox()
        Me.txt15x4 = New System.Windows.Forms.TextBox()
        Me.txt15x5 = New System.Windows.Forms.TextBox()
        Me.txt15x6 = New System.Windows.Forms.TextBox()
        Me.txt15x7 = New System.Windows.Forms.TextBox()
        Me.txt15x8 = New System.Windows.Forms.TextBox()
        Me.txt20x2 = New System.Windows.Forms.TextBox()
        Me.txt20x3 = New System.Windows.Forms.TextBox()
        Me.txt20x4 = New System.Windows.Forms.TextBox()
        Me.txt20x5 = New System.Windows.Forms.TextBox()
        Me.txt20x6 = New System.Windows.Forms.TextBox()
        Me.txt20x7 = New System.Windows.Forms.TextBox()
        Me.txt20x8 = New System.Windows.Forms.TextBox()
        Me.txt25x2 = New System.Windows.Forms.TextBox()
        Me.txt25x3 = New System.Windows.Forms.TextBox()
        Me.txt25x4 = New System.Windows.Forms.TextBox()
        Me.txt25x5 = New System.Windows.Forms.TextBox()
        Me.txt25x6 = New System.Windows.Forms.TextBox()
        Me.txt25x7 = New System.Windows.Forms.TextBox()
        Me.txt25x8 = New System.Windows.Forms.TextBox()
        Me.txt30x2 = New System.Windows.Forms.TextBox()
        Me.txt30x3 = New System.Windows.Forms.TextBox()
        Me.txt30x4 = New System.Windows.Forms.TextBox()
        Me.txt30x5 = New System.Windows.Forms.TextBox()
        Me.txt30x6 = New System.Windows.Forms.TextBox()
        Me.txt30x7 = New System.Windows.Forms.TextBox()
        Me.txt30x8 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTopTitle
        '
        Me.lblTopTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTopTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopTitle.Location = New System.Drawing.Point(163, 9)
        Me.lblTopTitle.Name = "lblTopTitle"
        Me.lblTopTitle.Size = New System.Drawing.Size(778, 50)
        Me.lblTopTitle.TabIndex = 0
        Me.lblTopTitle.Text = "MORTGAGE CALCULATOR"
        Me.lblTopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrincipal
        '
        Me.lblPrincipal.BackColor = System.Drawing.Color.DarkGray
        Me.lblPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrincipal.Location = New System.Drawing.Point(163, 80)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(341, 50)
        Me.lblPrincipal.TabIndex = 1
        Me.lblPrincipal.Text = "PRINCIPAL"
        Me.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblANNUALINTERESTRATE
        '
        Me.lblANNUALINTERESTRATE.BackColor = System.Drawing.Color.DarkGray
        Me.lblANNUALINTERESTRATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblANNUALINTERESTRATE.Location = New System.Drawing.Point(163, 130)
        Me.lblANNUALINTERESTRATE.Name = "lblANNUALINTERESTRATE"
        Me.lblANNUALINTERESTRATE.Size = New System.Drawing.Size(341, 50)
        Me.lblANNUALINTERESTRATE.TabIndex = 2
        Me.lblANNUALINTERESTRATE.Text = "ANNUAL INTEREST RATE"
        Me.lblANNUALINTERESTRATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.BackColor = System.Drawing.Color.DarkGray
        Me.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(163, 330)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(341, 50)
        Me.lblMonthlyPayment.TabIndex = 3
        Me.lblMonthlyPayment.Text = "MONTHLY PAYMENT"
        Me.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrincipal
        '
        Me.txtPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrincipal.Location = New System.Drawing.Point(600, 81)
        Me.txtPrincipal.Multiline = True
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(341, 49)
        Me.txtPrincipal.TabIndex = 4
        Me.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAnnualIntRate
        '
        Me.txtAnnualIntRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnnualIntRate.Location = New System.Drawing.Point(600, 130)
        Me.txtAnnualIntRate.Multiline = True
        Me.txtAnnualIntRate.Name = "txtAnnualIntRate"
        Me.txtAnnualIntRate.Size = New System.Drawing.Size(341, 49)
        Me.txtAnnualIntRate.TabIndex = 5
        Me.txtAnnualIntRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.Color.DarkGray
        Me.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPayment.Location = New System.Drawing.Point(600, 330)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(341, 49)
        Me.txtPayment.TabIndex = 14
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMonthlyIntRate
        '
        Me.lblMonthlyIntRate.BackColor = System.Drawing.Color.DarkGray
        Me.lblMonthlyIntRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyIntRate.Location = New System.Drawing.Point(163, 280)
        Me.lblMonthlyIntRate.Name = "lblMonthlyIntRate"
        Me.lblMonthlyIntRate.Size = New System.Drawing.Size(341, 50)
        Me.lblMonthlyIntRate.TabIndex = 9
        Me.lblMonthlyIntRate.Text = "MONTHLY INTEREST RATE"
        Me.lblMonthlyIntRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMonthlyIntRate
        '
        Me.txtMonthlyIntRate.BackColor = System.Drawing.Color.DarkGray
        Me.txtMonthlyIntRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonthlyIntRate.Location = New System.Drawing.Point(600, 280)
        Me.txtMonthlyIntRate.Multiline = True
        Me.txtMonthlyIntRate.Name = "txtMonthlyIntRate"
        Me.txtMonthlyIntRate.Size = New System.Drawing.Size(341, 49)
        Me.txtMonthlyIntRate.TabIndex = 8
        Me.txtMonthlyIntRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCalculate.Location = New System.Drawing.Point(377, 385)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(341, 50)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnExit.Location = New System.Drawing.Point(377, 999)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(341, 50)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "&EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblSimpleInt
        '
        Me.lblSimpleInt.BackColor = System.Drawing.Color.DarkGray
        Me.lblSimpleInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSimpleInt.Location = New System.Drawing.Point(163, 230)
        Me.lblSimpleInt.Name = "lblSimpleInt"
        Me.lblSimpleInt.Size = New System.Drawing.Size(341, 50)
        Me.lblSimpleInt.TabIndex = 11
        Me.lblSimpleInt.Text = "TOTAL PAID (SIMPLE INTEREST)"
        Me.lblSimpleInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSimpleIntRate
        '
        Me.txtSimpleIntRate.BackColor = System.Drawing.Color.DarkGray
        Me.txtSimpleIntRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSimpleIntRate.Location = New System.Drawing.Point(600, 230)
        Me.txtSimpleIntRate.Multiline = True
        Me.txtSimpleIntRate.Name = "txtSimpleIntRate"
        Me.txtSimpleIntRate.Size = New System.Drawing.Size(341, 49)
        Me.txtSimpleIntRate.TabIndex = 12
        Me.txtSimpleIntRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.DarkGray
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Location = New System.Drawing.Point(163, 180)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(341, 50)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "NUMBER OF YEARS"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtYears
        '
        Me.txtYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYears.Location = New System.Drawing.Point(600, 180)
        Me.txtYears.Multiline = True
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(341, 49)
        Me.txtYears.TabIndex = 6
        Me.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSign1
        '
        Me.lblSign1.BackColor = System.Drawing.Color.DarkGray
        Me.lblSign1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSign1.Location = New System.Drawing.Point(547, 81)
        Me.lblSign1.Name = "lblSign1"
        Me.lblSign1.Size = New System.Drawing.Size(47, 50)
        Me.lblSign1.TabIndex = 15
        Me.lblSign1.Text = "$"
        Me.lblSign1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSign2
        '
        Me.lblSign2.BackColor = System.Drawing.Color.DarkGray
        Me.lblSign2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSign2.Location = New System.Drawing.Point(547, 229)
        Me.lblSign2.Name = "lblSign2"
        Me.lblSign2.Size = New System.Drawing.Size(47, 50)
        Me.lblSign2.TabIndex = 16
        Me.lblSign2.Text = "$"
        Me.lblSign2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSign3
        '
        Me.lblSign3.BackColor = System.Drawing.Color.DarkGray
        Me.lblSign3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSign3.Location = New System.Drawing.Point(947, 130)
        Me.lblSign3.Name = "lblSign3"
        Me.lblSign3.Size = New System.Drawing.Size(47, 50)
        Me.lblSign3.TabIndex = 17
        Me.lblSign3.Text = "%"
        Me.lblSign3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSign4
        '
        Me.lblSign4.BackColor = System.Drawing.Color.DarkGray
        Me.lblSign4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSign4.Location = New System.Drawing.Point(947, 280)
        Me.lblSign4.Name = "lblSign4"
        Me.lblSign4.Size = New System.Drawing.Size(47, 50)
        Me.lblSign4.TabIndex = 18
        Me.lblSign4.Text = "%"
        Me.lblSign4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSign5
        '
        Me.lblSign5.BackColor = System.Drawing.Color.DarkGray
        Me.lblSign5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSign5.Location = New System.Drawing.Point(547, 330)
        Me.lblSign5.Name = "lblSign5"
        Me.lblSign5.Size = New System.Drawing.Size(47, 50)
        Me.lblSign5.TabIndex = 19
        Me.lblSign5.Text = "$"
        Me.lblSign5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBottomTitle
        '
        Me.lblBottomTitle.BackColor = System.Drawing.Color.Gray
        Me.lblBottomTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBottomTitle.Location = New System.Drawing.Point(163, 438)
        Me.lblBottomTitle.Name = "lblBottomTitle"
        Me.lblBottomTitle.Size = New System.Drawing.Size(778, 50)
        Me.lblBottomTitle.TabIndex = 20
        Me.lblBottomTitle.Text = "MORTGAGE TABLE"
        Me.lblBottomTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSideTitle
        '
        Me.lblSideTitle.BackColor = System.Drawing.Color.DarkGray
        Me.lblSideTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSideTitle.Location = New System.Drawing.Point(12, 503)
        Me.lblSideTitle.Name = "lblSideTitle"
        Me.lblSideTitle.Size = New System.Drawing.Size(145, 50)
        Me.lblSideTitle.TabIndex = 21
        Me.lblSideTitle.Text = "YEARS ► RATES (%) ▼"
        Me.lblSideTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl15Years
        '
        Me.lbl15Years.BackColor = System.Drawing.Color.DarkGray
        Me.lbl15Years.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl15Years.Location = New System.Drawing.Point(163, 503)
        Me.lbl15Years.Name = "lbl15Years"
        Me.lbl15Years.Size = New System.Drawing.Size(191, 50)
        Me.lbl15Years.TabIndex = 22
        Me.lbl15Years.Text = "15"
        Me.lbl15Years.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl20Years
        '
        Me.lbl20Years.BackColor = System.Drawing.Color.DarkGray
        Me.lbl20Years.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl20Years.Location = New System.Drawing.Point(360, 503)
        Me.lbl20Years.Name = "lbl20Years"
        Me.lbl20Years.Size = New System.Drawing.Size(195, 50)
        Me.lbl20Years.TabIndex = 23
        Me.lbl20Years.Text = "20"
        Me.lbl20Years.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl25Years
        '
        Me.lbl25Years.BackColor = System.Drawing.Color.DarkGray
        Me.lbl25Years.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl25Years.Location = New System.Drawing.Point(561, 503)
        Me.lbl25Years.Name = "lbl25Years"
        Me.lbl25Years.Size = New System.Drawing.Size(192, 50)
        Me.lbl25Years.TabIndex = 24
        Me.lbl25Years.Text = "25"
        Me.lbl25Years.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl30Years
        '
        Me.lbl30Years.BackColor = System.Drawing.Color.DarkGray
        Me.lbl30Years.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl30Years.Location = New System.Drawing.Point(759, 503)
        Me.lbl30Years.Name = "lbl30Years"
        Me.lbl30Years.Size = New System.Drawing.Size(182, 50)
        Me.lbl30Years.TabIndex = 30
        Me.lbl30Years.Text = "30"
        Me.lbl30Years.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2Percent
        '
        Me.lbl2Percent.BackColor = System.Drawing.Color.DarkGray
        Me.lbl2Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2Percent.Location = New System.Drawing.Point(12, 562)
        Me.lbl2Percent.Name = "lbl2Percent"
        Me.lbl2Percent.Size = New System.Drawing.Size(145, 50)
        Me.lbl2Percent.TabIndex = 31
        Me.lbl2Percent.Text = "2"
        Me.lbl2Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3Percent
        '
        Me.lbl3Percent.BackColor = System.Drawing.Color.DarkGray
        Me.lbl3Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3Percent.Location = New System.Drawing.Point(12, 622)
        Me.lbl3Percent.Name = "lbl3Percent"
        Me.lbl3Percent.Size = New System.Drawing.Size(145, 50)
        Me.lbl3Percent.TabIndex = 32
        Me.lbl3Percent.Text = "3"
        Me.lbl3Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4Percent
        '
        Me.lbl4Percent.BackColor = System.Drawing.Color.DarkGray
        Me.lbl4Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4Percent.Location = New System.Drawing.Point(12, 683)
        Me.lbl4Percent.Name = "lbl4Percent"
        Me.lbl4Percent.Size = New System.Drawing.Size(145, 50)
        Me.lbl4Percent.TabIndex = 33
        Me.lbl4Percent.Text = "4"
        Me.lbl4Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5Percent
        '
        Me.lbl5Percent.BackColor = System.Drawing.Color.DarkGray
        Me.lbl5Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5Percent.Location = New System.Drawing.Point(12, 743)
        Me.lbl5Percent.Name = "lbl5Percent"
        Me.lbl5Percent.Size = New System.Drawing.Size(145, 50)
        Me.lbl5Percent.TabIndex = 34
        Me.lbl5Percent.Text = "5"
        Me.lbl5Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6Percent
        '
        Me.lbl6Percent.BackColor = System.Drawing.Color.DarkGray
        Me.lbl6Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl6Percent.Location = New System.Drawing.Point(12, 803)
        Me.lbl6Percent.Name = "lbl6Percent"
        Me.lbl6Percent.Size = New System.Drawing.Size(145, 50)
        Me.lbl6Percent.TabIndex = 35
        Me.lbl6Percent.Text = "6"
        Me.lbl6Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl7Percent
        '
        Me.lbl7Percent.BackColor = System.Drawing.Color.DarkGray
        Me.lbl7Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl7Percent.Location = New System.Drawing.Point(12, 863)
        Me.lbl7Percent.Name = "lbl7Percent"
        Me.lbl7Percent.Size = New System.Drawing.Size(145, 50)
        Me.lbl7Percent.TabIndex = 36
        Me.lbl7Percent.Text = "7"
        Me.lbl7Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl8Percent
        '
        Me.lbl8Percent.BackColor = System.Drawing.Color.DarkGray
        Me.lbl8Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl8Percent.Location = New System.Drawing.Point(12, 926)
        Me.lbl8Percent.Name = "lbl8Percent"
        Me.lbl8Percent.Size = New System.Drawing.Size(145, 50)
        Me.lbl8Percent.TabIndex = 37
        Me.lbl8Percent.Text = "8"
        Me.lbl8Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt15x2
        '
        Me.txt15x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt15x2.Location = New System.Drawing.Point(163, 563)
        Me.txt15x2.Multiline = True
        Me.txt15x2.Name = "txt15x2"
        Me.txt15x2.Size = New System.Drawing.Size(191, 49)
        Me.txt15x2.TabIndex = 38
        Me.txt15x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt15x3
        '
        Me.txt15x3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt15x3.Location = New System.Drawing.Point(163, 622)
        Me.txt15x3.Multiline = True
        Me.txt15x3.Name = "txt15x3"
        Me.txt15x3.Size = New System.Drawing.Size(191, 49)
        Me.txt15x3.TabIndex = 39
        Me.txt15x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt15x4
        '
        Me.txt15x4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt15x4.Location = New System.Drawing.Point(163, 683)
        Me.txt15x4.Multiline = True
        Me.txt15x4.Name = "txt15x4"
        Me.txt15x4.Size = New System.Drawing.Size(191, 49)
        Me.txt15x4.TabIndex = 40
        Me.txt15x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt15x5
        '
        Me.txt15x5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt15x5.Location = New System.Drawing.Point(163, 744)
        Me.txt15x5.Multiline = True
        Me.txt15x5.Name = "txt15x5"
        Me.txt15x5.Size = New System.Drawing.Size(191, 49)
        Me.txt15x5.TabIndex = 41
        Me.txt15x5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt15x6
        '
        Me.txt15x6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt15x6.Location = New System.Drawing.Point(163, 799)
        Me.txt15x6.Multiline = True
        Me.txt15x6.Name = "txt15x6"
        Me.txt15x6.Size = New System.Drawing.Size(191, 54)
        Me.txt15x6.TabIndex = 42
        Me.txt15x6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt15x7
        '
        Me.txt15x7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt15x7.Location = New System.Drawing.Point(163, 863)
        Me.txt15x7.Multiline = True
        Me.txt15x7.Name = "txt15x7"
        Me.txt15x7.Size = New System.Drawing.Size(191, 50)
        Me.txt15x7.TabIndex = 43
        Me.txt15x7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt15x8
        '
        Me.txt15x8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt15x8.Location = New System.Drawing.Point(163, 926)
        Me.txt15x8.Multiline = True
        Me.txt15x8.Name = "txt15x8"
        Me.txt15x8.Size = New System.Drawing.Size(191, 50)
        Me.txt15x8.TabIndex = 44
        Me.txt15x8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt20x2
        '
        Me.txt20x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20x2.Location = New System.Drawing.Point(360, 562)
        Me.txt20x2.Multiline = True
        Me.txt20x2.Name = "txt20x2"
        Me.txt20x2.Size = New System.Drawing.Size(191, 49)
        Me.txt20x2.TabIndex = 45
        Me.txt20x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt20x3
        '
        Me.txt20x3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20x3.Location = New System.Drawing.Point(360, 623)
        Me.txt20x3.Multiline = True
        Me.txt20x3.Name = "txt20x3"
        Me.txt20x3.Size = New System.Drawing.Size(191, 49)
        Me.txt20x3.TabIndex = 46
        Me.txt20x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt20x4
        '
        Me.txt20x4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20x4.Location = New System.Drawing.Point(360, 683)
        Me.txt20x4.Multiline = True
        Me.txt20x4.Name = "txt20x4"
        Me.txt20x4.Size = New System.Drawing.Size(191, 49)
        Me.txt20x4.TabIndex = 47
        Me.txt20x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt20x5
        '
        Me.txt20x5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20x5.Location = New System.Drawing.Point(360, 743)
        Me.txt20x5.Multiline = True
        Me.txt20x5.Name = "txt20x5"
        Me.txt20x5.Size = New System.Drawing.Size(191, 49)
        Me.txt20x5.TabIndex = 48
        Me.txt20x5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt20x6
        '
        Me.txt20x6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20x6.Location = New System.Drawing.Point(360, 803)
        Me.txt20x6.Multiline = True
        Me.txt20x6.Name = "txt20x6"
        Me.txt20x6.Size = New System.Drawing.Size(191, 49)
        Me.txt20x6.TabIndex = 49
        Me.txt20x6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt20x7
        '
        Me.txt20x7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20x7.Location = New System.Drawing.Point(360, 864)
        Me.txt20x7.Multiline = True
        Me.txt20x7.Name = "txt20x7"
        Me.txt20x7.Size = New System.Drawing.Size(191, 49)
        Me.txt20x7.TabIndex = 50
        Me.txt20x7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt20x8
        '
        Me.txt20x8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20x8.Location = New System.Drawing.Point(360, 926)
        Me.txt20x8.Multiline = True
        Me.txt20x8.Name = "txt20x8"
        Me.txt20x8.Size = New System.Drawing.Size(191, 49)
        Me.txt20x8.TabIndex = 51
        Me.txt20x8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt25x2
        '
        Me.txt25x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt25x2.Location = New System.Drawing.Point(561, 563)
        Me.txt25x2.Multiline = True
        Me.txt25x2.Name = "txt25x2"
        Me.txt25x2.Size = New System.Drawing.Size(191, 49)
        Me.txt25x2.TabIndex = 52
        Me.txt25x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt25x3
        '
        Me.txt25x3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt25x3.Location = New System.Drawing.Point(562, 622)
        Me.txt25x3.Multiline = True
        Me.txt25x3.Name = "txt25x3"
        Me.txt25x3.Size = New System.Drawing.Size(191, 49)
        Me.txt25x3.TabIndex = 53
        Me.txt25x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt25x4
        '
        Me.txt25x4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt25x4.Location = New System.Drawing.Point(562, 683)
        Me.txt25x4.Multiline = True
        Me.txt25x4.Name = "txt25x4"
        Me.txt25x4.Size = New System.Drawing.Size(191, 49)
        Me.txt25x4.TabIndex = 54
        Me.txt25x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt25x5
        '
        Me.txt25x5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt25x5.Location = New System.Drawing.Point(562, 744)
        Me.txt25x5.Multiline = True
        Me.txt25x5.Name = "txt25x5"
        Me.txt25x5.Size = New System.Drawing.Size(191, 49)
        Me.txt25x5.TabIndex = 55
        Me.txt25x5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt25x6
        '
        Me.txt25x6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt25x6.Location = New System.Drawing.Point(562, 804)
        Me.txt25x6.Multiline = True
        Me.txt25x6.Name = "txt25x6"
        Me.txt25x6.Size = New System.Drawing.Size(191, 49)
        Me.txt25x6.TabIndex = 56
        Me.txt25x6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt25x7
        '
        Me.txt25x7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt25x7.Location = New System.Drawing.Point(557, 864)
        Me.txt25x7.Multiline = True
        Me.txt25x7.Name = "txt25x7"
        Me.txt25x7.Size = New System.Drawing.Size(191, 49)
        Me.txt25x7.TabIndex = 57
        Me.txt25x7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt25x8
        '
        Me.txt25x8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt25x8.Location = New System.Drawing.Point(557, 926)
        Me.txt25x8.Multiline = True
        Me.txt25x8.Name = "txt25x8"
        Me.txt25x8.Size = New System.Drawing.Size(191, 49)
        Me.txt25x8.TabIndex = 58
        Me.txt25x8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt30x2
        '
        Me.txt30x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt30x2.Location = New System.Drawing.Point(758, 563)
        Me.txt30x2.Multiline = True
        Me.txt30x2.Name = "txt30x2"
        Me.txt30x2.Size = New System.Drawing.Size(191, 49)
        Me.txt30x2.TabIndex = 59
        Me.txt30x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt30x3
        '
        Me.txt30x3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt30x3.Location = New System.Drawing.Point(759, 623)
        Me.txt30x3.Multiline = True
        Me.txt30x3.Name = "txt30x3"
        Me.txt30x3.Size = New System.Drawing.Size(190, 49)
        Me.txt30x3.TabIndex = 60
        Me.txt30x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt30x4
        '
        Me.txt30x4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt30x4.Location = New System.Drawing.Point(759, 684)
        Me.txt30x4.Multiline = True
        Me.txt30x4.Name = "txt30x4"
        Me.txt30x4.Size = New System.Drawing.Size(191, 49)
        Me.txt30x4.TabIndex = 61
        Me.txt30x4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt30x5
        '
        Me.txt30x5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt30x5.Location = New System.Drawing.Point(759, 744)
        Me.txt30x5.Multiline = True
        Me.txt30x5.Name = "txt30x5"
        Me.txt30x5.Size = New System.Drawing.Size(191, 49)
        Me.txt30x5.TabIndex = 62
        Me.txt30x5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt30x6
        '
        Me.txt30x6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt30x6.Location = New System.Drawing.Point(759, 804)
        Me.txt30x6.Multiline = True
        Me.txt30x6.Name = "txt30x6"
        Me.txt30x6.Size = New System.Drawing.Size(191, 49)
        Me.txt30x6.TabIndex = 63
        Me.txt30x6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt30x7
        '
        Me.txt30x7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt30x7.Location = New System.Drawing.Point(758, 864)
        Me.txt30x7.Multiline = True
        Me.txt30x7.Name = "txt30x7"
        Me.txt30x7.Size = New System.Drawing.Size(191, 49)
        Me.txt30x7.TabIndex = 64
        Me.txt30x7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt30x8
        '
        Me.txt30x8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt30x8.Location = New System.Drawing.Point(759, 927)
        Me.txt30x8.Multiline = True
        Me.txt30x8.Name = "txt30x8"
        Me.txt30x8.Size = New System.Drawing.Size(191, 49)
        Me.txt30x8.TabIndex = 65
        Me.txt30x8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FORM1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1084, 1061)
        Me.Controls.Add(Me.txt30x8)
        Me.Controls.Add(Me.txt30x7)
        Me.Controls.Add(Me.txt30x6)
        Me.Controls.Add(Me.txt30x5)
        Me.Controls.Add(Me.txt30x4)
        Me.Controls.Add(Me.txt30x3)
        Me.Controls.Add(Me.txt30x2)
        Me.Controls.Add(Me.txt25x8)
        Me.Controls.Add(Me.txt25x7)
        Me.Controls.Add(Me.txt25x6)
        Me.Controls.Add(Me.txt25x5)
        Me.Controls.Add(Me.txt25x4)
        Me.Controls.Add(Me.txt25x3)
        Me.Controls.Add(Me.txt25x2)
        Me.Controls.Add(Me.txt20x8)
        Me.Controls.Add(Me.txt20x7)
        Me.Controls.Add(Me.txt20x6)
        Me.Controls.Add(Me.txt20x5)
        Me.Controls.Add(Me.txt20x4)
        Me.Controls.Add(Me.txt20x3)
        Me.Controls.Add(Me.txt20x2)
        Me.Controls.Add(Me.txt15x8)
        Me.Controls.Add(Me.txt15x7)
        Me.Controls.Add(Me.txt15x6)
        Me.Controls.Add(Me.txt15x5)
        Me.Controls.Add(Me.txt15x4)
        Me.Controls.Add(Me.txt15x3)
        Me.Controls.Add(Me.txt15x2)
        Me.Controls.Add(Me.lbl8Percent)
        Me.Controls.Add(Me.lbl7Percent)
        Me.Controls.Add(Me.lbl6Percent)
        Me.Controls.Add(Me.lbl5Percent)
        Me.Controls.Add(Me.lbl4Percent)
        Me.Controls.Add(Me.lbl3Percent)
        Me.Controls.Add(Me.lbl2Percent)
        Me.Controls.Add(Me.lbl30Years)
        Me.Controls.Add(Me.lbl25Years)
        Me.Controls.Add(Me.lbl20Years)
        Me.Controls.Add(Me.lbl15Years)
        Me.Controls.Add(Me.lblSideTitle)
        Me.Controls.Add(Me.lblBottomTitle)
        Me.Controls.Add(Me.lblSign5)
        Me.Controls.Add(Me.lblSign4)
        Me.Controls.Add(Me.lblSign3)
        Me.Controls.Add(Me.lblSign2)
        Me.Controls.Add(Me.lblSign1)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtSimpleIntRate)
        Me.Controls.Add(Me.lblSimpleInt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMonthlyIntRate)
        Me.Controls.Add(Me.lblMonthlyIntRate)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtAnnualIntRate)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.lblANNUALINTERESTRATE)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.lblTopTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FORM1"
        Me.Text = "CS200 FINALS PROJECT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTopTitle As Label
    Friend WithEvents lblPrincipal As Label
    Friend WithEvents lblANNUALINTERESTRATE As Label
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtAnnualIntRate As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents lblMonthlyIntRate As Label
    Friend WithEvents txtMonthlyIntRate As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSimpleInt As Label
    Friend WithEvents txtSimpleIntRate As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents txtYears As TextBox
    Friend WithEvents lblSign1 As Label
    Friend WithEvents lblSign2 As Label
    Friend WithEvents lblSign3 As Label
    Friend WithEvents lblSign4 As Label
    Friend WithEvents lblSign5 As Label
    Friend WithEvents lblBottomTitle As Label
    Friend WithEvents lblSideTitle As Label
    Friend WithEvents lbl15Years As Label
    Friend WithEvents lbl20Years As Label
    Friend WithEvents lbl25Years As Label
    Friend WithEvents lbl30Years As Label
    Friend WithEvents lbl2Percent As Label
    Friend WithEvents lbl3Percent As Label
    Friend WithEvents lbl4Percent As Label
    Friend WithEvents lbl5Percent As Label
    Friend WithEvents lbl6Percent As Label
    Friend WithEvents lbl7Percent As Label
    Friend WithEvents lbl8Percent As Label
    Friend WithEvents txt15x2 As TextBox
    Friend WithEvents txt15x3 As TextBox
    Friend WithEvents txt15x4 As TextBox
    Friend WithEvents txt15x5 As TextBox
    Friend WithEvents txt15x6 As TextBox
    Friend WithEvents txt15x7 As TextBox
    Friend WithEvents txt15x8 As TextBox
    Friend WithEvents txt20x2 As TextBox
    Friend WithEvents txt20x3 As TextBox
    Friend WithEvents txt20x4 As TextBox
    Friend WithEvents txt20x5 As TextBox
    Friend WithEvents txt20x6 As TextBox
    Friend WithEvents txt20x7 As TextBox
    Friend WithEvents txt20x8 As TextBox
    Friend WithEvents txt25x2 As TextBox
    Friend WithEvents txt25x3 As TextBox
    Friend WithEvents txt25x4 As TextBox
    Friend WithEvents txt25x5 As TextBox
    Friend WithEvents txt25x6 As TextBox
    Friend WithEvents txt25x7 As TextBox
    Friend WithEvents txt25x8 As TextBox
    Friend WithEvents txt30x2 As TextBox
    Friend WithEvents txt30x3 As TextBox
    Friend WithEvents txt30x4 As TextBox
    Friend WithEvents txt30x5 As TextBox
    Friend WithEvents txt30x6 As TextBox
    Friend WithEvents txt30x7 As TextBox
    Friend WithEvents txt30x8 As TextBox
End Class
