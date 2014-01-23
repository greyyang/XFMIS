using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISClient.Kit
{
    class GlobeVariable
    {
        private GlobeVariable()
        {

        }

        private static GlobeVariable gbv = null;

        public string username = null;
        public int userid = 0;
        public string userno = null;
        public string depart = null;
        public string privilege = null;

        public static GlobeVariable getInstance()
        {
            if (gbv == null)
            {
                gbv = new GlobeVariable();
            }

            return gbv;
        }
    }


}
