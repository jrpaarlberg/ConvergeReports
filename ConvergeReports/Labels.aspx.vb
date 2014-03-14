Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Lot Lables
        Dim repeatedLots As New List(Of LotTest)
        Dim BlankLots As New List(Of LotTest)

        Dim LotList() As String = {Request.QueryString("lot_id")}

        repeatedLots.AddRange(RepeatBlankLot(Request.QueryString("StartLabel")))

        repeatedLots.AddRange(RepeatLot(LotList, Request.QueryString("lot_qty")))

        Dim objectDataSource = New Telerik.Reporting.ObjectDataSource()

        objectDataSource.DataSource = repeatedLots

        Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()


        If Len(Request.QueryString("rpt_nm").ToString) > 0 Then
            Select Case Request.QueryString("rpt_nm")
                Case "LotLables2x5"
                    Dim report = New ClassLotLabels.LotLabel2x5
                    report.DataSource = objectDataSource
                    instanceReportSource.ReportDocument = report
                Case "LotLables3x10"
                    Dim report = New ClassLotLabels.LotLabel3x10
                    report.DataSource = objectDataSource
                    instanceReportSource.ReportDocument = report

            End Select
        End If

        '        instanceReportSource.
        ReportViewer1.ReportSource = instanceReportSource
        ReportViewer1.RefreshReport()


    End Sub

    Private Function RepeatLot(lotNumber() As String, quantity As String) As IEnumerable(Of LotTest)
        RepeatLot = New List(Of LotTest)

        ' Validations first
        ' If user didn't enter anything, we skip this lot.
        If Not String.IsNullOrEmpty(lotNumber(0)) AndAlso Not String.IsNullOrWhiteSpace(lotNumber(0)) Then

            Dim lot As LotTest = GetByLotId(lotNumber, "on")

            If lot Is Nothing Then
                Return RepeatLot

            Else
                'This is call that puts Lot information into each clonelot
                Return Enumerable.Range(0, quantity).Select(Function(i) lot.CloneLot(i + 1)).ToList()
            End If

        End If
    End Function

    Private Function RepeatBlankLot(StartLabel As Integer) As IEnumerable(Of LotTest)
        Dim lot As LotTest = BlankLot(StartLabel)

        RepeatBlankLot = New List(Of LotTest)

        Return Enumerable.Range(0, StartLabel).Select(Function(i) lot.CloneLot(i + 1)).ToList()
    End Function


    Function GetByLotId(lotId() As String, hideBinId As String) As LotTest

        ' Provide the query string with a parameter placeholder. 
        Dim strSqlStnd As String = " SELECT lot.lot_id, item.item_nbr, item.item_desc, "

        If (hideBinId = "on") Then
            strSqlStnd = strSqlStnd & "' ' as bin_id, "
        Else
            strSqlStnd = strSqlStnd & "CASE WHEN x.bin_id IS NULL THEN '' ELSE upper(x.bin_id) END as bin_id, "
        End If

        strSqlStnd = strSqlStnd & " lot.entered_ts, lot.supplier_lot_id"
        strSqlStnd = strSqlStnd & " FROM lot LEFT OUTER JOIN"
        strSqlStnd = strSqlStnd & " item ON lot.item_id = item.item_id"
        strSqlStnd = strSqlStnd & " LEFT OUTER JOIN inventory_adj x "
        strSqlStnd = strSqlStnd & " ON x.lot_id = lot.lot_id "

        strSqlStnd = strSqlStnd & " WHERE lot.lot_id = '" & lotId(0) & "'"

        ' loop through all of the Lot ID

        ' Create and open the connection in a using block. This 
        ' ensures that all resources will be closed and disposed 
        ' when the code exits. 
        Using connection As New SqlConnection("Data Source=TR-SQL;WSID=TR-SQL;UID=Converge;PWD=volters;Database=converge;Initial Catalog=Converge;Integrated Security=False")
            ' Create the Command and Parameter objects. 
            Dim command As New SqlCommand(strSqlStnd, connection)
            'command.Parameters.AddWithValue("@lot_id", lotId)

            ' Open the connection in a try/catch block.  
            ' Create and execute the DataReader, writing the result 
            ' set to the console window. 
            Try
                connection.Open()
                Dim dataReader As SqlDataReader = command.ExecuteReader()

                If dataReader.Read() Then

                    GetByLotId = New LotTest With _
                                 {
                                     .lot_id = dataReader(0),
                                     .item_nbr = dataReader(1),
                                     .item_desc = dataReader(2),
                                     .bin_id = dataReader(3),
                                     .entered_ts = dataReader(4),
                                     .supplier_lot_id = dataReader(5)
                                 }
                Else
                    GetByLotId = Nothing
                End If
                dataReader.Close()

            Catch ex As Exception
                GetByLotId = Nothing
            End Try
        End Using

    End Function

    Function BlankLot(StartLot As Integer) As LotTest

        ' Provide the query string with a parameter placeholder. 
        BlankLot = New LotTest With _
                     {
                         .item_nbr = " ",
                         .item_desc = " ",
                         .bin_id = " "
                     }

    End Function

End Class