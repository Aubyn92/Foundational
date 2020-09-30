using System;
using BobTheTeenager;
using Xunit;



namespace BobTheTeenagerTests
{
    public class StringTests
    {
        [Fact]
        public void RandomisedGreeting()
        {
            var helloBob = new Greeting();
            string bobsResponse = helloBob.BobsResponses("hello");
            Assert.Equal("Whatever.", bobsResponse);
        }

        [Fact]
        public void LoudGreeting()
        {
            var helloBob = new Greeting();
            string bobsResponse = helloBob.BobsResponses("hello!");
            Assert.Equal("Whoa, chill out!", bobsResponse);
        }
        
        [Fact]
        public void QuestionGreeting()
        {
            var helloBob = new Greeting();
            string bobsResponse = helloBob.BobsResponses("hello?!");
            Assert.Equal("Calm down, I know what I'm doing!", bobsResponse);
        }
        
        [Fact]
        public void LoudQuestionGreeting()
        {
            var helloBob = new Greeting();
            string bobsResponse = helloBob.BobsResponses("hello?");
            Assert.Equal("Sure.", bobsResponse);
        }
        
        [Fact]
        public void EmptyGreeting()
        {
            var helloBob = new Greeting();
            string bobsResponse = helloBob.BobsResponses("");
            Assert.Equal("Fine. Be that way!", bobsResponse);
        }
        
        [Fact]
        public void Whitespace()
        {
            var helloBob = new Greeting();
            string bobsResponse = helloBob.BobsResponses("                  hello");
            Assert.Equal("Whatever.", bobsResponse);
        }
    }
}