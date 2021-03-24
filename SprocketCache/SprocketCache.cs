using System;

namespace SprocketCache
{
    public class SprocketCache : ISprocketCache
    {
        private readonly ISprocketFactory sprocketFactory;

        public SprocketCache(ISprocketFactory sprocketFactory)
        {
            this.sprocketFactory = sprocketFactory;
        }
        
        public Sprocket Get(string key)
        {
            throw new NotImplementedException();
        }
    }
}