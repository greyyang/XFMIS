using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabBalance
	{
		public TabBalance()
		{
			m_BLID = 0;

		}

		#region BLID
		
		private int m_BLID;
		
		public int BLID
		{
			get { return m_BLID; }
			set { m_BLID = value; }
		}
		
		#endregion
		
		#region BLSubProjectID
		
		private int? m_BLSubProjectID;
		
		public int? BLSubProjectID
		{
			get { return m_BLSubProjectID; }
			set { m_BLSubProjectID = value; }
		}
		
		#endregion
		
		#region BLDateTime
		
		private DateTime? m_BLDateTime;
		
		public DateTime? BLDateTime
		{
			get { return m_BLDateTime; }
			set { m_BLDateTime = value; }
		}
		
		#endregion
		
		#region BLWorkOrder
		
		private string m_BLWorkOrder;
		
		public string BLWorkOrder
		{
			get { return m_BLWorkOrder; }
			set { m_BLWorkOrder = value; }
		}
		
		#endregion
		
		#region BLPay
		
		private decimal? m_BLPay;
		
		public decimal? BLPay
		{
			get { return m_BLPay; }
			set { m_BLPay = value; }
		}
		
		#endregion
		
		#region BLPayCompany
		
		private string m_BLPayCompany;
		
		public string BLPayCompany
		{
			get { return m_BLPayCompany; }
			set { m_BLPayCompany = value; }
		}
		
		#endregion
		
		#region BLHandler
		
		private string m_BLHandler;
		
		public string BLHandler
		{
			get { return m_BLHandler; }
			set { m_BLHandler = value; }
		}
		
		#endregion
		
		#region BLBankNO
		
		private string m_BLBankNO;
		
		public string BLBankNO
		{
			get { return m_BLBankNO; }
			set { m_BLBankNO = value; }
		}
		
		#endregion
		
		#region BLMemo
		
		private string m_BLMemo;
		
		public string BLMemo
		{
			get { return m_BLMemo; }
			set { m_BLMemo = value; }
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
			TabBalance castObj = (TabBalance) obj;
			return ( castObj != null )
 && m_BLID == castObj.BLID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 51;
			hash = hash * 51
 * m_BLID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}