﻿Public Class frmBusinessTravelExpenses

  Const OneInch as Integer = 75
  Const LineHeight as Integer = 15

  Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    Dim g as Graphics = e.Graphics
    Dim str as String
    Dim x1 As Integer = OneInch
    Dim x2 as Integer = 5 * OneInch
    Dim y as Integer = 2 * OneInch
    Dim font as New Font("Courier New",10,FontStyle.Bold)

    str = "Business Trave Expenses"
    g.DrawString(str, font, Brushes.Black,x1,y)
    font = New Font("Courier New",10,FontStyle.Regular)
    y += 2 * LineHeight
    str = "Trip to attend meeting of"
    g.DrawString(str, font, Brushes.Black,x1, y)
    y += LineHeight
    g.DrawString(txtOrg.Text, font, Brushes.Black, x1, y)
    y += LineHeight
    str = txtDates.Text + " in " & txtPlace.Text
    g.DrawString(str, font, Brushes.Black, x1, y)
    y += 2 * LineHeight
    g.DrawString(lblMealsEnt.Text, font, Brushes.Black, x1, y)
    g.DrawString((Cdbl(txtMealsEnt.Text)).ToString("C"), font, Brushes.Black,x2,y)
    y += LineHeight
    g.DrawString(lblAirfare.Text, font, Brushes.Black, x1, y)
    g.DrawString((Cdbl(txtAirFare.Text)).ToString("C"), font, Brushes.Black,x2,y)
    y += LineHeight
    g.DrawString(lblLodging.Text, font, Brushes.Black, x1, y)
    g.DrawString((Cdbl(txtLodging.Text)).ToString("C"), font, Brushes.Black,x2,y)
    y += LineHeight
    g.DrawString(lblTaxi.Text, font, Brushes.Black, x1, y)
    g.DrawString((Cdbl(txtTaxi.Text)).ToString("C"), font, Brushes.Black,x2,y)
    y += 2*LineHeight
    Dim other as Double = Cdbl(txtAirFare.Text) + CDbl(txtLodging.Text) + CDbl(txtTaxi.Text)
    str = "Total other than meals and entertainment: " & other.ToString("C")
    g.DrawString(str, font, Brushes.Black, x1, y)
    y += LineHeight
    Dim mealEntertainmentDeduction as Double = 0.5 * Cdbl(txtMealsEnt.Text)
    str = "50% of meals and entertainment: " & (CDbl(mealEntertainmentDeduction)).ToString("C")
    g.DrawString(str, font, Brushes.Black, x1, y)
    y += 2*LineHeight
    str = "TOTAL DEDUCTIBLE EXPENSES: " & (CDbl(other + mealEntertainmentDeduction)).ToString("C")
    g.DrawString(str, font, Brushes.Black, x1, y)
  End Sub

  Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
    PrintDocument1.Print()
  End Sub

  Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
    PrintPreviewDialog1.Document = PrintDocument1
    PrintPreviewDialog1.ShowDialog()
  End Sub
End Class
