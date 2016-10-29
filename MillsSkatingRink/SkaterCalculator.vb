Public Class SkaterCalculator

    Private _intSelectedScore As Integer
    Private _intTotalScore As Integer

    Public Property SelectedScore As Integer
        Get
            Return _intSelectedScore
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intSelectedScore = value
            Else
                _intSelectedScore = 0
            End If
        End Set
    End Property

    Public Sub New()

        _intSelectedScore = 0
        _intTotalScore = 0

    End Sub

    Public Sub Clear()

        _intSelectedScore = 0
        _intTotalScore = 0

    End Sub

    Public Function GetTotalScore()

        _intTotalScore = _intTotalScore + _intSelectedScore

        Return _intTotalScore

    End Function

    Public Function GetNumberOfScores()



    End Function

    Public Function GetAverageScore()



    End Function
End Class
