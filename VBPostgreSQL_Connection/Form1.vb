Imports Npgsql

Public Class Form1
    ' COMMENTO ......
    ' Variables for manage the db
    Public Shared connectionString As String = "Server=localhost;Port=5432;UserId=postgres;Password=admin;Database=Agile_Business;CommandTimeout=300;"
    Public Shared DBConnection As NpgsqlConnection

    ' array 
    Public Shared dsTabelle As New DataSet


    Public Sub Execute_Select_Query(query As String)

        Dim dt As New DataTable()


        Try
            Dim command As NpgsqlCommand = DBConnection.CreateCommand()
            command.CommandType = CommandType.Text
            command.CommandText = query
            Dim da As New NpgsqlDataAdapter(command)
            da.Fill(dt)

            dgvData.DataSource = dt
            'dgvData.DataBind()


        Catch ex As Exception
            MsgBox("Errore: " & ex.Message, MsgBoxStyle.MsgBoxSetForeground)
        Finally
            DBConnection.Close()
        End Try

    End Sub

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

        Dim insert_query = "insert into Public.""GL_Lavori"" (""GL_IDLavoro"", ""GL_AppObjUID"", ""GL_AziendaID"", ""GL_TipoLavoro"")" &
            "VALUES (" & GL_IDLavoro & "," & GL_AppObjUID & "," & GL_AziendaID & ",null);"

        ' Esecuzione della query
        Try
            Dim command As NpgsqlCommand = DBConnection.CreateCommand()
            command.CommandType = CommandType.Text
            command.CommandText = insert_query

            ' Eseguo la insert
            Dim aff As Integer = command.ExecuteNonQuery()
            lblStato.Text = "Risposta query: " & aff


        Catch ex As Exception
            MsgBox("Errore: " & ex.Message, MsgBoxStyle.MsgBoxSetForeground)
        Finally
            DBConnection.Close()
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
        Finally
            DBConnection.Close()
        End Try

    End Sub
End Class
