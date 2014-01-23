using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabLoanRepay
	{
		public TabLoanRepay()
		{
			m_LRID = 0;

		}

		#region LRID
		
		private int m_LRID;
		
		public int LRID
		{
			get { return m_LRID; }
			set { m_LRID = value; }
		}
		
		#endregion
		
		#region LRSubProjectID
		
		private int? m_LRSubProjectID;
		
		public int? LRSubProjectID
		{
			get { return m_LRSubProjectID; }
			set { m_LRSubProjectID = value; }
		}
		
		#endregion
		
		#region LRDateTime
		
		private  m_LRDateTime;
		
		public  LRDateTime
		{
			get { return m_LRDateTime; }
			set { m_LRDateTime = value; }
		}
		
		#endregion
		
		#region LRWorkOrder
		
		private string m_LRWorkOrder;
		
		public string LRWorkOrder
		{
			get { return m_LRWorkOrder; }
			set { m_LRWorkOrder = value; }
		}
		
		#endregion
		
		#region LRLoan
		
		private decimal? m_LRLoan;
		
		public decimal? LRLoan
		{
			get { return m_LRLoan; }
			set { m_LRLoan = value; }
		}
		
		#endregion
		
		#region LRRepay
		
		private decimal? m_LRRepay;
		
		public decimal? LRRepay
		{
			get { return m_LRRepay; }
			set { m_LRRepay = value; }
		}
		
		#endregion
		
		#region LRHandler
		
		private string m_LRHandler;
		
		public string LRHandler
		{
			get { return m_LRHandler; }
			set { m_LRHandler = value; }
		}
		
		#endregion
		
		#region LRPerson
		
		private string m_LRPerson;
		
		public string LRPerson
		{
			get { return m_LRPerson; }
			set { m_LRPerson = value; }
		}
		
		#endregion
		
		#region LRBankNO
		
		private string m_LRBankNO;
		
		public string LRBankNO
		{
			get { return m_LRBankNO; }
			set { m_LRBankNO = value; }
		}
		
		#endregion
		
		#region LRMemo
		
		private string m_LRMemo;
		
		public string LRMemo
		{
			get { return m_LRMemo; }
			set { m_LRMemo = value; }
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
			TabLoanRepay castObj = (TabLoanRepay) obj;
			return ( castObj != null )
 && m_LRID == castObj.LRID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 50;
			hash = hash * 50
 * m_LRID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}