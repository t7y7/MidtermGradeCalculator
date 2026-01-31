<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BtnCompute = New Button()
        TxtStud = New TextBox()
        TxtMidterm = New TextBox()
        LblStud = New Label()
        LblMidterm = New Label()
        TxtID = New TextBox()
        LblID = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        LblD1 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnCompute
        ' 
        BtnCompute.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCompute.Location = New Point(331, 395)
        BtnCompute.Name = "BtnCompute"
        BtnCompute.Size = New Size(143, 29)
        BtnCompute.TabIndex = 0
        BtnCompute.Text = "Compute"
        BtnCompute.UseVisualStyleBackColor = True
        ' 
        ' TxtStud
        ' 
        TxtStud.Location = New Point(124, 184)
        TxtStud.Name = "TxtStud"
        TxtStud.Size = New Size(198, 27)
        TxtStud.TabIndex = 1
        TxtStud.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtMidterm
        ' 
        TxtMidterm.Location = New Point(504, 182)
        TxtMidterm.Name = "TxtMidterm"
        TxtMidterm.Size = New Size(155, 27)
        TxtMidterm.TabIndex = 2
        TxtMidterm.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblStud
        ' 
        LblStud.AutoSize = True
        LblStud.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStud.ForeColor = Color.LightPink
        LblStud.Location = New Point(188, 161)
        LblStud.Name = "LblStud"
        LblStud.Size = New Size(71, 18)
        LblStud.TabIndex = 3
        LblStud.Text = "Student"
        ' 
        ' LblMidterm
        ' 
        LblMidterm.AutoSize = True
        LblMidterm.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblMidterm.ForeColor = Color.LightPink
        LblMidterm.Location = New Point(524, 161)
        LblMidterm.Name = "LblMidterm"
        LblMidterm.Size = New Size(120, 18)
        LblMidterm.TabIndex = 4
        LblMidterm.Text = "Midterm Grade"
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(349, 184)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(125, 27)
        TxtID.TabIndex = 5
        TxtID.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblID
        ' 
        LblID.AutoSize = True
        LblID.Font = New Font("Pixelify Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblID.ForeColor = Color.LightPink
        LblID.Location = New Point(398, 161)
        LblID.Name = "LblID"
        LblID.Size = New Size(23, 18)
        LblID.TabIndex = 6
        LblID.Text = "ID"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(539, 239)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(287, 255)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-28, 239)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(287, 255)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' LblD1
        ' 
        LblD1.AutoSize = True
        LblD1.Font = New Font("00 Starmap Truetype", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblD1.Location = New Point(107, 74)
        LblD1.Name = "LblD1"
        LblD1.Size = New Size(585, 35)
        LblD1.TabIndex = 10
        LblD1.Text = "MIDTERM GRADE CALCULATOR"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(800, 450)
        Controls.Add(LblD1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(LblID)
        Controls.Add(TxtID)
        Controls.Add(LblMidterm)
        Controls.Add(LblStud)
        Controls.Add(TxtMidterm)
        Controls.Add(TxtStud)
        Controls.Add(BtnCompute)
        ForeColor = Color.LightPink
        Name = "Form1"
        Text = "Midterm Grade Calculator"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCompute As Button
    Friend WithEvents TxtStud As TextBox
    Friend WithEvents TxtMidterm As TextBox
    Friend WithEvents LblStud As Label
    Friend WithEvents LblMidterm As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LblID As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblD1 As Label

End Class
