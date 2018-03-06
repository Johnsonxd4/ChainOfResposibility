using ChainOfResposibility;
using System;
using System.Collections;
using System.Linq;
using Xunit;

namespace ChainOfResponsibility.Tests
{
    public class ChainOfResponsibilityTests
    {
        [Theory]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(15)]
        public void VerifyDiscountGrantedForManagerResposibility(double value)
        {
            //Arrange
            var salesman = new SalesMan();
            var manager = new Manager();
            var owner = new Owner();

            salesman.SetSucessor(manager);
            manager.SetSucessor(owner);
            
            //fact
            var handledBy = salesman.HandleDiscount(value);
            
            //assert
            Assert.Equal("Discount granted by Manager", handledBy);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void VerifyDiscountGrantedByTheSalesMan(double value)
        {
            var salesman = new SalesMan();
            var manager = new Manager();
            var owner = new Owner();

            salesman.SetSucessor(manager);
            manager.SetSucessor(owner);

            //fact
            var handledBy = salesman.HandleDiscount(value);

            //assert
            Assert.Equal("Discount granted by salesman", handledBy);
        }

        [Theory]
        [InlineData(16)]
        [InlineData(26)]
        [InlineData(36)]
        [InlineData(46)]
        [InlineData(56)]
        [InlineData(66)]
        [InlineData(76)]
        [InlineData(86)]
        [InlineData(96)]
        [InlineData(100)]
        public void VerifyDiscountGrantedByTheOwner(double value)
        {
            var salesman = new SalesMan();
            var manager = new Manager();
            var owner = new Owner();

            salesman.SetSucessor(manager);
            manager.SetSucessor(owner);

            //fact
            var handledBy = salesman.HandleDiscount(value);

            Assert.Equal("Discount granted by the owner", handledBy);
        }

        [Fact]
        public void VerifyExceptionWhenDiscountPercentOvercomeOneHundred()
        {
            var salesman = new SalesMan();
            var manager = new Manager();
            var owner = new Owner();

            salesman.SetSucessor(manager);
            manager.SetSucessor(owner);

            //fact
            
            
            //Assert 
            Assert.Throws<ArgumentException>(() => salesman.HandleDiscount(101)); 
        }
    }
}
