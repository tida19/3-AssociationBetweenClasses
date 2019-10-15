using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Composition
{
    public class DbMigertor
    {
        private readonly Logger _logger;
        public DbMigertor(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("We are migrating blah blah blah...");

        }
    }
}
