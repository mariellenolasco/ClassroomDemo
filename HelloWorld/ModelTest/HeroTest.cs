using Models;
using System;
using Xunit;

namespace ModelTest
{
    public class HeroTest
    {

        Hero testHero = new Hero();
        [Fact]
        public void HeroNameShouldSet()
        {
            testHero.HeroName = "Superman";
            Assert.Equal("Superman", testHero.HeroName);

        }

        [Fact]
        public void HeroNameShouldNotBeNull()
        {
            Assert.Throws<ArgumentException>(() => testHero.HeroName = null);
        }
    }
}