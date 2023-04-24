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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GameGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.ItemR3C3 = New System.Windows.Forms.PictureBox()
        Me.ItemR3C2 = New System.Windows.Forms.PictureBox()
        Me.ItemR3C1 = New System.Windows.Forms.PictureBox()
        Me.ItemR3C0 = New System.Windows.Forms.PictureBox()
        Me.ItemR2C3 = New System.Windows.Forms.PictureBox()
        Me.ItemR2C2 = New System.Windows.Forms.PictureBox()
        Me.ItemR2C1 = New System.Windows.Forms.PictureBox()
        Me.ItemR2C0 = New System.Windows.Forms.PictureBox()
        Me.ItemR1C3 = New System.Windows.Forms.PictureBox()
        Me.ItemR1C2 = New System.Windows.Forms.PictureBox()
        Me.ItemR1C1 = New System.Windows.Forms.PictureBox()
        Me.ItemR1C0 = New System.Windows.Forms.PictureBox()
        Me.ItemR0C3 = New System.Windows.Forms.PictureBox()
        Me.ItemR0C2 = New System.Windows.Forms.PictureBox()
        Me.ItemR0C1 = New System.Windows.Forms.PictureBox()
        Me.ItemR0C0 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scoreCounter = New System.Windows.Forms.Label()
        Me.GameGrid.SuspendLayout()
        CType(Me.ItemR3C3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR3C2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR3C1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR3C0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR2C3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR2C2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR2C1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR2C0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR1C3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR1C2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR1C1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR1C0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR0C3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR0C2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR0C1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemR0C0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Minecraft", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MATCHING GAME!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameGrid
        '
        Me.GameGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameGrid.BackColor = System.Drawing.Color.Transparent
        Me.GameGrid.BackgroundImage = Global.Matching_Game.My.Resources.Resources.oakBackground
        Me.GameGrid.ColumnCount = 4
        Me.GameGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.Controls.Add(Me.ItemR3C3, 3, 3)
        Me.GameGrid.Controls.Add(Me.ItemR3C2, 2, 3)
        Me.GameGrid.Controls.Add(Me.ItemR3C1, 1, 3)
        Me.GameGrid.Controls.Add(Me.ItemR3C0, 0, 3)
        Me.GameGrid.Controls.Add(Me.ItemR2C3, 3, 2)
        Me.GameGrid.Controls.Add(Me.ItemR2C2, 2, 2)
        Me.GameGrid.Controls.Add(Me.ItemR2C1, 1, 2)
        Me.GameGrid.Controls.Add(Me.ItemR2C0, 0, 2)
        Me.GameGrid.Controls.Add(Me.ItemR1C3, 3, 1)
        Me.GameGrid.Controls.Add(Me.ItemR1C2, 2, 1)
        Me.GameGrid.Controls.Add(Me.ItemR1C1, 1, 1)
        Me.GameGrid.Controls.Add(Me.ItemR1C0, 0, 1)
        Me.GameGrid.Controls.Add(Me.ItemR0C3, 3, 0)
        Me.GameGrid.Controls.Add(Me.ItemR0C2, 2, 0)
        Me.GameGrid.Controls.Add(Me.ItemR0C1, 1, 0)
        Me.GameGrid.Controls.Add(Me.ItemR0C0, 0, 0)
        Me.GameGrid.Location = New System.Drawing.Point(1, 58)
        Me.GameGrid.Name = "GameGrid"
        Me.GameGrid.RowCount = 4
        Me.GameGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.Size = New System.Drawing.Size(358, 348)
        Me.GameGrid.TabIndex = 1
        '
        'ItemR3C3
        '
        Me.ItemR3C3.BackColor = System.Drawing.Color.Transparent
        Me.ItemR3C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR3C3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR3C3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR3C3.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR3C3.Location = New System.Drawing.Point(270, 264)
        Me.ItemR3C3.Name = "ItemR3C3"
        Me.ItemR3C3.Size = New System.Drawing.Size(85, 81)
        Me.ItemR3C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR3C3.TabIndex = 15
        Me.ItemR3C3.TabStop = False
        '
        'ItemR3C2
        '
        Me.ItemR3C2.BackColor = System.Drawing.Color.Transparent
        Me.ItemR3C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR3C2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR3C2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR3C2.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR3C2.Location = New System.Drawing.Point(181, 264)
        Me.ItemR3C2.Name = "ItemR3C2"
        Me.ItemR3C2.Size = New System.Drawing.Size(83, 81)
        Me.ItemR3C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR3C2.TabIndex = 14
        Me.ItemR3C2.TabStop = False
        '
        'ItemR3C1
        '
        Me.ItemR3C1.BackColor = System.Drawing.Color.Transparent
        Me.ItemR3C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR3C1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR3C1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR3C1.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR3C1.Location = New System.Drawing.Point(92, 264)
        Me.ItemR3C1.Name = "ItemR3C1"
        Me.ItemR3C1.Size = New System.Drawing.Size(83, 81)
        Me.ItemR3C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR3C1.TabIndex = 13
        Me.ItemR3C1.TabStop = False
        '
        'ItemR3C0
        '
        Me.ItemR3C0.BackColor = System.Drawing.Color.Transparent
        Me.ItemR3C0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR3C0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR3C0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR3C0.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR3C0.Location = New System.Drawing.Point(3, 264)
        Me.ItemR3C0.Name = "ItemR3C0"
        Me.ItemR3C0.Size = New System.Drawing.Size(83, 81)
        Me.ItemR3C0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR3C0.TabIndex = 12
        Me.ItemR3C0.TabStop = False
        '
        'ItemR2C3
        '
        Me.ItemR2C3.BackColor = System.Drawing.Color.Transparent
        Me.ItemR2C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR2C3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR2C3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR2C3.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR2C3.Location = New System.Drawing.Point(270, 177)
        Me.ItemR2C3.Name = "ItemR2C3"
        Me.ItemR2C3.Size = New System.Drawing.Size(85, 81)
        Me.ItemR2C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR2C3.TabIndex = 11
        Me.ItemR2C3.TabStop = False
        '
        'ItemR2C2
        '
        Me.ItemR2C2.BackColor = System.Drawing.Color.Transparent
        Me.ItemR2C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR2C2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR2C2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR2C2.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR2C2.Location = New System.Drawing.Point(181, 177)
        Me.ItemR2C2.Name = "ItemR2C2"
        Me.ItemR2C2.Size = New System.Drawing.Size(83, 81)
        Me.ItemR2C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR2C2.TabIndex = 10
        Me.ItemR2C2.TabStop = False
        '
        'ItemR2C1
        '
        Me.ItemR2C1.BackColor = System.Drawing.Color.Transparent
        Me.ItemR2C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR2C1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR2C1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR2C1.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR2C1.Location = New System.Drawing.Point(92, 177)
        Me.ItemR2C1.Name = "ItemR2C1"
        Me.ItemR2C1.Size = New System.Drawing.Size(83, 81)
        Me.ItemR2C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR2C1.TabIndex = 9
        Me.ItemR2C1.TabStop = False
        '
        'ItemR2C0
        '
        Me.ItemR2C0.BackColor = System.Drawing.Color.Transparent
        Me.ItemR2C0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR2C0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR2C0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR2C0.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR2C0.Location = New System.Drawing.Point(3, 177)
        Me.ItemR2C0.Name = "ItemR2C0"
        Me.ItemR2C0.Size = New System.Drawing.Size(83, 81)
        Me.ItemR2C0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR2C0.TabIndex = 8
        Me.ItemR2C0.TabStop = False
        '
        'ItemR1C3
        '
        Me.ItemR1C3.BackColor = System.Drawing.Color.Transparent
        Me.ItemR1C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR1C3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR1C3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR1C3.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR1C3.Location = New System.Drawing.Point(270, 90)
        Me.ItemR1C3.Name = "ItemR1C3"
        Me.ItemR1C3.Size = New System.Drawing.Size(85, 81)
        Me.ItemR1C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR1C3.TabIndex = 7
        Me.ItemR1C3.TabStop = False
        '
        'ItemR1C2
        '
        Me.ItemR1C2.BackColor = System.Drawing.Color.Transparent
        Me.ItemR1C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR1C2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR1C2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR1C2.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR1C2.Location = New System.Drawing.Point(181, 90)
        Me.ItemR1C2.Name = "ItemR1C2"
        Me.ItemR1C2.Size = New System.Drawing.Size(83, 81)
        Me.ItemR1C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR1C2.TabIndex = 6
        Me.ItemR1C2.TabStop = False
        '
        'ItemR1C1
        '
        Me.ItemR1C1.BackColor = System.Drawing.Color.Transparent
        Me.ItemR1C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR1C1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR1C1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR1C1.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR1C1.Location = New System.Drawing.Point(92, 90)
        Me.ItemR1C1.Name = "ItemR1C1"
        Me.ItemR1C1.Size = New System.Drawing.Size(83, 81)
        Me.ItemR1C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR1C1.TabIndex = 5
        Me.ItemR1C1.TabStop = False
        '
        'ItemR1C0
        '
        Me.ItemR1C0.BackColor = System.Drawing.Color.Transparent
        Me.ItemR1C0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR1C0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR1C0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR1C0.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR1C0.Location = New System.Drawing.Point(3, 90)
        Me.ItemR1C0.Name = "ItemR1C0"
        Me.ItemR1C0.Size = New System.Drawing.Size(83, 81)
        Me.ItemR1C0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR1C0.TabIndex = 4
        Me.ItemR1C0.TabStop = False
        '
        'ItemR0C3
        '
        Me.ItemR0C3.BackColor = System.Drawing.Color.Transparent
        Me.ItemR0C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR0C3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR0C3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR0C3.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR0C3.Location = New System.Drawing.Point(270, 3)
        Me.ItemR0C3.Name = "ItemR0C3"
        Me.ItemR0C3.Size = New System.Drawing.Size(85, 81)
        Me.ItemR0C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR0C3.TabIndex = 3
        Me.ItemR0C3.TabStop = False
        '
        'ItemR0C2
        '
        Me.ItemR0C2.BackColor = System.Drawing.Color.Transparent
        Me.ItemR0C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR0C2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR0C2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR0C2.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR0C2.Location = New System.Drawing.Point(181, 3)
        Me.ItemR0C2.Name = "ItemR0C2"
        Me.ItemR0C2.Size = New System.Drawing.Size(83, 81)
        Me.ItemR0C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR0C2.TabIndex = 2
        Me.ItemR0C2.TabStop = False
        '
        'ItemR0C1
        '
        Me.ItemR0C1.BackColor = System.Drawing.Color.Transparent
        Me.ItemR0C1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR0C1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR0C1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR0C1.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR0C1.Location = New System.Drawing.Point(92, 3)
        Me.ItemR0C1.Name = "ItemR0C1"
        Me.ItemR0C1.Size = New System.Drawing.Size(83, 81)
        Me.ItemR0C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR0C1.TabIndex = 1
        Me.ItemR0C1.TabStop = False
        '
        'ItemR0C0
        '
        Me.ItemR0C0.BackColor = System.Drawing.Color.Transparent
        Me.ItemR0C0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR0C0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR0C0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR0C0.Image = Global.Matching_Game.My.Resources.Resources.Furnace
        Me.ItemR0C0.Location = New System.Drawing.Point(3, 3)
        Me.ItemR0C0.Name = "ItemR0C0"
        Me.ItemR0C0.Size = New System.Drawing.Size(83, 81)
        Me.ItemR0C0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR0C0.TabIndex = 0
        Me.ItemR0C0.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackgroundImage = Global.Matching_Game.My.Resources.Resources.DeepslateBackground
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 404)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(359, 113)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.scoreCounter)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(359, 36)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Minecraft", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Score:"
        '
        'scoreCounter
        '
        Me.scoreCounter.AutoSize = True
        Me.scoreCounter.BackColor = System.Drawing.Color.Transparent
        Me.scoreCounter.Font = New System.Drawing.Font("Minecraft", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreCounter.ForeColor = System.Drawing.Color.White
        Me.scoreCounter.Location = New System.Drawing.Point(84, 5)
        Me.scoreCounter.Margin = New System.Windows.Forms.Padding(5)
        Me.scoreCounter.Name = "scoreCounter"
        Me.scoreCounter.Size = New System.Drawing.Size(21, 23)
        Me.scoreCounter.TabIndex = 1
        Me.scoreCounter.Text = "x"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Matching_Game.My.Resources.Resources.StoneBackground1
        Me.ClientSize = New System.Drawing.Size(359, 517)
        Me.Controls.Add(Me.GameGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GameGrid.ResumeLayout(False)
        CType(Me.ItemR3C3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR3C2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR3C1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR3C0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR2C3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR2C2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR2C1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR2C0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR1C3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR1C2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR1C1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR1C0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR0C3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR0C2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR0C1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemR0C0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GameGrid As TableLayoutPanel
    Friend WithEvents ItemR0C0 As PictureBox
    Friend WithEvents ItemR3C3 As PictureBox
    Friend WithEvents ItemR3C2 As PictureBox
    Friend WithEvents ItemR3C1 As PictureBox
    Friend WithEvents ItemR3C0 As PictureBox
    Friend WithEvents ItemR2C3 As PictureBox
    Friend WithEvents ItemR2C2 As PictureBox
    Friend WithEvents ItemR2C1 As PictureBox
    Friend WithEvents ItemR2C0 As PictureBox
    Friend WithEvents ItemR1C3 As PictureBox
    Friend WithEvents ItemR1C2 As PictureBox
    Friend WithEvents ItemR1C1 As PictureBox
    Friend WithEvents ItemR1C0 As PictureBox
    Friend WithEvents ItemR0C3 As PictureBox
    Friend WithEvents ItemR0C2 As PictureBox
    Friend WithEvents ItemR0C1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents scoreCounter As Label
End Class
