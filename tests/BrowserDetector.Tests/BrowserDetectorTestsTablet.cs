using Xunit;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace Shyjus.BrowserDetector.Tests
{
    public partial class BrowserDetectorTests
    {
        /// <summary>
        /// Verify Chrome in iPad browser detection. 
        /// </summary>
        [Fact]
        public void Chrome_In_IPad()
        {
            var headers = new Dictionary<string, StringValues>
            {
                { Headers.UserAgent, UserAgents.Chrome_IPad }
            };

            var httpContextAccessor = this.GetMockedHttpContextAccessor(headers);
            var detector = new BrowserDetector(httpContextAccessor);

            Browser actual = detector.Browser;

            Assert.Equal(BrowserType.ChromeIPad, actual.Type);
        }

        /// <summary>
        /// Verify Chrome in iPad browser detection. 
        /// </summary>
        [Fact]
        public void Safari_In_IPad()
        {
            var headers = new Dictionary<string, StringValues>
            {
                { Headers.UserAgent, UserAgents.Safari_IPad }
            };

            var httpContextAccessor = this.GetMockedHttpContextAccessor(headers);
            var detector = new BrowserDetector(httpContextAccessor);

            Browser actual = detector.Browser;

            Assert.Equal(BrowserType.SafariIPad, actual.Type);
        }

        /// <summary>
        /// Verify Chrome in iPad browser detection. 
        /// </summary>
        [Fact]
        public void Edge_In_IPad()
        {
            var headers = new Dictionary<string, StringValues>
            {
                { Headers.UserAgent, UserAgents.Edge_IPad }
            };

            var httpContextAccessor = this.GetMockedHttpContextAccessor(headers);
            var detector = new BrowserDetector(httpContextAccessor);

            Browser actual = detector.Browser;

            Assert.Equal(BrowserType.EdgeIPad, actual.Type);
        }
    }
}
