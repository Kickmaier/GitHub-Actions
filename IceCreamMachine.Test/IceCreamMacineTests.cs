using System;
using System.Collections.Generic;
using System.Text;
using IceCreamMachine;

namespace IceCreamMachine.Test
{
    public class IceCreamMacineTests
    {
        [Fact]
        public void GetScoops_ShouldReturnFive_ForXLSie()
        {
            // Arrange
            var machine = new IceCreamMachine();
            var expected = 5;
            // Act
            var result = machine.GetScoops("XL");
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("S", 1)]
        [InlineData("M", 3)]
        [InlineData("L", 4)]
        [InlineData("XL", 5)]
        [InlineData("Blobb", 0)]

        public void GetScoops_ShouldReturnCorrectValue(string size, int expected)
        {
            // Arrange
            var sut = new IceCreamMachine();
            // Act
            var result = sut.GetScoops(size);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetPrice_ShouldReturnFiftyForXL()
        {
            var sut = new IceCreamMachine();

            var prize = sut.GetPrice("XL");

            Assert.Equal(50, prize);
        }

        [Theory]
        [InlineData("S", 10)]
        [InlineData("M", 30)]
        [InlineData("L", 40)]
        [InlineData("XL", 50)]
        [InlineData("Blobb", 0)]
        
        public void GetPrice_ShouldReturnCorrectPrice(string size, int expected)
        {
            // Arrange
            var sut = new IceCreamMachine();
            // Act
            var prize = sut.GetPrice(size);
            // Assert
            Assert.Equal(expected, prize);
        }

        [Fact]
        public void IsValidSize_ShouldReturnTrue_ForM()
        {
            var sut = new IceCreamMachine();
            
            var result = sut.IsValidSize("M");

            Assert.True(result);
        }

        [Fact]
        public void IsValidSize_ShouldReturnFalse_ForXXL()
        {
            var sut = new IceCreamMachine();

            var result = sut.IsValidSize("XXL");

            Assert.False(result);
        }

        [Theory]
        [InlineData("S", true)]
        [InlineData("M", true)]
        [InlineData("L", true)]
        [InlineData("XL", true)]
        [InlineData("", false)]
        [InlineData("Blobb", false)]
        public void IsValidSize_ShouldReturnCorrectValue(string size, bool expected)
        {
            // ArrangeRAR
            var sut = new IceCreamMachine();
            // Act
            var result = sut.IsValidSize(size);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
