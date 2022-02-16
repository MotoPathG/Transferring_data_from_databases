using TDD.Models;

namespace TDD
{
    public class TDD
    {
        public Configuration TDDConfiguration;

        public TDD(Configuration _configuration)
        {
            Setup(_configuration);
        }
        
        public void Setup(Configuration _configuration)
        {
            TDDConfiguration = _configuration;
        }
    }
}