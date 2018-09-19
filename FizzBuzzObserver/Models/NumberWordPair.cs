namespace FizzBuzzObserver.Models
{
    public class NumberWordPair
    {
        public int Number { get; set; }
        public string Word { get; set; }

        public NumberWordPair(int number, string word)
        {
            Number = number;
            Word = word;
        }
    }
}