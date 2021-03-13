Public Interface ICa2
    Sub CalZero()
    Sub Measure()
    Event ExeCalZero()
    ReadOnly Property SingleProbe As Object
    WriteOnly Property RemoteMode As Integer
End Interface

Public Interface IProbe2
    ReadOnly Property Lv As Single
    ReadOnly Property X As Single
    ReadOnly Property Y As Single
    ReadOnly Property Z As Single
    ReadOnly Property sx As Single
    ReadOnly Property sy As Single
    ReadOnly Property ud As Single
    ReadOnly Property vd As Single
    ReadOnly Property T As Integer
    ReadOnly Property duv As Single
End Interface

Public Class implementCa2
    Implements ICa2
    Public Sub CalZero() Implements ICa2.CalZero
        MessageBox.Show("Zero Cal Success")
    End Sub
    Public Sub Measure() Implements ICa2.Measure
        MessageBox.Show("Measure Success")
    End Sub
    Event ExeCalZero() Implements ICa2.ExeCalZero
    Property SingleProbe As Object Implements ICa2.SingleProbe
    WriteOnly Property RemoteMode As Integer Implements ICa2.RemoteMode
        Set(value As Integer)
        End Set
    End Property
End Class

Public Class implementProbe2
    Implements IProbe2
    Public ReadOnly Property Lv As Single Implements IProbe2.Lv
        Get
            Return 0.1F
        End Get
    End Property

    Public ReadOnly Property X As Single Implements IProbe2.X
        Get
            Return 1.2F
        End Get
    End Property

    Public ReadOnly Property Y As Single Implements IProbe2.Y
        Get
            Return 2.3F
        End Get
    End Property

    Public ReadOnly Property Z As Single Implements IProbe2.Z
        Get
            Return 3.4F
        End Get
    End Property

    Public ReadOnly Property sx As Single Implements IProbe2.sx
        Get
            Return 4.0F
        End Get
    End Property

    Public ReadOnly Property sy As Single Implements IProbe2.sy
        Get
            Return 5.0F
        End Get
    End Property

    Public ReadOnly Property ud As Single Implements IProbe2.ud
        Get
            Return 6.0F
        End Get
    End Property

    Public ReadOnly Property vd As Single Implements IProbe2.vd
        Get
            Return 7.0F
        End Get
    End Property

    Public ReadOnly Property T As Integer Implements IProbe2.T
        Get
            Return 8
        End Get
    End Property

    Public ReadOnly Property duv As Single Implements IProbe2.duv
        Get
            Return 9.3F
        End Get
    End Property
End Class