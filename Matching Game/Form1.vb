Public Class Form1

  Dim Grid(4, 4) As Object
  Dim Ids = New List(Of Integer) From {1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8}
  Dim selectedId As Integer?
  Dim selectedObj As Object
  Dim canSelectBlock As Boolean
  Dim winScore As Integer
  Dim totalScore As Integer = 0
  Dim timeSpan As TimeSpan
  Dim totalMoves As Integer = 0
  Dim currentTime As Integer = 0

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Assign elements to Grid
    For rowIndex = 0 To GameGrid.RowCount - 1
      For colIndex = 0 To GameGrid.ColumnCount - 1
        Grid(colIndex, rowIndex) = GameGrid.GetControlFromPosition(colIndex, rowIndex)
      Next
    Next

    'Setup New Game
    newGame(totalScore)
    Debug.WriteLine("GAME START!")
  End Sub

  'New game function is responsible for resetting the entire game and mits various functions
  'New games should always start with a prevScore of (0)
  'prevScore allows for passing of the previous score if the newgame is created from the win condition
  Sub newGame(prevScore As Integer)
    'Disallow player from interacting with the grid
    canSelectBlock = False

    'LifeBar
    If prevScore = 0 Then
      LifeBar.Value = 8
    End If
    updateLifeBarVisual()

    'Timer function
    MatchTimer.Stop()
    currentTime = 0
    updateTimer()
    MatchTimer.Start()
    MatchTimer.Interval = 1000

    'Refresh Block Grid
    For rowIndex = 0 To GameGrid.RowCount - 1
      For colIndex = 0 To GameGrid.ColumnCount - 1
        hideBlock(Grid(colIndex, rowIndex))
        Grid(colIndex, rowIndex).BackgroundImage = Nothing
        Grid(colIndex, rowIndex).Enabled = True
        Grid(colIndex, rowIndex).BackColor = Color.FromArgb(0, 0, 0, 0)
      Next
    Next

    'Reset UI elements and related variables
    totalMoves = 0
    updateTotalMoves(totalMoves)
    winScore = 0
    totalScore = prevScore
    updateTotalScore(totalScore)

    'Shuffle IDs in list
    randomize(Ids)

    'Clear selections
    selectedId = Nothing
    selectedObj = Nothing

    'Allow player to interact with the grid again
    canSelectBlock = True
  End Sub

  'winnerWindow function is responsible for calculating any additional score the player may receive based on time and totalMoves
  'as well as providing the player a way to start a new round without losing their stats from the previous rounds
  Sub winnerWindow()
    MatchTimer.Stop()

    'Calculate additional score based on moves
    'Additional score is provided if maximum moves is less than the least amount of required moves (16) and an additional (8) moves
    'Additional score is based on the 8 additional score, therefor providing the player (8) total additional score that they can achieve
    If totalMoves < 24 Then
      totalMoves -= 16
      If totalMoves > 0 Then
        totalScore += (8 - totalMoves)
        Debug.WriteLine("ADDITIONAL SCORE ON MOVES: " & (8 - totalMoves))
      End If
    End If

    'Calculate additional score based on time
    'Additional score is provided if the game lasts not longer than (120) seconds
    'Additional score is based on the current time divided by (120) seconds, with a multiplier of (10), therefor providing the player (10) total additional score that they can achieve
    If currentTime < 120 Then
      totalScore += (10 - ((currentTime / 120) * 10))
      Debug.WriteLine("ADDITIONAL SCORE ON TIME: " & (10 - ((currentTime / 120) * 10)))
    End If

    updateTotalScore(totalScore)

    'Show winner Dialogue and proccede depending on result
    Dim result As DialogResult = MessageBox.Show("Would you like to play again?", "YOU ARE WINNER!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    If result = DialogResult.Yes Then
      newGame(totalScore)
    Else
      Close()
    End If
  End Sub

  'failWindow function is responsible for showing the player a fail dialogue and the ability to start a new game
  Sub failWindow()
    Dim result As DialogResult = MessageBox.Show("Would you like to play again?", "YOU ARE LOSER :(", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    If result = DialogResult.Yes Then
      newGame(0)
    Else
      Close()
    End If
  End Sub

  'blockClick is responsible for managing gameplay interactions and how they will react to said interactions
  Sub blockClick(Id As Integer, Display As Object)
    If canSelectBlock Then
      'Disallow player from interacting with the grid
      canSelectBlock = False
      If selectedId Is Nothing And selectedObj Is Nothing Then
        'If this is the first item selected

        selectedId = Id
        selectedObj = Display

        'Show clicked block
        showBlock(Id, Display)

        Debug.WriteLine("SELECTED!")
      ElseIf selectedId = Id And selectedObj IsNot Display Then
        'If the second item matches the first
        markBlock(Display, selectedObj, 1)

        Display.Enabled = False
        selectedObj.Enabled = False

        'Show clicked block
        showBlock(Id, Display)

        selectedId = Nothing
        selectedObj = Nothing

        'Life bar calculation
        If (LifeBar.Value = 7) Then
          LifeBar.Value = 8
        ElseIf (LifeBar.Value < 8) Then
          LifeBar.Value += 2
        End If

        'Moves Counter
        totalMoves += 1
        updateTotalMoves(totalMoves)
        winScore += 1

        'Score Counter
        totalScore += 1
        updateTotalScore(totalScore)

        'Win Condition
        If winScore = 8 Then
          winnerWindow()
          Debug.WriteLine("YOU ARE WINNER!")
        End If

        Debug.WriteLine("MATCH!")

      ElseIf selectedId <> Id And selectedObj IsNot Display Then
        'If the second item does not match
        markBlock(Display, selectedObj, 2)

        'Show selected block
        showBlock(Id, Display)

        'Wait 1 second to show player both blocks
        wait(1)

        'Rehide both blocks
        hideBlock(Display)
        hideBlock(selectedObj)

        markBlock(Display, selectedObj, 3)

        'Clear selection
        selectedId = Nothing
        selectedObj = Nothing

        'Moves Counter
        totalMoves += 1
        updateTotalMoves(totalMoves)

        'Fail and Lifebar condition
        If LifeBar.Value = 0 Then
          failWindow()
          Debug.WriteLine("YOU ARE LOSER :(")
        Else
          LifeBar.Value -= 1
        End If

        Debug.WriteLine("WRONG!")
      End If
      updateLifeBarVisual()
      'Allow player to interact with the grid again
      canSelectBlock = True
    End If
  End Sub

  Sub updateTotalMoves(totalMoves As String)
    totalMovesCounter.Text = "Total Moves: " & totalMoves
  End Sub

  Sub updateTotalScore(totalScore As String)
    totalScoreCounter.Text = "Total Score: " & totalScore
  End Sub

  Sub updateTimer()
    currentTime += 1
    timeSpan = TimeSpan.FromSeconds(currentTime)
    timerCount.Text = "Time: " & timeSpan.Hours.ToString.PadLeft(2, "0"c) & " : " & timeSpan.Minutes.ToString.PadLeft(2, "0"c) & " : " & timeSpan.Seconds.ToString.PadLeft(2, "0"c)
  End Sub

  Sub updateLifeBarVisual()
    If LifeBar.Value > 6 Then
      LifeBar.ForeColor = Color.Lime
    ElseIf LifeBar.Value > 4 Then
      LifeBar.ForeColor = Color.YellowGreen
    ElseIf LifeBar.Value > 2 Then
      LifeBar.ForeColor = Color.Orange
    Else
      LifeBar.ForeColor = Color.Red
    End If
  End Sub

  Sub markBlock(block1 As Object, block2 As Object, type As Integer)
    block1.BackgroundImageLayout = ImageLayout.Stretch
    block2.BackgroundImageLayout = ImageLayout.Stretch
    Select Case type
      Case 1
        block1.BackgroundImage = My.Resources.Correct1
        block2.BackgroundImage = My.Resources.Correct1
      Case 2
        block1.BackgroundImage = My.Resources.Wrong1
        block2.BackgroundImage = My.Resources.Wrong1
      Case 3
        block1.BackgroundImage = Nothing
        block2.BackgroundImage = Nothing
    End Select
  End Sub

  Sub hideBlock(Display As Object)
    Display.Image = My.Resources.Grass
  End Sub

  'Shows the block depending on ID
  Sub showBlock(Id As Integer, Display As Object)
    Select Case Id
      Case 1
        Display.Image = My.Resources.Birch
      Case 2
        Display.Image = My.Resources.CraftingTable
      Case 3
        Display.Image = My.Resources.DiamondOre
      Case 4
        Display.Image = My.Resources.Furnace
      Case 5
        Display.Image = My.Resources.Oak
      Case 6
        Display.Image = My.Resources.Slime
      Case 7
        Display.Image = My.Resources.Stone
      Case 8
        Display.Image = My.Resources.TNT
    End Select
  End Sub

  'Better Wait Function
  Sub wait(seconds As Integer)
    For i As Integer = 0 To seconds * 100
      Threading.Thread.Sleep(10)
      Application.DoEvents()
    Next
  End Sub

  'Mouse Feedback
  Sub mouseFeedback(type As Integer, block As Object)
    If canSelectBlock Then
      Select Case type
        Case 1
          block.BackColor = Color.FromArgb(75, 125, 125, 125)
        Case 2
          block.BackColor = Color.FromArgb(0, 0, 0, 0)
      End Select
    End If
  End Sub

  'List Shuffler based on Fisher Yates
  Function randomize(Of T)(list As List(Of T)) As List(Of T)
    Dim rand As New Random()
    Dim temp As T
    Dim indexRand As Integer
    Dim indexLast As Integer = list.Count - 1
    For index As Integer = 0 To indexLast
      indexRand = rand.Next(0, indexLast)
      temp = list(indexRand)
      list(indexRand) = list(index)
      list(index) = temp
    Next index
    Return list
  End Function

  'Image Display Events
  Private Sub ItemR0C0_MouseEnter(sender As Object, e As EventArgs) Handles ItemR0C0.MouseEnter
    mouseFeedback(1, ItemR0C0)
  End Sub

  Private Sub ItemR0C0_MouseLeave(sender As Object, e As EventArgs) Handles ItemR0C0.MouseLeave
    mouseFeedback(2, ItemR0C0)
  End Sub

  Private Sub ItemR0C0_Click(sender As Object, e As EventArgs) Handles ItemR0C0.Click
    blockClick(Ids(0), ItemR0C0)
  End Sub

  Private Sub ItemR0C1_MouseEnter(sender As Object, e As EventArgs) Handles ItemR0C1.MouseEnter
    mouseFeedback(1, ItemR0C1)
  End Sub

  Private Sub ItemR0C1_MouseLeave(sender As Object, e As EventArgs) Handles ItemR0C1.MouseLeave
    mouseFeedback(2, ItemR0C1)
  End Sub

  Private Sub ItemR0C1_Click(sender As Object, e As EventArgs) Handles ItemR0C1.Click
    blockClick(Ids(1), ItemR0C1)
  End Sub

  Private Sub ItemR0C2_MouseEnter(sender As Object, e As EventArgs) Handles ItemR0C2.MouseEnter
    mouseFeedback(1, ItemR0C2)
  End Sub

  Private Sub ItemR0C2_MouseLeave(sender As Object, e As EventArgs) Handles ItemR0C2.MouseLeave
    mouseFeedback(2, ItemR0C2)
  End Sub

  Private Sub ItemR0C2_Click(sender As Object, e As EventArgs) Handles ItemR0C2.Click
    blockClick(Ids(2), ItemR0C2)
  End Sub

  Private Sub ItemR0C3_MouseEnter(sender As Object, e As EventArgs) Handles ItemR0C3.MouseEnter
    mouseFeedback(1, ItemR0C3)
  End Sub

  Private Sub ItemR0C3_MouseLeave(sender As Object, e As EventArgs) Handles ItemR0C3.MouseLeave
    mouseFeedback(2, ItemR0C3)
  End Sub

  Private Sub ItemR0C3_Click(sender As Object, e As EventArgs) Handles ItemR0C3.Click
    blockClick(Ids(3), ItemR0C3)
  End Sub

  Private Sub ItemR1C0_MouseEnter(sender As Object, e As EventArgs) Handles ItemR1C0.MouseEnter
    mouseFeedback(1, ItemR1C0)
  End Sub

  Private Sub ItemR1C0_MouseLeave(sender As Object, e As EventArgs) Handles ItemR1C0.MouseLeave
    mouseFeedback(2, ItemR1C0)
  End Sub

  Private Sub ItemR1C0_Click(sender As Object, e As EventArgs) Handles ItemR1C0.Click
    blockClick(Ids(4), ItemR1C0)
  End Sub

  Private Sub ItemR1C1_MouseEnter(sender As Object, e As EventArgs) Handles ItemR1C1.MouseEnter
    mouseFeedback(1, ItemR1C1)
  End Sub

  Private Sub ItemR1C1_MouseLeave(sender As Object, e As EventArgs) Handles ItemR1C1.MouseLeave
    mouseFeedback(2, ItemR1C1)
  End Sub

  Private Sub ItemR1C1_Click(sender As Object, e As EventArgs) Handles ItemR1C1.Click
    blockClick(Ids(5), ItemR1C1)
  End Sub
  Private Sub ItemR1C2_MouseEnter(sender As Object, e As EventArgs) Handles ItemR1C2.MouseEnter
    mouseFeedback(1, ItemR1C2)
  End Sub

  Private Sub ItemR1C2_MouseLeave(sender As Object, e As EventArgs) Handles ItemR1C2.MouseLeave
    mouseFeedback(2, ItemR1C2)
  End Sub

  Private Sub ItemR1C2_Click(sender As Object, e As EventArgs) Handles ItemR1C2.Click
    blockClick(Ids(6), ItemR1C2)
  End Sub

  Private Sub ItemR1C3_MouseEnter(sender As Object, e As EventArgs) Handles ItemR1C3.MouseEnter
    mouseFeedback(1, ItemR1C3)
  End Sub

  Private Sub ItemR1C3_MouseLeave(sender As Object, e As EventArgs) Handles ItemR1C3.MouseLeave
    mouseFeedback(2, ItemR1C3)
  End Sub

  Private Sub ItemR1C3_Click(sender As Object, e As EventArgs) Handles ItemR1C3.Click
    blockClick(Ids(7), ItemR1C3)
  End Sub

  Private Sub ItemR2C0_MouseEnter(sender As Object, e As EventArgs) Handles ItemR2C0.MouseEnter
    mouseFeedback(1, ItemR2C0)
  End Sub

  Private Sub ItemR2C0_MouseLeave(sender As Object, e As EventArgs) Handles ItemR2C0.MouseLeave
    mouseFeedback(2, ItemR2C0)
  End Sub

  Private Sub ItemR2C0_Click(sender As Object, e As EventArgs) Handles ItemR2C0.Click
    blockClick(Ids(8), ItemR2C0)
  End Sub

  Private Sub ItemR2C1_MouseEnter(sender As Object, e As EventArgs) Handles ItemR2C1.MouseEnter
    mouseFeedback(1, ItemR2C1)
  End Sub

  Private Sub ItemR2C1_MouseLeave(sender As Object, e As EventArgs) Handles ItemR2C1.MouseLeave
    mouseFeedback(2, ItemR2C1)
  End Sub

  Private Sub ItemR2C1_Click(sender As Object, e As EventArgs) Handles ItemR2C1.Click
    blockClick(Ids(9), ItemR2C1)
  End Sub

  Private Sub ItemR2C2_MouseEnter(sender As Object, e As EventArgs) Handles ItemR2C2.MouseEnter
    mouseFeedback(1, ItemR2C2)
  End Sub

  Private Sub ItemR2C2_MouseLeave(sender As Object, e As EventArgs) Handles ItemR2C2.MouseLeave
    mouseFeedback(2, ItemR2C2)
  End Sub

  Private Sub ItemR2C2_Click(sender As Object, e As EventArgs) Handles ItemR2C2.Click
    blockClick(Ids(10), ItemR2C2)
  End Sub

  Private Sub ItemR2C3_MouseEnter(sender As Object, e As EventArgs) Handles ItemR2C3.MouseEnter
    mouseFeedback(1, ItemR2C3)
  End Sub

  Private Sub ItemR2C3_MouseLeave(sender As Object, e As EventArgs) Handles ItemR2C3.MouseLeave
    mouseFeedback(2, ItemR2C3)
  End Sub

  Private Sub ItemR2C3_Click(sender As Object, e As EventArgs) Handles ItemR2C3.Click
    blockClick(Ids(11), ItemR2C3)
  End Sub

  Private Sub ItemR3C0_MouseEnter(sender As Object, e As EventArgs) Handles ItemR3C0.MouseEnter
    mouseFeedback(1, ItemR3C0)
  End Sub

  Private Sub ItemR3C0_MouseLeave(sender As Object, e As EventArgs) Handles ItemR3C0.MouseLeave
    mouseFeedback(2, ItemR3C0)
  End Sub

  Private Sub ItemR3C0_Click(sender As Object, e As EventArgs) Handles ItemR3C0.Click
    blockClick(Ids(12), ItemR3C0)
  End Sub

  Private Sub ItemR3C1_MouseEnter(sender As Object, e As EventArgs) Handles ItemR3C1.MouseEnter
    mouseFeedback(1, ItemR3C1)
  End Sub

  Private Sub ItemR3C1_MouseLeave(sender As Object, e As EventArgs) Handles ItemR3C1.MouseLeave
    mouseFeedback(2, ItemR3C1)
  End Sub

  Private Sub ItemR3C1_Click(sender As Object, e As EventArgs) Handles ItemR3C1.Click
    blockClick(Ids(13), ItemR3C1)
  End Sub

  Private Sub ItemR3C2_MouseEnter(sender As Object, e As EventArgs) Handles ItemR3C2.MouseEnter
    mouseFeedback(1, ItemR3C2)
  End Sub

  Private Sub ItemR3C2_MouseLeave(sender As Object, e As EventArgs) Handles ItemR3C2.MouseLeave
    mouseFeedback(2, ItemR3C2)
  End Sub

  Private Sub ItemR3C2_Click(sender As Object, e As EventArgs) Handles ItemR3C2.Click
    blockClick(Ids(14), ItemR3C2)
  End Sub

  Private Sub ItemR3C3_MouseEnter(sender As Object, e As EventArgs) Handles ItemR3C3.MouseEnter
    mouseFeedback(1, ItemR3C3)
  End Sub

  Private Sub ItemR3C3_MouseLeave(sender As Object, e As EventArgs) Handles ItemR3C3.MouseLeave
    mouseFeedback(2, ItemR3C3)
  End Sub

  Private Sub ItemR3C3_Click(sender As Object, e As EventArgs) Handles ItemR3C3.Click
    blockClick(Ids(15), ItemR3C3)
  End Sub

  Private Sub newGameButton_Click(sender As Object, e As EventArgs) Handles newGameButton.Click
    newGame(0)
  End Sub

  Private Sub MatchTimer_Tick(sender As Object, e As EventArgs) Handles MatchTimer.Tick
    updateTimer()
  End Sub
End Class
