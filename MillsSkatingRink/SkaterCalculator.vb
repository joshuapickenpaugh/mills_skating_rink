Public Class SkaterCalculator

    Private _intSelectedScore As Integer
    Private _intTotalScore As Integer
    Private _intNumOfScores As Integer
    Private _intAverageScore As Integer

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

    Public Property NumOfScores As Integer
        Get
            Return _intNumOfScores
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intNumOfScores = value
            Else
                _intNumOfScores = 0
            End If
        End Set
    End Property

    Public Property AverageScore As Integer
        Get
            Return _intAverageScore
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intAverageScore = value
            Else
                _intAverageScore = 0
            End If
        End Set
    End Property

    Public Sub New()

        _intSelectedScore = 0
        _intTotalScore = 0
        _intNumOfScores = 0
        _intAverageScore = 0

    End Sub

    Public Sub Clear()

        _intSelectedScore = 0
        _intTotalScore = 0
        _intNumOfScores = 0
        _intAverageScore = 0

    End Sub

    Public Function GetTotalScore() As Integer

        _intTotalScore = _intTotalScore + _intSelectedScore

        Return _intTotalScore

    End Function

    Public Function GetNumberOfScores() As Integer

        _intNumOfScores = _intNumOfScores + 1

        Return _intNumOfScores

    End Function

    Public Function GetAverageScore() As Integer

        _intAverageScore = _intTotalScore / _intNumOfScores

        Return _intAverageScore

    End Function
End Class
