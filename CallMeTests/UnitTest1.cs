using System;
using callMe;
using Xunit;

namespace CallMeTests
{
    public class CallMeTests
    {
        [Fact]
        public void NoBrackets()
        {
            var stringTransformer = new StringTransform();
            string phoneNum = stringTransformer.TransformPhoneNumber("+61 (03) 5995 0253");
            Assert.Equal("0359950253", phoneNum);
        }
        
        [Fact]
        public void NoPlus()
        {
            var stringTransformer = new StringTransform();
            string phoneNum = stringTransformer.TransformPhoneNumber("+61 (03) 5995 0253");
            Assert.Equal("0359950253", phoneNum);
        }
        
        [Fact]
        public void NoDashes()
        {
            var stringTransformer = new StringTransform();
            string phoneNum = stringTransformer.TransformPhoneNumber("03-5995-0253");
            Assert.Equal("0359950253", phoneNum);
        }
        
        [Fact]
        public void NoWhitespace()
        {
            var stringTransformer = new StringTransform();
            string phoneNum = stringTransformer.TransformPhoneNumber("61 03 5995 0253");
            Assert.Equal("0359950253", phoneNum);
        }
        //
        [Fact]
        public void NoDecimals()
        {
            var stringTransformer = new StringTransform();
            string phoneNum = stringTransformer.TransformPhoneNumber("03.5995.0253");
            Assert.Equal("0359950253", phoneNum);
        }
    }
}