using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        static Singleton instance = null;
        public string InstanceData { get; set; }
        public static Singleton Instance()
        {
            return instance = instance ?? new Singleton();
            //if (instance == null)
            //{
            //    instance = new Singleton();
            //}
            //return instance;
        }
        protected Singleton()
        {

        }
    }
}
