
Option Explicit On
Option Strict On
Option Compare Text
Module libTRG
    'If card already dealt, program trys another card that has not been dealt.
    Sub Deal()
        Dim deck(12, 3) As Boolean
        Dim value As Integer
        Dim suit As Integer
        value = CInt(Math.Floor(Rnd() * 12))
        suit = CInt(Math.Floor(Rnd() * 3))
        Select Case deck(value, suit)
            Case False
                deck(value, suit) = True
                CardArray(value, suit)
            Case True
                Deal()
        End Select
    End Sub

    'Sets all dealt cards to a false value to reset.
    Function Shuffle() As Boolean(,)
        Dim deck(12, 3) As Boolean
        For i = LBound(deck) To UBound(deck)
            deck(i, 0) = False
            deck(i, 1) = False
            deck(i, 2) = False
            deck(i, 3) = False
        Next
        Return deck
    End Function

    'Determines playing card based on values of a multidimensional array.
    Sub CardArray(values As Integer, suits As Integer)
        Dim suit As String
        Dim spades As String = "Spades"
        Dim clubs As String = "Clubs"
        Dim hearts As String = "Hearts"
        Dim diamonds As String = "Diamonds"
        Select Case suits
            Case 0
                suit = spades
            Case 1
                suit = clubs
            Case 2
                suit = hearts
            Case 3
                suit = diamonds
        End Select
        If values < 9 Then
            Console.WriteLine($"the {(values + 2)} of {suit}")
        ElseIf values = 9 Then
            Console.WriteLine($"the Jack of {suit}")
        ElseIf values = 10 Then
            Console.WriteLine($"the Queen of {suit}")
        ElseIf values = 11 Then
            Console.WriteLine($"the King of {suit}")
        ElseIf values = 12 Then
            Console.WriteLine($"the Ace of {suit}")
        End If
    End Sub
End Module
