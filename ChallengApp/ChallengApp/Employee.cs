namespace ChallengApp
{
    internal class Employee
    {
        private List<int> scores = new List<int>();

        public Employee(string fristName, string secondName, int age)
        {
            this.FristName = fristName;
            this.SecondName = secondName;
            this.Age = age;

        }
        public string FristName { get; private set; }
        public string SecondName { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.scores.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.scores.Add(number);
        }
    }
}