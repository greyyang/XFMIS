using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISClient.Kit
{
    public class GenerateWorkOrder
    {
        public GenerateWorkOrder()
        {
        }

        public static string generateWorkOrder_BySubIDAndType(string type)
        {
            switch (type)
            {
                case "payment": return GPayment();
                case "LoanRepay": return GLoanRepay();
                case "Balance": return GBalance();
                case "CostAndReimburse": return GCostAndReimburse();
                default: break;
            }
            return null;
        }

        private static string GPayment()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return "KP_" + Convert.ToInt64(ts.TotalSeconds).ToString(); 
        }

        private static string GLoanRepay()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return "JH_" + Convert.ToInt64(ts.TotalSeconds).ToString(); 
        }

        private static string GBalance()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return "JS_" + Convert.ToInt64(ts.TotalSeconds).ToString(); 
        }

        private static string GCostAndReimburse()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return "CB_" + Convert.ToInt64(ts.TotalSeconds).ToString(); 
        }
        
    }
}
