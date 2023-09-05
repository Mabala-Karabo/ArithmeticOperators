<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        txtNum1 = New Label()
        txtNum2 = New Label()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(459, 28)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(150, 31)
        txtNumber1.TabIndex = 0
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(459, 87)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(150, 31)
        txtNumber2.TabIndex = 1
        ' 
        ' txtNum1
        ' 
        txtNum1.AutoSize = True
        txtNum1.Location = New Point(293, 31)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(160, 25)
        txtNum1.TabIndex = 2
        txtNum1.Text = "Enter First Number"
        ' 
        ' txtNum2
        ' 
        txtNum2.AutoSize = True
        txtNum2.Location = New Point(267, 93)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(186, 25)
        txtNum2.TabIndex = 3
        txtNum2.Text = "Enter Second Number"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(351, 187)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(149, 81)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(txtNumber2)
        Controls.Add(txtNumber1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txtNum1 As Label
    Friend WithEvents txtNum2 As Label
    Friend WithEvents btnCalculate As Button
End Class
