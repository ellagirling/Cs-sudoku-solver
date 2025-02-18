using WebApplication1.soduko;

namespace WebApplication1.Models
{
    public class SolutionViewModel
    {

        private string _solution;
        public SolutionViewModel()
        {

        }
        public string Solution {
            get
            {
                return _solution;
            }

            set
            {
                _solution = value;
                this.BuildRows();
            }
            }
        public List<RowModel> Rows { get; set; }
        private void BuildRows()
        {
            this.Rows = new List<RowModel>();
  
            for (int i = 0; i < 9; i++)
            {
                this.Rows.Add(new RowModel());
            }


            for (int i = 0; i < 81; i++)
            {
                int rowref = i / 9;
                Rows[rowref].Cells.Add((int)Char.GetNumericValue(Solution[i]));

            }
        }

    }
}