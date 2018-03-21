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
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCloseConnection
        '
        Me.btnCloseConnection.Location = New System.Drawing.Point(249, 14)
        Me.btnCloseConnection.Name = "btnCloseConnection"
        Me.btnCloseConnection.Size = New System.Drawing.Size(108, 23)
        Me.btnCloseConnection.TabIndex = 18
        Me.btnCloseConnection.Text = "Close connection"
        Me.btnCloseConnection.UseVisualStyleBackColor = True
        '
        'btnSelect_Classificazione
        '
        Me.btnSelect_Classificazione.Location = New System.Drawing.Point(173, 55)
        Me.btnSelect_Classificazione.Name = "btnSelect_Classificazione"
        Me.btnSelect_Classificazione.Size = New System.Drawing.Size(165, 23)
        Me.btnSelect_Classificazione.TabIndex = 17
        Me.btnSelect_Classificazione.Text = "Select * from Classificazione"
        Me.btnSelect_Classificazione.UseVisualStyleBackColor = True
        '
        'btnGetTables
        '
        Me.btnGetTables.Location = New System.Drawing.Point(23, 123)
        Me.btnGetTables.Name = "btnGetTables"
        Me.btnGetTables.Size = New System.Drawing.Size(447, 23)
        Me.btnGetTables.TabIndex = 16
        Me.btnGetTables.Text = "Get DB tables"
        Me.btnGetTables.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 164)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(483, 319)
        Me.dgvData.TabIndex = 15
        '
        'btnSelectContati
        '
        Me.btnSelectContati.Location = New System.Drawing.Point(344, 55)
        Me.btnSelectContati.Name = "btnSelectContati"
        Me.btnSelectContati.Size = New System.Drawing.Size(151, 23)
        Me.btnSelectContati.TabIndex = 14
        Me.btnSelectContati.Text = "Select * from Contatti"
        Me.btnSelectContati.UseVisualStyleBackColor = True
        '
        'lblStato
        '
        Me.lblStato.AutoSize = True
        Me.lblStato.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblStato.Location = New System.Drawing.Point(363, 19)
        Me.lblStato.Name = "lblStato"
        Me.lblStato.Size = New System.Drawing.Size(107, 13)
        Me.lblStato.TabIndex = 13
        Me.lblStato.Text = "Stato: Non connesso"
        '
        'btnInsert_GL_Lavori
        '
        Me.btnInsert_GL_Lavori.Location = New System.Drawing.Point(12, 82)
        Me.btnInsert_GL_Lavori.Name = "btnInsert_GL_Lavori"
        Me.btnInsert_GL_Lavori.Size = New System.Drawing.Size(196, 23)
        Me.btnInsert_GL_Lavori.TabIndex = 12
        Me.btnInsert_GL_Lavori.Text = "Insert into GL_Lavori"
        Me.btnInsert_GL_Lavori.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(12, 55)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(155, 23)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "Select * from GL_Lavori"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 14)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(231, 23)
        Me.btnConnect.TabIndex = 10
        Me.btnConnect.Text = "Connect to DB"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtGL_IDLavoro
        '
        Me.txtGL_IDLavoro.Location = New System.Drawing.Point(218, 84)
        Me.txtGL_IDLavoro.Name = "txtGL_IDLavoro"
        Me.txtGL_IDLavoro.Size = New System.Drawing.Size(91, 20)
        Me.txtGL_IDLavoro.TabIndex = 19
        '
        'txtGL_AppObjUID
        '
        Me.txtGL_AppObjUID.Location = New System.Drawing.Point(315, 84)
        Me.txtGL_AppObjUID.Name = "txtGL_AppObjUID"
        Me.txtGL_AppObjUID.Size = New System.Drawing.Size(87, 20)
        Me.txtGL_AppObjUID.TabIndex = 20
        '
        'txtGL_AziendaID
        '
        Me.txtGL_AziendaID.Location = New System.Drawing.Point(408, 84)
        Me.txtGL_AziendaID.Name = "txtGL_AziendaID"
        Me.txtGL_AziendaID.Size = New System.Drawing.Size(87, 20)
        Me.txtGL_AziendaID.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 495)
        Me.Controls.Add(Me.txtGL_AziendaID)
        Me.Controls.Add(Me.txtGL_AppObjUID)
        Me.Controls.Add(Me.txtGL_IDLavoro)
        Me.Controls.Add(Me.btnCloseConnection)
        Me.Controls.Add(Me.btnSelect_Classificazione)
        Me.Controls.Add(Me.btnGetTables)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnSelectContati)
        Me.Controls.Add(Me.lblStato)
        Me.Controls.Add(Me.btnInsert_GL_Lavori)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
