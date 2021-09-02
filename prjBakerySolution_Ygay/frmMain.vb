Option Explicit On
Option Infer On
Option Strict On

Public Class frmMain
    Private strClerk As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const decITEM_PRICE As Decimal = 0.5D
        Const decTAX_RATE As Decimal = 0.02D
        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal

        Integer.TryParse(txtDoughnuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)
        intTotalItems = intDonuts + intMuffins

        decSubtotal = intTotalItems * decITEM_PRICE

        decSalesTax = decSubtotal * decTAX_RATE

        decTotalSales = decSubtotal + decSalesTax

        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = Convert.ToString(decTotalSales)
        lblMsg.Text = decSalesTax.ToString("C2")

        lblMsg.Text = "The sale tax was " & decSalesTax.ToString("C2") & "." &
            ControlChars.NewLine & strClerk


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Const strPROMT As String = "Salesclerk's name:"
        Const strTITLE As String = "Name Entry"

        strClerk = InputBox(strPROMT, strTITLE)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDoughnuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty

        txtDoughnuts.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False
        ' PrintForm1.Print()
        btnCalc.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnPrint.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged


    End Sub
End Class
