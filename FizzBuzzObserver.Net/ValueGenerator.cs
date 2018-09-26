using System.Collections.Generic;
using System.Text;
using FizzBuzzObserver.Net.Models;

namespace FizzBuzzObserver.Net
{
    public interface IValueGenerator
    {
        string Generate(int currentValue, List<NumberWordPair> numbersToCheck);
    }

    public class ValueGenerator : IValueGenerator
    {
        public string Generate(int currentValue, List<NumberWordPair> numbersToCheck)
        {
            var sb = new StringBuilder();

            foreach (var wordPair in numbersToCheck)
            {
                if (currentValue % wordPair.Number == 0)
                {
                    sb.Append(wordPair.Word);
                }
            }

            return string.IsNullOrEmpty(sb.ToString()) ? currentValue.ToString() : sb.ToString();
        }
    }
}