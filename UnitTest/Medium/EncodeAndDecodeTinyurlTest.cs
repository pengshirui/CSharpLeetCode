namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Xunit;

    public class EncodeAndDecodeTinyurlTest
    {
        [Fact]
        public void Test1()
        {
            var url1 = "https://leetcode.com/problems/design-tinyurl";
            var encoder = new EncodeAndDecodeTinyUrl();

            var encodedUrl = encoder.Encode(url1);
            var decodedUrl = encoder.Decode(encodedUrl);

            decodedUrl.Should().Equals(url1);
        }
    }
}
