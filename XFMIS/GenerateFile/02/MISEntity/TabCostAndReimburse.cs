using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabCostAndReimburse
	{
		public TabCostAndReimburse()
		{
			m_CRID = 0;

		}

		#region CRID
		
		private int m_CRID;
		
		public int CRID
		{
			get { return m_CRID; }
			set { m_CRID = value; }
		}
		
		#endregion
		
		#region CRSubProjectID
		
		private int? m_CRSubProjectID;
		
		public int? CRSubProjectID
		{
			get { return m_CRSubProjectID; }
			set { m_CRSubProjectID = value; }
		}
		
		#endregion
		
		#region CRDateTime
		
		private  m_CRDateTime;
		
		public  CRDateTime
		{
			get { return m_CRDateTime; }
			set { m_CRDateTime = value; }
		}
		
		#endregion
		
		#region CRWorkOrder
		
		private string m_CRWorkOrder;
		
		public string CRWorkOrder
		{
			get { return m_CRWorkOrder; }
			set { m_CRWorkOrder = value; }
		}
		
		#endregion
		
		#region CRAmount
		
		private decimal? m_CRAmount;
		
		public decimal? CRAmount
		{
			get { return m_CRAmount; }
			set { m_CRAmount = value; }
		}
		
		#endregion
		
		#region CRManagerialFee
		
		private decimal? m_CRManagerialFee;
		
		public decimal? CRManagerialFee
		{
			get { return m_CRManagerialFee; }
			set { m_CRManagerialFee = value; }
		}
		
		#endregion
		
		#region CRBackAmount
		
		private decimal? m_CRBackAmount;
		
		public decimal? CRBackAmount
		{
			get { return m_CRBackAmount; }
			set { m_CRBackAmount = value; }
		}
		
		#endregion
		
		#region CRBillingUnit
		
		private string m_CRBillingUnit;
		
		public string CRBillingUnit
		{
			get { return m_CRBillingUnit; }
			set { m_CRBillingUnit = value; }
		}
		
		#endregion
		
		#region CRMemo
		
		private string m_CRMemo;
		
		public string CRMemo
		{
			get { return m_CRMemo; }
			set { m_CRMemo = value; }
		}
		
		#endregion
		

		
		#region Rewrite Equals and HashCode
		
		/// <summary>
		/// 
		/// </summary>
		public override bool Equals(object obj)
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != GetType() ) ) return false;
			TabCostAndReimburse castObj = (TabCostAndReimburse) obj;
			return ( castObj != null )
 && m_CRID == castObj.CRID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 74;
			hash = hash * 74
 * m_CRID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}