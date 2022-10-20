using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public class MsSqlOperation : IMsSqlOperation, ISqlOperation
    {
        public void Connection()
        {
            Console.WriteLine("MsSql için bağlantı sağlandı");
        }

        public bool insert(Product product)
        {
            return true;
        }
    }
    public class MySqlOperation : IMsSqlOperation, ISqlOperation
    {
        public void Connection()
        {
            Console.WriteLine("MySql Bağlantısı Sağlandı");
        }

        public bool insert(Product product)
        {
            return true;
        }
    }
    public interface IMsSqlOperation{
        void Connection();
        bool insert(Product product);
    }

    public interface ISqlOperation
    {
        void Connection();
        bool insert(Product product);
    }


}
