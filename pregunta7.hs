
import System.Directory

main = do
	print "introucir primer numero: "
	num1 <- getLine
	print("numero introducido: "++ num1)

	print "introducir segundo numero: "
	num2 <- getLine
	print("numero introducido: "++ num2)



	Suma num1 num2 = (evalua num1) + (evalua num2)
	print("la suma de ambos numeros: "++ evalua )

	Resta num1 num2 = (evalua num1) - (evalua num2)
	print("la resta de ambos numeros: "++ Resta )

	Multiplicacion num1 num2 = (evalua num1) + (evalua num2)
	print("multiplicacion de ambos numeros: "++ Multiplicacion )

	Division num1 num2 = div num1 num2
	print("division de ambos numeros: "++ Division )