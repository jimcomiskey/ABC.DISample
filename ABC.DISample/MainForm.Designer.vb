<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnShowSubform = New System.Windows.Forms.Button()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.btnGetClients = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSelectLastItem = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowSubform
        '
        Me.btnShowSubform.Location = New System.Drawing.Point(289, 13)
        Me.btnShowSubform.Name = "btnShowSubform"
        Me.btnShowSubform.Size = New System.Drawing.Size(137, 23)
        Me.btnShowSubform.TabIndex = 0
        Me.btnShowSubform.Text = "Show Subform"
        Me.btnShowSubform.UseVisualStyleBackColor = True
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(82, 12)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(75, 24)
        Me.btnGetData.TabIndex = 1
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnGetClients
        '
        Me.btnGetClients.Location = New System.Drawing.Point(190, 12)
        Me.btnGetClients.Name = "btnGetClients"
        Me.btnGetClients.Size = New System.Drawing.Size(80, 24)
        Me.btnGetClients.TabIndex = 2
        Me.btnGetClients.Text = "Get Clients"
        Me.btnGetClients.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(475, 215)
        Me.DataGridView1.TabIndex = 3
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataSource = GetType(ABC.Clients.Client)
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(402, 287)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(74, 26)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSelectLastItem
        '
        Me.btnSelectLastItem.Location = New System.Drawing.Point(46, 289)
        Me.btnSelectLastItem.Name = "btnSelectLastItem"
        Me.btnSelectLastItem.Size = New System.Drawing.Size(111, 23)
        Me.btnSelectLastItem.TabIndex = 5
        Me.btnSelectLastItem.Text = "Select Last Item"
        Me.btnSelectLastItem.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 344)
        Me.Controls.Add(Me.btnSelectLastItem)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnGetClients)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.btnShowSubform)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShowSubform As Button
    Friend WithEvents btnGetData As Button
    Friend WithEvents btnGetClients As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSelectLastItem As Button
End Class
