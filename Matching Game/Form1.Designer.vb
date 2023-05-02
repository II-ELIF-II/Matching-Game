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
        Me.components = New System.ComponentModel.Container()
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
        Me.timerCount = New System.Windows.Forms.Label()
        Me.totalMovesCounter = New System.Windows.Forms.Label()
        Me.totalScoreCounter = New System.Windows.Forms.Label()
        Me.newGameButton = New System.Windows.Forms.Button()
        Me.MatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LifeBar = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(359, 60)
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
        Me.GameGrid.Padding = New System.Windows.Forms.Padding(0, 7, 0, 7)
        Me.GameGrid.RowCount = 4
        Me.GameGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.GameGrid.Size = New System.Drawing.Size(358, 323)
        Me.GameGrid.TabIndex = 1
        '
        'ItemR3C3
        '
        Me.ItemR3C3.BackColor = System.Drawing.Color.Transparent
        Me.ItemR3C3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ItemR3C3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR3C3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR3C3.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR3C3.Location = New System.Drawing.Point(272, 243)
        Me.ItemR3C3.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR3C3.Name = "ItemR3C3"
        Me.ItemR3C3.Size = New System.Drawing.Size(81, 68)
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
        Me.ItemR3C2.Location = New System.Drawing.Point(183, 243)
        Me.ItemR3C2.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR3C2.Name = "ItemR3C2"
        Me.ItemR3C2.Size = New System.Drawing.Size(79, 68)
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
        Me.ItemR3C1.Location = New System.Drawing.Point(94, 243)
        Me.ItemR3C1.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR3C1.Name = "ItemR3C1"
        Me.ItemR3C1.Size = New System.Drawing.Size(79, 68)
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
        Me.ItemR3C0.Location = New System.Drawing.Point(5, 243)
        Me.ItemR3C0.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR3C0.Name = "ItemR3C0"
        Me.ItemR3C0.Size = New System.Drawing.Size(79, 68)
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
        Me.ItemR2C3.Location = New System.Drawing.Point(272, 166)
        Me.ItemR2C3.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR2C3.Name = "ItemR2C3"
        Me.ItemR2C3.Size = New System.Drawing.Size(81, 67)
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
        Me.ItemR2C2.Location = New System.Drawing.Point(183, 166)
        Me.ItemR2C2.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR2C2.Name = "ItemR2C2"
        Me.ItemR2C2.Size = New System.Drawing.Size(79, 67)
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
        Me.ItemR2C1.Location = New System.Drawing.Point(94, 166)
        Me.ItemR2C1.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR2C1.Name = "ItemR2C1"
        Me.ItemR2C1.Size = New System.Drawing.Size(79, 67)
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
        Me.ItemR2C0.Location = New System.Drawing.Point(5, 166)
        Me.ItemR2C0.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR2C0.Name = "ItemR2C0"
        Me.ItemR2C0.Size = New System.Drawing.Size(79, 67)
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
        Me.ItemR1C3.Location = New System.Drawing.Point(272, 89)
        Me.ItemR1C3.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR1C3.Name = "ItemR1C3"
        Me.ItemR1C3.Size = New System.Drawing.Size(81, 67)
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
        Me.ItemR1C2.Location = New System.Drawing.Point(183, 89)
        Me.ItemR1C2.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR1C2.Name = "ItemR1C2"
        Me.ItemR1C2.Size = New System.Drawing.Size(79, 67)
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
        Me.ItemR1C1.Location = New System.Drawing.Point(94, 89)
        Me.ItemR1C1.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR1C1.Name = "ItemR1C1"
        Me.ItemR1C1.Size = New System.Drawing.Size(79, 67)
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
        Me.ItemR1C0.Location = New System.Drawing.Point(5, 89)
        Me.ItemR1C0.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR1C0.Name = "ItemR1C0"
        Me.ItemR1C0.Size = New System.Drawing.Size(79, 67)
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
        Me.ItemR0C3.Location = New System.Drawing.Point(272, 12)
        Me.ItemR0C3.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR0C3.Name = "ItemR0C3"
        Me.ItemR0C3.Size = New System.Drawing.Size(81, 67)
        Me.ItemR0C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR0C3.TabIndex = 3
        Me.ItemR0C3.TabStop = False
        '
        'ItemR0C2
        '
        Me.ItemR0C2.BackColor = System.Drawing.Color.Transparent
        Me.ItemR0C2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ItemR0C2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ItemR0C2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemR0C2.Image = Global.Matching_Game.My.Resources.Resources.Grass
        Me.ItemR0C2.Location = New System.Drawing.Point(183, 12)
        Me.ItemR0C2.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR0C2.Name = "ItemR0C2"
        Me.ItemR0C2.Size = New System.Drawing.Size(79, 67)
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
        Me.ItemR0C1.Location = New System.Drawing.Point(94, 12)
        Me.ItemR0C1.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR0C1.Name = "ItemR0C1"
        Me.ItemR0C1.Size = New System.Drawing.Size(79, 67)
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
        Me.ItemR0C0.Location = New System.Drawing.Point(5, 12)
        Me.ItemR0C0.Margin = New System.Windows.Forms.Padding(5)
        Me.ItemR0C0.Name = "ItemR0C0"
        Me.ItemR0C0.Size = New System.Drawing.Size(79, 67)
        Me.ItemR0C0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemR0C0.TabIndex = 0
        Me.ItemR0C0.TabStop = False
        '
        'timerCount
        '
        Me.timerCount.AutoSize = True
        Me.timerCount.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.SetColumnSpan(Me.timerCount, 2)
        Me.timerCount.Font = New System.Drawing.Font("Minecraft", 13.0!)
        Me.timerCount.ForeColor = System.Drawing.Color.White
        Me.timerCount.Location = New System.Drawing.Point(94, 5)
        Me.timerCount.Margin = New System.Windows.Forms.Padding(5)
        Me.timerCount.Name = "timerCount"
        Me.timerCount.Size = New System.Drawing.Size(80, 19)
        Me.timerCount.TabIndex = 5
        Me.timerCount.Text = "Timer: 0"
        '
        'totalMovesCounter
        '
        Me.totalMovesCounter.AutoSize = True
        Me.totalMovesCounter.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.SetColumnSpan(Me.totalMovesCounter, 2)
        Me.totalMovesCounter.Font = New System.Drawing.Font("Minecraft", 13.0!)
        Me.totalMovesCounter.ForeColor = System.Drawing.Color.White
        Me.totalMovesCounter.Location = New System.Drawing.Point(5, 34)
        Me.totalMovesCounter.Margin = New System.Windows.Forms.Padding(5)
        Me.totalMovesCounter.Name = "totalMovesCounter"
        Me.totalMovesCounter.Size = New System.Drawing.Size(139, 19)
        Me.totalMovesCounter.TabIndex = 4
        Me.totalMovesCounter.Text = "Total Moves: 0"
        '
        'totalScoreCounter
        '
        Me.totalScoreCounter.AutoSize = True
        Me.totalScoreCounter.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.SetColumnSpan(Me.totalScoreCounter, 2)
        Me.totalScoreCounter.Font = New System.Drawing.Font("Minecraft", 13.0!)
        Me.totalScoreCounter.ForeColor = System.Drawing.Color.White
        Me.totalScoreCounter.Location = New System.Drawing.Point(183, 34)
        Me.totalScoreCounter.Margin = New System.Windows.Forms.Padding(5)
        Me.totalScoreCounter.Name = "totalScoreCounter"
        Me.totalScoreCounter.Size = New System.Drawing.Size(139, 19)
        Me.totalScoreCounter.TabIndex = 3
        Me.totalScoreCounter.Text = "Total Score: 0"
        '
        'newGameButton
        '
        Me.newGameButton.BackColor = System.Drawing.Color.Transparent
        Me.newGameButton.BackgroundImage = Global.Matching_Game.My.Resources.Resources.button
        Me.newGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel3.SetColumnSpan(Me.newGameButton, 2)
        Me.newGameButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newGameButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.newGameButton.FlatAppearance.BorderSize = 0
        Me.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newGameButton.Font = New System.Drawing.Font("Minecraft", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newGameButton.ForeColor = System.Drawing.Color.White
        Me.newGameButton.Location = New System.Drawing.Point(92, 119)
        Me.newGameButton.Name = "newGameButton"
        Me.newGameButton.Size = New System.Drawing.Size(172, 45)
        Me.newGameButton.TabIndex = 0
        Me.newGameButton.Text = "NEW GAME"
        Me.newGameButton.UseVisualStyleBackColor = False
        '
        'MatchTimer
        '
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Matching_Game.My.Resources.Resources.DeepslateBackground
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 380)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 167)
        Me.Panel1.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.newGameButton, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.totalMovesCounter, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.totalScoreCounter, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.timerCount, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LifeBar, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(359, 167)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'LifeBar
        '
        Me.LifeBar.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel3.SetColumnSpan(Me.LifeBar, 3)
        Me.LifeBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LifeBar.Location = New System.Drawing.Point(92, 61)
        Me.LifeBar.MarqueeAnimationSpeed = 50
        Me.LifeBar.Maximum = 8
        Me.LifeBar.Name = "LifeBar"
        Me.LifeBar.Size = New System.Drawing.Size(264, 23)
        Me.LifeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LifeBar.TabIndex = 6
        Me.LifeBar.Value = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Minecraft", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lives:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Matching_Game.My.Resources.Resources.StoneBackground1
        Me.ClientSize = New System.Drawing.Size(359, 547)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GameGrid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Matching Game!"
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
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
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
    Friend WithEvents totalScoreCounter As Label
    Friend WithEvents newGameButton As Button
    Friend WithEvents MatchTimer As Timer
    Friend WithEvents totalMovesCounter As Label
    Friend WithEvents timerCount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LifeBar As ProgressBar
    Friend WithEvents Label2 As Label
End Class
