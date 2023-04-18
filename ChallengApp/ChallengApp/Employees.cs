namespace ChallengApp
{
    internal class Emplemployee
    {
        private List<int> score = new List<int>();

        public Employee string fristName, string secondName, score)
        {
            this.FristName = fristName;
            this.SecondName = secondName;
           
        }
        public string FristName { get; private set; }
        public string SecondName { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number);
    {
        this.score.Add(number);
    }
}
    }