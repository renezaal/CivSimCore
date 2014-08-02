using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimCore
{
    public class CivCore
    {
        #region singleton code
        private static CivCore _instance;
        public static CivCore Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new CivCore();
                }
                return _instance;
            }
        }
        private CivCore()
        {

        }
        #endregion

        internal Random rand= new Random();
        internal Pool pool = new Pool();
        
    }
}
