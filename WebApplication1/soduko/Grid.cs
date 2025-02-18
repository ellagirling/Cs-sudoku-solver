namespace WebApplication1.soduko
{
    public class Grid
    {
        public List<Cell> Cells { get; set; }
        public List<Set> Rows { get; set; }
        public List<Set> Columns { get; set; }
        public List<Set> Boxes { get; set; }
        public bool IsSolved {
            get{
                for (int i = 0; i < 81; i++)
                {
                    if(!Cells[i].Solved)
                    {
                        return false;
                    }

                }
                return true;
            } 
        }

        public string Solve(string sudoku)
        {
            this.Cells = new List<Cell>();
            this.Rows = new List<Set>();
            this.Columns = new List<Set>();
            this.Boxes = new List<Set>();
            for (int i = 0; i < 9; i++)
            {
                this.Rows.Add(new Set(SetType.Row));
                this.Columns.Add(new Set(SetType.Column));
                this.Boxes.Add(new Set(SetType.Box));

            }



            for (int i = 0;i<81; i++) 
            {
                int rowref = i/9;
                var cell = new Cell();
                this.Cells.Add(cell);
                Rows[rowref].Cells.Add(cell);
                int colref = i % 9;
                Columns[colref].Cells.Add(cell);
                int boxref = (int)(colref / 3) + ((int)(rowref / 3)*3);
                Boxes[boxref].Cells.Add(cell);
                if (sudoku[i] != '.')
                {
                    cell.Value = (int) Char.GetNumericValue(sudoku[i]);
                }

            }
            for (int j = 0; j < 100; j++) {
                for (int i = 0; i < 9; i++)
                {

                    this.Rows[i].Validate();
                    this.Columns[i].Validate();
                    this.Boxes[i].Validate();

                }
            }
                var result = string.Empty;

                for (int i = 0; i < 81; i++)
                {
                    result += Cells[i].Solved ? Cells[i].Value.ToString() : '.';

                }
            

            return result;
             
        }
    }
}
