using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISClient.Sinicization
{
    /// <summary>
    /// 汉化日期选择控件
    /// </summary>
    public class ChEditLocalizer : Localizer
    {　 // 重载 GetLocalizedString 方法
        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                // DateEdit 控件汉化
                case StringId.DateEditToday: return "今天";
                case StringId.DateEditClear: return "取消";
            }
            return base.GetLocalizedString(id);

        }
    }
}
