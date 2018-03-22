<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCloseConnection = New System.Windows.Forms.Button()
        Me.btnSelect_Classificazione = New System.Windows.Forms.Button()
        Me.btnGetTables = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.btnSelectContati = New System.Windows.Forms.Button()
        Me.lblStato = New System.Windows.Forms.Label()
        Me.btnInsert_GL_Lavori = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtGL_IDLavoro = New System.Windows.Forms.TextBox()
        Me.txtGL_AppObjUID = New System.Windows.Forms.TextBox()
        Me.txtGL_AziendaID = New System.Windows.Forms.TextBox()
        Me.btnSQLServer_Connection = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSQLServerGetAllData = New System.Windows.Forms.Button()
        Me.lblStatoSQLServer = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCloseConnection
        '
        Me.btnCloseConnection.Location = New System.Drawing.Point(250, 24)
        Me.btnCloseConnection.Name = "btnCloseConnection"
        Me.btnCloseConnection.Size = New System.Drawing.Size(86, 23)
        Me.btnCloseConnection.TabIndex = 18
        Me.btnCloseConnection.Text = "Close connection"
        Me.btnCloseConnection.UseVisualStyleBackColor = True
        '
        'btnSelect_Classificazione
        '
        Me.btnSelect_Classificazione.Location = New System.Drawing.Point(166, 53)
        Me.btnSelect_Classificazione.Name = "btnSelect_Classificazione"
        Me.btnSelect_Classificazione.Size = New System.Drawing.Size(165, 23)
        Me.btnSelect_Classificazione.TabIndex = 17
        Me.btnSelect_Classificazione.Text = "Select * from Classificazione"
        Me.btnSelect_Classificazione.UseVisualStyleBackColor = True
        '
        'btnGetTables
        '
        Me.btnGetTables.Location = New System.Drawing.Point(16, 108)
        Me.btnGetTables.Name = "btnGetTables"
        Me.btnGetTables.Size = New System.Drawing.Size(425, 23)
        Me.btnGetTables.TabIndex = 16
        Me.btnGetTables.Text = "Get DB tables"
        Me.btnGetTables.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 288)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(483, 195)
        Me.dgvData.TabIndex = 15
        '
        'btnSelectContati
        '
        Me.btnSelectContati.Location = New System.Drawing.Point(337, 53)
        Me.btnSelectContati.Name = "btnSelectContati"
        Me.btnSelectContati.Size = New System.Drawing.Size(129, 23)
        Me.btnSelectContati.TabIndex = 14
        Me.btnSelectContati.Text = "Select * from Contatti"
        Me.btnSelectContati.UseVisualStyleBackColor = True
        '
        'lblStato
        '
        Me.lblStato.AutoSize = True
        Me.lblStato.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblStato.Location = New System.Drawing.Point(356, 29)
        Me.lblStato.Name = "lblStato"
        Me.lblStato.Size = New System.Drawing.Size(107, 13)
        Me.lblStato.TabIndex = 13
        Me.lblStato.Text = "Stato: Non connesso"
        '
        'btnInsert_GL_Lavori
        '
        Me.btnInsert_GL_Lavori.Location = New System.Drawing.Point(5, 80)
        Me.btnInsert_GL_Lavori.Name = "btnInsert_GL_Lavori"
        Me.btnInsert_GL_Lavori.Size = New System.Drawing.Size(174, 23)
        Me.btnInsert_GL_Lavori.TabIndex = 12
        Me.btnInsert_GL_Lavori.Text = "Insert into GL_Lavori"
        Me.btnInsert_GL_Lavori.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(5, 53)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(155, 23)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "Select * from GL_Lavori"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(5, 24)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(239, 23)
        Me.btnConnect.TabIndex = 10
        Me.btnConnect.Text = "Connect to DB"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtGL_IDLavoro
        '
        Me.txtGL_IDLavoro.Location = New System.Drawing.Point(185, 82)
        Me.txtGL_IDLavoro.Name = "txtGL_IDLavoro"
        Me.txtGL_IDLavoro.Size = New System.Drawing.Size(94, 20)
        Me.txtGL_IDLavoro.TabIndex = 19
        '
        'txtGL_AppObjUID
        '
        Me.txtGL_AppObjUID.Location = New System.Drawing.Point(285, 82)
        Me.txtGL_AppObjUID.Name = "txtGL_AppObjUID"
        Me.txtGL_AppObjUID.Size = New System.Drawing.Size(84, 20)
        Me.txtGL_AppObjUID.TabIndex = 20
        '
        'txtGL_AziendaID
        '
        Me.txtGL_AziendaID.Location = New System.Drawing.Point(375, 82)
        Me.txtGL_AziendaID.Name = "txtGL_AziendaID"
        Me.txtGL_AziendaID.Size = New System.Drawing.Size(91, 20)
        Me.txtGL_AziendaID.TabIndex = 21
        '
        'btnSQLServer_Connection
        '
        Me.btnSQLServer_Connection.Location = New System.Drawing.Point(6, 19)
        Me.btnSQLServer_Connection.Name = "btnSQLServer_Connection"
        Me.btnSQLServer_Connection.Size = New System.Drawing.Size(238, 23)
        Me.btnSQLServer_Connection.TabIndex = 22
        Me.btnSQLServer_Connection.Text = "Connect to SQL Server AND get tables names"
        Me.btnSQLServer_Connection.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnGetTables)
        Me.GroupBox1.Controls.Add(Me.txtGL_AziendaID)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.txtGL_AppObjUID)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.txtGL_IDLavoro)
        Me.GroupBox1.Controls.Add(Me.btnInsert_GL_Lavori)
        Me.GroupBox1.Controls.Add(Me.btnCloseConnection)
        Me.GroupBox1.Controls.Add(Me.lblStato)
        Me.GroupBox1.Controls.Add(Me.btnSelect_Classificazione)
        Me.GroupBox1.Controls.Add(Me.btnSelectContati)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 142)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Postgre SQL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSQLServerGetAllData)
        Me.GroupBox2.Controls.Add(Me.lblStatoSQLServer)
        Me.GroupBox2.Controls.Add(Me.btnSQLServer_Connection)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 121)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SQL Server"
        '
        'btnSQLServerGetAllData
        '
        Me.btnSQLServerGetAllData.Location = New System.Drawing.Point(6, 48)
        Me.btnSQLServerGetAllData.Name = "btnSQLServerGetAllData"
        Me.btnSQLServerGetAllData.Size = New System.Drawing.Size(205, 23)
        Me.btnSQLServerGetAllData.TabIndex = 23
        Me.btnSQLServerGetAllData.Text = "Extract data from every tables"
        Me.btnSQLServerGetAllData.UseVisualStyleBackColor = True
        '
        'lblStatoSQLServer
        '
        Me.lblStatoSQLServer.AutoSize = True
        Me.lblStatoSQLServer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblStatoSQLServer.Location = New System.Drawing.Point(250, 24)
        Me.lblStatoSQLServer.Name = "lblStatoSQLServer"
        Me.lblStatoSQLServer.Size = New System.Drawing.Size(107, 13)
        Me.lblStatoSQLServer.TabIndex = 22
        Me.lblStatoSQLServer.Text = "Stato: Non connesso"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 495)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCloseConnection As Button
    Friend WithEvents btnSelect_Classificazione As Button
    Friend WithEvents btnGetTables As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnSelectContati As Button
    Friend WithEvents lblStato As Label
    Friend WithEvents btnInsert_GL_Lavori As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents txtGL_IDLavoro As TextBox
    Friend WithEvents txtGL_AppObjUID As TextBox
    Friend WithEvents txtGL_AziendaID As TextBox
    Friend WithEvents btnSQLServer_Connection As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblStatoSQLServer As Label
    Friend WithEvents btnSQLServerGetAllData As Button
End Class
