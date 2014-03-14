Partial Public Class LotTest

    Public Property lot_id As Integer
    Public Property item_nbr As String
    Public Property item_desc As String
    Public Property bin_id As String
    Public Property entered_ts As Nullable(Of Date)
    Public Property supplier_lot_id As String
    Public Property iter_number As Integer

    Public Function CloneLot(i As Integer) As LotTest

        CloneLot = Me.MemberwiseClone()

        CloneLot.iter_number = i

    End Function


End Class

