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
            var codec = new EncodeAndDecodeTinyUrl();

            var encodedUrl = codec.Encode(url1);
            var decodedUrl = codec.Decode(encodedUrl);

            decodedUrl.Should().Equals(url1);
        }
    }
}
