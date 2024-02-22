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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Txtbox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Txtbox2 = New TextBox()
        Submit = New Button()
        Txtbox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Txtbox1
        ' 
        Txtbox1.Location = New Point(82, 88)
        Txtbox1.Name = "Txtbox1"
        Txtbox1.Size = New Size(100, 23)
        Txtbox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter the first number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(82, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 15)
        Label2.TabIndex = 2
        Label2.Text = "Enter the second number"
        ' 
        ' Txtbox2
        ' 
        Txtbox2.Location = New Point(82, 167)
        Txtbox2.Name = "Txtbox2"
        Txtbox2.Size = New Size(100, 23)
        Txtbox2.TabIndex = 3
        ' 
        ' Submit
        ' 
        Submit.Location = New Point(82, 228)
        Submit.Name = "Submit"
        Submit.Size = New Size(75, 23)
        Submit.TabIndex = 4
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = True
        ' 
        ' Txtbox3
        ' 
        Txtbox3.Location = New Point(82, 257)
        Txtbox3.Name = "Txtbox3"
        Txtbox3.Size = New Size(100, 23)
        Txtbox3.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(747, 543)
        Controls.Add(Txtbox3)
        Controls.Add(Submit)
        Controls.Add(Txtbox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Txtbox1)
        Name = "Form1"
        Text = "x"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txtbox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtbox2 As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Txtbox3 As TextBox

End Class
