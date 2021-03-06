﻿namespace BrowserDetector.Tests
{
    using Shyjus.BrowserDetection;
    using Shyjus.BrowserDetection.Tests;
    using Xunit;

    public class EdgeChromiumTests
    {
        [Fact]
        public void EdgeChromium_OSX()
        {
            var isEdgeChromiun = EdgeChromium.TryParse(UserAgents.EdgeChromium_OSX, out var edgeChromium);

            Assert.True(isEdgeChromiun);
            Assert.Equal(DeviceTypes.Desktop, edgeChromium.DeviceType);
            Assert.Equal(OperatingSystems.MacOSX, edgeChromium.OS);
        }

        [Fact]
        public void EdgeChromium_Windows()
        {
            var isEdgeChromium = EdgeChromium.TryParse(UserAgents.EdgeChrome_Windows, out var edgeChromium);

            Assert.True(isEdgeChromium);
            Assert.Equal(DeviceTypes.Desktop, edgeChromium.DeviceType);
            Assert.Equal(OperatingSystems.Windows, edgeChromium.OS);
        }

    }
}
