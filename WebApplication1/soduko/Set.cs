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

        public static readonly List<int> AllPossibles = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

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
            this.OnlyOnce();
        }

        public void OnlyOnce() //if number only possible in one cell then set .....
        {
            foreach (var poss in Set.AllPossibles)
            {
                var count = new List<int>();
                for (int i = 0; i < 9; i++)
                {
                    if (Cells[i].Possibles.Contains(poss))
                    {
                        count.Add(i);
                    }

                }
                if (count.Count == 1)
                {
                    Cells[count[0]].Value = poss;
                }
            }
        }
    }
}


