Public Class Form1

  Dim Grid(4, 4) As Object
  Dim Ids = New List(Of Integer) From {1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8}
  Dim selectedId As Integer?
  Dim selectedObj As Object
  Dim canSelectBlock As Boolean
  Dim score As Integer
  Dim totalScore As Integer = 0

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Assign elements to Grid
    For rowIndex = 0 To GameGrid.RowCount - 1
      For colIndex = 0 To GameGrid.ColumnCount - 1
        Grid(colIndex, rowIndex) = GameGrid.GetControlFromPosition(colIndex, rowIndex)
      Next
    Next

    'Setup New Game
    newGame(totalScore)

    'Debug.WriteLine("Start")
  End Sub

  Sub newGame(prevScore As Integer)
    canSelectBlock = False

    'Refresh Block Grid
    For rowIndex = 0 To GameGrid.RowCount - 1
      For colIndex = 0 To GameGrid.ColumnCount - 1
        hideBlock(Grid(colIndex, rowIndex))
        Grid(colIndex, rowIndex).BackgroundImage = Nothing
        Grid(colIndex, rowIndex).Enabled = True
        Grid(colIndex, rowIndex).BackColor = Color.FromArgb(0, 0, 0, 0)
      Next
    Next

    score = 0
    scoreCounter.Text = score
    totalScore = prevScore
    totalScoreCounter.Text = totalScore
    'Shuffle IDs in list
    randomize(Ids)

    selectedId = Nothing
    selectedObj = Nothing

    canSelectBlock = True
  End Sub

  Sub winnerWindow()
    Dim result As DialogResult = MessageBox.Show("Would you like to play again?", "YOU ARE WINNER!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    If result = DialogResult.Yes Then
      newGame(totalScore)
    Else
      Close()
    End If
  End Sub

  Sub blockClick(Id As Integer, Display As Object)
    If canSelectBlock Then
      canSelectBlock = False
      If selectedId Is Nothing And selectedObj Is Nothing Then
        'If this is the first item selected

        selectedId = Id
        selectedObj = Display

        showBlock(Id, Display)

        Debug.WriteLine("SELECTED!")
      ElseIf selectedId = Id And selectedObj IsNot Display Then
        'If the second item matches the first
        markBlock(Display, selectedObj, 1)

        Display.Enabled = False
        selectedObj.Enabled = False

        showBlock(Id, Display)

        selectedId = Nothing
        selectedObj = Nothing

        score += 1
        scoreCounter.Text = score
        totalScore += 1
        totalScoreCounter.Text = totalScore

        If score = 8 Then
          winnerWindow()
          Debug.WriteLine("YOU ARE WINNER!")
        End If

        Debug.WriteLine("MATCH!")

      ElseIf selectedId <> Id And selectedObj IsNot Display Then
        'If the second item does not match
        markBlock(Display, selectedObj, 2)

        showBlock(Id, Display)

        wait(1)

        hideBlock(Display)
        hideBlock(selectedObj)

        markBlock(Display, selectedObj, 3)

        selectedId = Nothing
        selectedObj = Nothing

        Debug.WriteLine("WRONG!")
      End If
      canSelectBlock = True
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

  'List Shuffler
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
End Class
