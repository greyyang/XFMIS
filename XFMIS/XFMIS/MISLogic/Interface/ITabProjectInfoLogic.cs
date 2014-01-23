using System;
using System.Collections.Generic;
using MISEntity.Entity;

namespace MISLogic.Interface
{
    public interface ITabProjectInfoLogic : ICommonLogic<TabProjectInfo, int>
    {
        /// <summary>
        /// 添加工程信息的自定义方法
        /// </summary>
        /// <param name="projectInfo"></param>
        /// <returns></returns>
        int updateExInfo(TabProjectInfo projectInfo);
        /// <summary>
        /// 更新成本计划的自定义方法
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        int updatePlan(TabProjectInfo projectInfo);
    }
}