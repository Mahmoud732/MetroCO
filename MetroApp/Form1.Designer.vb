<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Label1 = New Label()
        cbStart = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        tecketlbl = New Label()
        lblResult = New Label()
        timelbl = New Label()
        pathlbl = New Label()
        Button1 = New Button()
        btnCalculate = New Button()
        Label2 = New Label()
        cbEnd = New ComboBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 41)
        Label1.TabIndex = 1
        Label1.Text = "Start Station :"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbStart
        ' 
        cbStart.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cbStart.FormattingEnabled = True
        cbStart.Location = New Point(153, 6)
        cbStart.Name = "cbStart"
        cbStart.Size = New Size(361, 28)
        cbStart.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(110, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(298, 45)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(97, 117)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 20)
        Label8.TabIndex = 12
        ' 
        ' tecketlbl
        ' 
        tecketlbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        tecketlbl.AutoSize = True
        tecketlbl.Location = New Point(3, 82)
        tecketlbl.Name = "tecketlbl"
        tecketlbl.Size = New Size(92, 41)
        tecketlbl.TabIndex = 11
        tecketlbl.Text = "Ticket price :"
        tecketlbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblResult
        ' 
        lblResult.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblResult.AutoSize = True
        lblResult.Location = New Point(153, 82)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(104, 41)
        lblResult.TabIndex = 5
        lblResult.Text = "Shortest path :"
        lblResult.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' timelbl
        ' 
        timelbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        timelbl.AutoSize = True
        timelbl.Location = New Point(3, 123)
        timelbl.Name = "timelbl"
        timelbl.Size = New Size(87, 41)
        timelbl.TabIndex = 7
        timelbl.Text = "Total time  :"
        timelbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pathlbl
        ' 
        pathlbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pathlbl.AutoSize = True
        pathlbl.Location = New Point(153, 123)
        pathlbl.Name = "pathlbl"
        pathlbl.Size = New Size(44, 41)
        pathlbl.TabIndex = 6
        pathlbl.Text = "Path: "
        pathlbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.Location = New Point(3, 174)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 27)
        Button1.TabIndex = 10
        Button1.Text = "Map"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCalculate.Location = New Point(420, 173)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(3, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 41)
        Label2.TabIndex = 3
        Label2.Text = "End Station :"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbEnd
        ' 
        cbEnd.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cbEnd.FormattingEnabled = True
        cbEnd.Location = New Point(153, 47)
        cbEnd.Name = "cbEnd"
        cbEnd.Size = New Size(361, 28)
        cbEnd.TabIndex = 2
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(tecketlbl, 0, 2)
        TableLayoutPanel2.Controls.Add(timelbl, 0, 3)
        TableLayoutPanel2.Controls.Add(Button1, 0, 4)
        TableLayoutPanel2.Controls.Add(pathlbl, 1, 3)
        TableLayoutPanel2.Controls.Add(lblResult, 1, 2)
        TableLayoutPanel2.Controls.Add(Label2, 0, 1)
        TableLayoutPanel2.Controls.Add(Label1, 0, 0)
        TableLayoutPanel2.Controls.Add(cbStart, 1, 0)
        TableLayoutPanel2.Controls.Add(cbEnd, 1, 1)
        TableLayoutPanel2.Controls.Add(btnCalculate, 1, 4)
        TableLayoutPanel2.Location = New Point(12, 12)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(517, 205)
        TableLayoutPanel2.TabIndex = 14
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(541, 229)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "form1"
        Text = "Metro CO"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbStart As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbEnd As ComboBox
    Friend WithEvents tecketlbl As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents timelbl As Label
    Friend WithEvents pathlbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel

End Class