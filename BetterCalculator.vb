'Sean Gingerich
'RCET0265
'Fall 2020
'Say My Name Again
'https://github.com/gingsean5/BetterCalculator
Module BetterCalculator

    Sub Main()
        Dim userInput As String
        Dim userDecision As String

        Dim firstNumber As Integer
        Dim secondNumber As Integer


        Dim problem As Boolean



        While userInput <> "Q" And userInput <> "q"
            Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")
            problem = True
            While problem = True And userInput <> "Q" And userInput <> "q"
                Console.Write("Choose a Number: ")
                Try
                    userInput = Console.ReadLine()
                    firstNumber = CInt(userInput)
                    problem = False
                Catch e As Exception
                    Console.WriteLine($"You entered {userInput}, please enter a whole number.")
                    problem = True
                End Try
                If problem = False Then
                    Console.WriteLine($"You entered {userInput}")
                End If
            End While

            problem = True

            While problem = True And userInput <> "Q" And userInput <> "q"
                Console.Write("Choose a Number: ")
                Try
                    userInput = Console.ReadLine()
                    secondNumber = CInt(userInput)
                    problem = False
                Catch e As Exception
                    Console.WriteLine($"You entered {userInput}, please enter a whole number.")
                    problem = True
                End Try
                If problem = False Then
                    Console.WriteLine($"You entered {userInput}")
                End If
            End While
            problem = True
            While problem = True And userDecision <> "Q" And userInput <> "q"
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                userDecision = Console.ReadLine()

                Select Case userDecision
                    Case = "1"
                        Console.WriteLine($"You entered {userDecision}")
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
                        problem = False
                    Case = "2"
                        Console.WriteLine($"You entered {userDecision}")
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
                        problem = False
                    Case = "3"
                        Console.WriteLine($"You entered {userDecision}")
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
                        problem = False
                    Case = "4"
                        Console.WriteLine($"You entered {userDecision}")
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
                        problem = False
                End Select
            End While

        End While
    End Sub


End Module
