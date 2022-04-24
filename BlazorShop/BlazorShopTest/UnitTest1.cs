using BlazorShop.Shared;
using System;
using Xunit;

namespace BlazorShopTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
        }

        [Fact]
        public void WeatherForCastZeroCshouldBe32F() 
        {
            var forcast = new WeatherForecast();
            forcast.TemperatureC = 0;
            Assert.Equal(32, forcast.TemperatureF);
        }
    }
}
