namespace WebApplication1.soduko
{
    public class Set
    {
        public List<Cell> Cells { get; set; }
        public SetType Type { get; set; }
        public Set(SetType type)
        { 
            this.Type = type;
            this.Cells = new List<Cell>();
        }

        public void Validate()
        {
            for(int i=0; i < 9; i++)
            {
                if (this.Cells[i].Solved)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (i != j)
                        {
                            this.Cells[j].RemovePoss(Cells[i].Value);
                        }

                    }
                }
            }
        }
    }
}
