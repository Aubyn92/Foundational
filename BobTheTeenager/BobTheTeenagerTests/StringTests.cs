using System;
using Xunit;

namespace BobTheTeenagerTests
{
    public class StringTests
    {
        [Fact]
        public void RandomisedGreeting()
        {
            Assert.Equal("Whatever.", ("hello"));
        }

        [Fact]
        public void LoudGreeting()
        {
            Assert.Equal("Whoa, chill out!", ("hello!"));
        }
        
        [Fact]
        public void QuestionGreeting()
        {
            Assert.Equal("Calm down, I know what I'm doing!", ("hello?!"));
        }
        
        [Fact]
        public void LoudQuestionGreeting()
        {
            Assert.Equal("Sure.", ("hello?"));
        }
        
        [Fact]
        public void EmptyGreeting()
        {
            Assert.Equal("Fine. Be that way!", (""));
        }
        
        [Fact]
        public void Whitespace()
        {
            Assert.Equal("Whatever.", ("              hello"));
        }
    }
}