[EntryPoint]
let main argv = 
	System.Console.WriteLine("PREGUNTA 6")
	
	System.Console.WriteLine("introduce primer numero : ")
	System.Console.ReadLine(x)

	System.Console.WriteLine("introduce segundo numero : ")
	System.Console.ReadLine(y)

	let suma = fun x y -> x + y 

	let resta = fun x y -> x - y

	let multiplicacion = fun x y -> x * y

	let division = fun x y -> x / y