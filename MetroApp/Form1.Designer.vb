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
        Label2 = New Label()
        cbEnd = New ComboBox()
        btnCalculate = New Button()
        lblResult = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 1
        Label1.Text = "Start Station:"
        ' 
        ' cbStart
        ' 
        cbStart.FormattingEnabled = True
        cbStart.Location = New Point(98, 9)
        cbStart.Margin = New Padding(3, 2, 3, 2)
        cbStart.Name = "cbStart"
        cbStart.Size = New Size(133, 23)
        cbStart.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 3
        Label2.Text = "End Station:"
        ' 
        ' cbEnd
        ' 
        cbEnd.FormattingEnabled = True
        cbEnd.Location = New Point(98, 34)
        cbEnd.Margin = New Padding(3, 2, 3, 2)
        cbEnd.Name = "cbEnd"
        cbEnd.Size = New Size(133, 23)
        cbEnd.TabIndex = 2
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCalculate.Location = New Point(10, 130)
        btnCalculate.Margin = New Padding(3, 2, 3, 2)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(82, 22)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(10, 58)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(80, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "Shortest path:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(261, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 15)
        Label3.TabIndex = 6
        Label3.Text = "Inter Change Station"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 7
        Label4.Text = "Total time  :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(96, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(261, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 9
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(469, 160)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblResult)
        Controls.Add(btnCalculate)
        Controls.Add(Label2)
        Controls.Add(cbEnd)
        Controls.Add(Label1)
        Controls.Add(cbStart)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "form1"
        Text = "Metro CO"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbStart As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbEnd As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
