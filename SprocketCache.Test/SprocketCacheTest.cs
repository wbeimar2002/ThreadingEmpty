using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SprocketCache.Test
{
    [TestFixture]
    public class SprocketCacheTest
    {
        [Test]
        public void CanGetSprocket()
        {
            var cache = new SprocketCache(new TestSprocketFactory());
            var sprocket = cache.Get("test");
            Assert.IsInstanceOf<Sprocket>(sprocket);
        }

        [Test]
        public void SameKeyReturnsSameSprocket()
        {
            var cache = new SprocketCache(new TestSprocketFactory());
            var sprocket1 = cache.Get("test");
            var sprocket2 = cache.Get("test");
            Assert.AreSame(sprocket1, sprocket2, "not the same");
        }

        [Test]
        public void DifferentKeyReturnsDifferentSprocket()
        {
        }

        [Test]
        public void Expiry()
        {
        }

        [Test]
        public void IsThreadSafe()
        {
        }
    }
}
