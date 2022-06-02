using Xunit;
using ExerciseWithManyToManyAtd.Services;
using ExerciseWithManyToManyAtd.Modells;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestForService
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int number = 12;
          
            ServiceForEverything Se = new ServiceForEverything();
            
            int methodReturn=Se.Something(number);

        Assert.Equal(number, methodReturn);
        }
    }
}