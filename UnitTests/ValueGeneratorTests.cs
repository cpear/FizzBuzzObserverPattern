using System.Collections.Generic;
using FizzBuzzObserver;
using FizzBuzzObserver.Models;
using Xunit;

namespace UnitTests
{
    
    public class ValueGeneratorTests
    {
        [Fact]
        public void ShouldReturnFizz()
        {
            var valueGenerator = new ValueGenerator();
            var data = new List<NumberWordPair>{new NumberWordPair(3, "Fizz") };
            var result = valueGenerator.Generate(3, data);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ShouldReturn1()
        {
            var valueGenerator = new ValueGenerator();
            var data = new List<NumberWordPair> { new NumberWordPair(3, "Fizz") };
            var result = valueGenerator.Generate(1, data);

            Assert.Equal("1", result);
        }
    }
}
