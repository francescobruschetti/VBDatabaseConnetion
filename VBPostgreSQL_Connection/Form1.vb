Imports Npgsql
Imports NpgsqlTypes
Imports System.Data.SqlClient



Public Class Form1
    ' Variables for manage the posdtgre db
    Public Shared connectionString As String = "Server=localhost;Port=5432;UserId=postgres;Password=admin;Database=Agile_Business;CommandTimeout=300;"
    Public Shared DBConnection As NpgsqlConnection

    ' SQL Server connection
    Dim SQLConnection As New SqlClient.SqlConnection
    Dim SQLConnectionString As String = "Data Source=(localdb)\MSSQLLocalDB;initial catalog=AgileBusiness_VUOTO;Integrated Security=true;Connection Timeout=10;"


    ' array for PostgreSQl tables
    Public Shared dsTabelle As New DataSet

    ' array for SQL Server tables
    Public Shared dtSQLServer As New DataTable
    ' Where I save the value of all the tables from the SQL Server DB
    Public Shared listOfDS As New List(Of DataTable)

    ' Function that execute the specified query for the Postgre DB
    Public Sub Execute_Select_Query(query As String)

        Dim dt As New DataTable()

        Try
            Dim command As NpgsqlCommand = DBConnection.CreateCommand()
            command.CommandType = CommandType.Text
            command.CommandText = query
            Dim da As New NpgsqlDataAdapter(command)
            da.Fill(dt)

            dgvData.DataSource = dt

        Catch ex As Exception
            MsgBox("Errore: " & ex.Message, MsgBoxStyle.MsgBoxSetForeground)
            'Finally
            'DBConnection.Close()
        End Try

    End Sub

    ' Given the name of a table, get every stored record SQL Server
    Public Sub Get_All_Data_From_Table(tableName As String, index As Int32)

        Dim dt As New DataTable()
        Dim query = "SELECT * FROM " & tableName & ";"

        Try
            Dim command As SqlCommand = SQLConnection.CreateCommand()
            command.CommandType = CommandType.Text
            command.CommandText = query
            Dim da As New SqlDataAdapter(command)
            da.Fill(dt)

            listOfDS.Add(dt)

            'Console.WriteLine

        Catch ex As Exception
            MsgBox("Errore: " & ex.Message, MsgBoxStyle.MsgBoxSetForeground)

        End Try

        ' Finally
        ' SQLConnection.Close()

    End Sub

    ' Connection with the Postgre Server
    Public Sub Database_Connection()
        Try
            DBConnection = New NpgsqlConnection(connectionString)
            DBConnection.Open()
            If DBConnection.State = ConnectionState.Open Then
                ' MsgBox("Connected", MsgBoxStyle.MsgBoxSetForeground)
                lblStato.Text = "Connesso con Postgres"

            Else
                lblStato.Text = "Errore. Stato: " & DBConnection.State
            End If

        Catch ex As Exception
            lblStato.Text = "Errore: " & ex.Message
        End Try
    End Sub

    Public Sub SQLServer_DBConnection()

        ' mi restituisce la lista di tutte le tabelle, ordinate alfabeticamente in base al nome
        Dim strCommand As String = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME ASC;"
        Dim command As SqlCommand
        Dim da As SqlDataAdapter

        Try
            SQLConnection.ConnectionString = SQLConnectionString
            command = New SqlCommand(strCommand, SQLConnection)
            command.CommandTimeout = 3000

            da = New SqlDataAdapter(command)
            da.Fill(dtSQLServer)

            dgvData.DataSource = dtSQLServer

            lblStatoSQLServer.Text = "Tabelle trovate: " & dtSQLServer.Rows.Count.ToString()

        Catch ex As Exception
            MsgBox("Errore: " & ex.Message, MsgBoxStyle.MsgBoxSetForeground)
            'Finally
            'If SQLConnection.State = ConnectionState.Open Then
            'SQLConnection.Close()
            'End If
        End Try



    End Sub

    ' DOES NOT WORK.
    Public Function Close_Connection() As Boolean
        Dim retValue = False

        Try
            DBConnection.Close()
            retValue = True

        Catch ex As Exception
            retValue = False

        End Try

        Return retValue

    End Function

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Database_Connection()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Execute_Select_Query("SELECT * FROM public.""GL_Lavori"";")
    End Sub

    Private Sub btnSelectContati_Click(sender As Object, e As EventArgs) Handles btnSelectContati.Click
        Execute_Select_Query("SELECT * FROM public.""Contatti"";")
    End Sub

    Private Sub btnSelect_Classificazione_Click(sender As Object, e As EventArgs) Handles btnSelect_Classificazione.Click
        Execute_Select_Query("SELECT * FROM public.""Classificazione"";")
    End Sub

    ' NON VA: anche se chiudo la connessione, le query vengono eseguite
    Private Sub btnCloseConnection_Click(sender As Object, e As EventArgs) Handles btnCloseConnection.Click
        If Close_Connection() Then
            lblStato.Text = "Connessione con il db interrotta"
        Else
            lblStato.Text = "Errore durante la chiusura della connessione"
        End If

    End Sub

    Private Sub btnInsert_GL_Lavori_Click(sender As Object, e As EventArgs) Handles btnInsert_GL_Lavori.Click
        ' lettura dei dati dalla form
        Dim GL_IDLavoro = Convert.ToInt32(txtGL_IDLavoro.Text)
        Dim GL_AppObjUID = Convert.ToInt32(txtGL_AppObjUID.Text)
        Dim GL_AziendaID = Convert.ToInt32(txtGL_AziendaID.Text)

        Dim insert_query = "insert into Public.""GL_Lavori"" (""GL_IDLavoro"", ""GL_AppObjUID"", ""GL_AziendaID"")" &
            "VALUES (@GL_IDLavoro, @GL_AppObjUID, @GL_AziendaID);"

        ' Esecuzione della query
        Try
            Dim command As NpgsqlCommand = DBConnection.CreateCommand()
            'command.CommandType = CommandType.Text
            command.CommandText = insert_query

            ' associo i valori ai parametri della query
            Dim par = command.Parameters.Add("@GL_IDLavoro", NpgsqlDbType.Integer)
            par.Value = GL_IDLavoro

            par = command.Parameters.Add("@GL_AppObjUID", NpgsqlDbType.Integer)
            par.Value = GL_AppObjUID

            par = command.Parameters.Add("@GL_AziendaID", NpgsqlDbType.Integer)
            par.Value = GL_AziendaID

            ' Se lo imposto come null, dà errore
            'par = command.Parameters.Add("@GL_TipoLavoro", NpgsqlDbType.Integer)
            'par.Value = Nothing


            ' Eseguo la insert
            Dim aff As Integer = command.ExecuteNonQuery()
            lblStato.Text = "Risposta query: " & aff


        Catch ex As Exception
            MsgBox("Errore: " & ex.Message, MsgBoxStyle.MsgBoxSetForeground)
            'Finally
            'DBConnection.Close()
        End Try


    End Sub

    Private Sub btnGetTables_Click(sender As Object, e As EventArgs) Handles btnGetTables.Click
        Dim query_select_tables = "SELECT table_name From information_schema.tables Where table_schema ='public' And table_type ='BASE TABLE';"

        Dim dt As New DataTable()


        Try
            Dim command As NpgsqlCommand = DBConnection.CreateCommand()
            command.CommandType = CommandType.Text
            command.CommandText = query_select_tables
            Dim da As New NpgsqlDataAdapter(command)
            da.Fill(dt)
            da.Fill(dsTabelle)

            dgvData.DataSource = dt
        Catch ex As Exception
            MsgBox("Errore: " & ex.Message, MsgBoxStyle.MsgBoxSetForeground)
            'Finally
            'DBConnection.Close()
        End Try

    End Sub



    ''' 
    ''' SQL SERVER CODE
    ''' 

    Private Sub btnSQLServer_Connection_Click(sender As Object, e As EventArgs) Handles btnSQLServer_Connection.Click
        SQLServer_DBConnection()
    End Sub

    Private Sub btnSQLServerGetAllData_Click(sender As Object, e As EventArgs) Handles btnSQLServerGetAllData.Click
        Dim table As String

        listOfDS = New List(Of DataTable)

        ' scorro la lista di tutte le tabelle
        For index = 0 To dtSQLServer.Rows.Count - 1

            ' estraggo il nome della tabella nella riga "index" del datatable in cui sono salvata
            table = dtSQLServer.Rows(index)("Table_Name").ToString()

            Get_All_Data_From_Table(table, index)
        Next

        lblStatoSQLServer.Text = "Total Table Executed: " & listOfDS.Count

        For index = 0 To listOfDS.Count - 1
            If listOfDS(index).Rows.Count <> 0 Then
                MsgBox("Table '" & listOfDS(index).TableName & "'. Pos: " & index)
            End If

        Next
    End Sub
End Class
