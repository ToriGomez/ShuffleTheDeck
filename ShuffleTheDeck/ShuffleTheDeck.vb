'Tori Gomez
'RCET 0265
'Spring 2021
'Shuffle the Deck
'

Option Strict On
Option Explicit On
Option Compare Text

Module ShuffleTheDeck
    Sub Main()
        Dim userInput As String
        Dim deck(12, 3) As Boolean
        Dim value As Integer
        Dim suit As Integer
        Dim cont As Boolean = True
        Console.WriteLine("Press enter for playing card." _
                           & vbNewLine & "Type shuffle to shuffle all cards" _
                           & vbNewLine & "Type Q to quit" & vbNewLine)
        'Repeats/Continues program until told otherwise
        While cont
            userInput = Console.ReadLine()
            Select Case userInput
                'Shuffles deck when User inputs shuffle
                Case "Shuffle"
                    'Shuffle() - Sets all dealt cards to a false value to reset.
                    libTRG.Shuffle()
                'Quits program when User inputs Q. Stops repeating loop.
                Case "Q"
                    Console.Clear()
                    Console.WriteLine($"You typed {userInput}, Thank you have a good day.")
                    Console.Read()
                    End
                 'Deals random card when User inputs enter.
                Case ""
                    value = CInt(Math.Floor(Rnd() * 12))
                    suit = CInt(Math.Floor(Rnd() * 3))
                    Select Case deck(value, suit)
                        'If card is still available program deals card
                        Case False
                            deck(value, suit) = True
                            'CardArray(,) - determines playing card based on values of a multidimensional array.
                            libTRG.CardArray(value, suit)
                        'If card already dealt, Deal() trys another card that has not been dealt.
                        Case True
                            libTRG.Deal()
                    End Select
                    'Program Writes NOT VALID when User Input is not a functional input.
                Case Else
                    Console.WriteLine($"{userInput} is NOT VALID")
            End Select
        End While
        Console.Read()
    End Sub
End Module
