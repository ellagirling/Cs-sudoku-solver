namespace WebApplication1.soduko
{
    public class Cell
    {
        public Cell()
        { 
            this.Possibles = new List<int> { 1,2, 3,4, 5, 6, 7, 8, 9};



        }

        public List<int> Possibles {  get; set; }
        public bool Solved 
        {
            get
            { 
                return this.Possibles.Count == 1;
            }   
        }

        public int Value
        {

            get
            {
                return this.Solved ? Possibles[0] : -1; //-1 = not solved 

            }
            set
            {
                this.Possibles.Clear(); //clear array when value set in cell 
                this.Possibles.Add(value); //add back in 
            }
        }

        public void RemovePoss(int poss)
        {
            this.Possibles.Remove(poss);
        }
    }
}
