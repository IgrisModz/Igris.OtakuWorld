using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igris.OtakuWorld.Creation.Databases
{
    public sealed class Database
    {
        private static Database _instance;
        private static readonly object _lock = new object();

        private Database() { }

        public static Database Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new Database();
                }
            }
        }
    }
}
