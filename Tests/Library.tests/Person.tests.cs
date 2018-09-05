using System;
using Xunit;
using Person1;
namespace Program1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Person persona1 = new Person("Marcos","4.971.613-7");
            Assert.Equal("4.971.613-7",persona1.ID);
        }
    }
}
