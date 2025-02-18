namespace TestProject1
{
    using WebApplication1.Models;
    using WebApplication1.soduko;

    public class UnitTest1
    {
   

        [Theory]
        [InlineData(".94.7...3........4...4938275628374....95642787489125364..6..3.2..372..4.92.3417.5")]
        public void Test2(string sudoku)
        {
            Assert.Equal(81, sudoku.Length);

        }

        [Fact]
        public void CellTest()
        {
            var cell = new Cell();
            Assert.False(cell.Solved);
            cell.Value = 1;
            Assert.True(cell.Solved);
            Assert.Equal(1, cell.Value);
        }

        [Fact]
        public void SudokuTest()
        {
            var grid = new Grid();
            var result = grid.Solve(".94.7...3........4...4938275628374....95642787489125364..6..3.2..372..4.92.3417.5");
          
            Assert.Equal(9, grid.Columns[1].Cells[0].Value);
            Assert.Equal(5, grid.Columns[8].Cells[8].Value);
            Assert.Equal(4, grid.Rows[1].Cells[8].Value);
            Assert.Equal(6, grid.Boxes[4].Cells[4].Value);
            Assert.Equal("894276153237158964651493827562837491319564278748912536475689312183725649926341785", result);



        }
    }
}