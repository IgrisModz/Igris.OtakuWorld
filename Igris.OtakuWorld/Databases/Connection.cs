using MySql.Data.MySqlClient;

namespace Igris.OtakuWorld.Creation.Databases
{
    internal sealed class Connection
    {
        private static MySqlConnection _instance;
        private readonly static object _lock = new();

        private Connection() { }

        public static MySqlConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new MySqlConnection(@$"server=localhost;uid=root;pwd=null;database=otakuworld");
                }
            }
        }
    }
}
