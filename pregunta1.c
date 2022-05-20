Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	end sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
	
		Dim	a As Integer
		Dim b As Integer
		Dim c As Integer
		Dim d As Integer

		a = convert.ToInt32(TextBox1.Text) //5 -
		b = convert.ToInt32(TextBox2.Text) //8 8 
		c = convert.ToInt32(TextBox3.Text) //3 3 

		if a < b Then GoTo cambio1 Else GoTo cambio2
		cambio1:
			x = a
		cambio2:
			x = b 
			b = c
		if b < c  Then GoTo cambio3 Else GoTo cambio4
		cambio3:
			y = c
		cambio4:
			z = b
		if x < y Then GoTo cambio5 Else GoTo cambio6
		cambio5: 
			x = y 
			y = x
			TextBox3.Text = (x,y,z).ToString()
			GoTo salir
	salir:

	End Sub
End Class