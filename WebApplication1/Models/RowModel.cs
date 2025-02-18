namespace WebApplication1.Models
{
    public class RowModel
    {
        public List<int> Cells { get; set; }
        public RowModel()
        {
            this.Cells = new List<int>();
        }
    }
}
