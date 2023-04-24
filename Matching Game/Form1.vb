Public Class Form1

  Dim Grid(4, 4) As Object
  Dim Seed As New Random
  Dim Ids = New List(Of Integer) From {1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8}
  Dim selectedId As Integer?
  Dim selectedObj As Object
  Dim canSelectBlock As Boolean = True
  Dim score As Integer = 0

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Assign elements to Grid
    For rowIndex = 0 To GameGrid.RowCount - 1
      For colIndex = 0 To GameGrid.ColumnCount - 1
        Grid(colIndex, rowIndex) = GameGrid.GetControlFromPosition(colIndex, rowIndex)
        Grid(colIndex, rowIndex).Image = My.Resources.Grass
        'Debug.WriteLine(rowIndex & "," & colIndex & "," & Grid(colIndex, rowIndex).Name)
      Next
    Next

    'Shuffle Ids
    randomize(Ids)
    For Each Id In Ids
      Debug.WriteLine(Id)
    Next

  End Sub

  Sub newGame()
    For Each block In Grid
      block.Image = My.Resources.Grass
    Next
  End Sub

  Sub blockClick(Id As Integer, Display As Object)
    If selectedId Is Nothing And selectedObj Is Nothing And canSelectBlock Then
      selectedId = Id
      selectedObj = Display

      showBlock(Id, Display)
      Debug.WriteLine("SELECTED!")
    ElseIf selectedId = Id And selectedObj IsNot Display And canSelectBlock Then
      Display.Enabled = False
      selectedObj.Enabled = False

      selectedId = Nothing
      selectedObj = Nothing

      showBlock(Id, Display)
      score += 1
      scoreCounter.Text = score
      Debug.WriteLine("MATCH!")
    ElseIf selectedId <> Id And selectedObj IsNot Display And canSelectBlock Then

      showBlock(Id, Display)
      canSelectBlock = False

      wait(1)

      canSelectBlock = True
      hideBlock(Display)
      hideBlock(selectedObj)

      selectedId = Nothing
      selectedObj = Nothing

      Debug.WriteLine("WRONG!")
    End If
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

  'Yoinked randomizer code
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
    ItemR0C0.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR0C0_MouseLeave(sender As Object, e As EventArgs) Handles ItemR0C0.MouseLeave
    ItemR0C0.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR0C0_Click(sender As Object, e As EventArgs) Handles ItemR0C0.Click
    blockClick(Ids(0), ItemR0C0)
    ItemR0C0.BackColor = Color.FromArgb(50, 0, 0, 0)
  End Sub

  Private Sub ItemR0C1_MouseEnter(sender As Object, e As EventArgs) Handles ItemR0C1.MouseEnter
    ItemR0C1.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR0C1_MouseLeave(sender As Object, e As EventArgs) Handles ItemR0C1.MouseLeave
    ItemR0C1.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR0C1_Click(sender As Object, e As EventArgs) Handles ItemR0C1.Click
    blockClick(Ids(1), ItemR0C1)
  End Sub

  Private Sub ItemR0C2_MouseEnter(sender As Object, e As EventArgs) Handles ItemR0C2.MouseEnter
    ItemR0C2.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR0C2_MouseLeave(sender As Object, e As EventArgs) Handles ItemR0C2.MouseLeave
    ItemR0C2.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR0C2_Click(sender As Object, e As EventArgs) Handles ItemR0C2.Click
    blockClick(Ids(2), ItemR0C2)
  End Sub

  Private Sub ItemR0C3_MouseEnter(sender As Object, e As EventArgs) Handles ItemR0C3.MouseEnter
    ItemR0C3.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR0C3_MouseLeave(sender As Object, e As EventArgs) Handles ItemR0C3.MouseLeave
    ItemR0C3.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR0C3_Click(sender As Object, e As EventArgs) Handles ItemR0C3.Click
    blockClick(Ids(3), ItemR0C3)
  End Sub

  Private Sub ItemR1C0_MouseEnter(sender As Object, e As EventArgs) Handles ItemR1C0.MouseEnter
    ItemR1C0.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR1C0_MouseLeave(sender As Object, e As EventArgs) Handles ItemR1C0.MouseLeave
    ItemR1C0.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR1C0_Click(sender As Object, e As EventArgs) Handles ItemR1C0.Click
    blockClick(Ids(4), ItemR1C0)
  End Sub

  Private Sub ItemR1C1_MouseEnter(sender As Object, e As EventArgs) Handles ItemR1C1.MouseEnter
    ItemR1C1.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR1C1_MouseLeave(sender As Object, e As EventArgs) Handles ItemR1C1.MouseLeave
    ItemR1C1.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR1C1_Click(sender As Object, e As EventArgs) Handles ItemR1C1.Click
    blockClick(Ids(5), ItemR1C1)
  End Sub
  Private Sub ItemR1C2_MouseEnter(sender As Object, e As EventArgs) Handles ItemR1C2.MouseEnter
    ItemR1C2.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR1C2_MouseLeave(sender As Object, e As EventArgs) Handles ItemR1C2.MouseLeave
    ItemR1C2.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR1C2_Click(sender As Object, e As EventArgs) Handles ItemR1C2.Click
    blockClick(Ids(6), ItemR1C2)
  End Sub

  Private Sub ItemR1C3_MouseEnter(sender As Object, e As EventArgs) Handles ItemR1C3.MouseEnter
    ItemR1C3.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR1C3_MouseLeave(sender As Object, e As EventArgs) Handles ItemR1C3.MouseLeave
    ItemR1C3.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR1C3_Click(sender As Object, e As EventArgs) Handles ItemR1C3.Click
    blockClick(Ids(7), ItemR1C3)
  End Sub

  Private Sub ItemR2C0_MouseEnter(sender As Object, e As EventArgs) Handles ItemR2C0.MouseEnter
    ItemR2C0.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR2C0_MouseLeave(sender As Object, e As EventArgs) Handles ItemR2C0.MouseLeave
    ItemR2C0.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR2C0_Click(sender As Object, e As EventArgs) Handles ItemR2C0.Click
    blockClick(Ids(8), ItemR2C0)
  End Sub

  Private Sub ItemR2C1_MouseEnter(sender As Object, e As EventArgs) Handles ItemR2C1.MouseEnter
    ItemR2C1.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR2C1_MouseLeave(sender As Object, e As EventArgs) Handles ItemR2C1.MouseLeave
    ItemR2C1.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR2C1_Click(sender As Object, e As EventArgs) Handles ItemR2C1.Click
    blockClick(Ids(9), ItemR2C1)
  End Sub

  Private Sub ItemR2C2_MouseEnter(sender As Object, e As EventArgs) Handles ItemR2C2.MouseEnter
    ItemR2C2.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR2C2_MouseLeave(sender As Object, e As EventArgs) Handles ItemR2C2.MouseLeave
    ItemR2C2.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR2C2_Click(sender As Object, e As EventArgs) Handles ItemR2C2.Click
    blockClick(Ids(10), ItemR2C2)
  End Sub

  Private Sub ItemR2C3_MouseEnter(sender As Object, e As EventArgs) Handles ItemR2C3.MouseEnter
    ItemR2C3.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR2C3_MouseLeave(sender As Object, e As EventArgs) Handles ItemR2C3.MouseLeave
    ItemR2C3.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR2C3_Click(sender As Object, e As EventArgs) Handles ItemR2C3.Click
    blockClick(Ids(11), ItemR2C3)
  End Sub

  Private Sub ItemR3C0_MouseEnter(sender As Object, e As EventArgs) Handles ItemR3C0.MouseEnter
    ItemR3C0.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR3C0_MouseLeave(sender As Object, e As EventArgs) Handles ItemR3C0.MouseLeave
    ItemR3C0.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR3C0_Click(sender As Object, e As EventArgs) Handles ItemR3C0.Click
    blockClick(Ids(12), ItemR3C0)
  End Sub

  Private Sub ItemR3C1_MouseEnter(sender As Object, e As EventArgs) Handles ItemR3C1.MouseEnter
    ItemR3C1.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR3C1_MouseLeave(sender As Object, e As EventArgs) Handles ItemR3C1.MouseLeave
    ItemR3C1.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR3C1_Click(sender As Object, e As EventArgs) Handles ItemR3C1.Click
    blockClick(Ids(13), ItemR3C1)
  End Sub

  Private Sub ItemR3C2_MouseEnter(sender As Object, e As EventArgs) Handles ItemR3C2.MouseEnter
    ItemR3C2.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR3C2_MouseLeave(sender As Object, e As EventArgs) Handles ItemR3C2.MouseLeave
    ItemR3C2.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR3C2_Click(sender As Object, e As EventArgs) Handles ItemR3C2.Click
    blockClick(Ids(14), ItemR3C2)
  End Sub

  Private Sub ItemR3C3_MouseEnter(sender As Object, e As EventArgs) Handles ItemR3C3.MouseEnter
    ItemR3C3.BackColor = Color.FromArgb(75, 125, 125, 125)
  End Sub

  Private Sub ItemR3C3_MouseLeave(sender As Object, e As EventArgs) Handles ItemR3C3.MouseLeave
    ItemR3C3.BackColor = Color.FromArgb(0, 0, 0, 0)
  End Sub

  Private Sub ItemR3C3_Click(sender As Object, e As EventArgs) Handles ItemR3C3.Click
    blockClick(Ids(15), ItemR3C3)
  End Sub
End Class
