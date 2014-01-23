using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabPayment
	{
		public TabPayment()
		{
			m_PYID = 0;

		}

		#region PYID
		
		private int m_PYID;
		
		public int PYID
		{
			get { return m_PYID; }
			set { m_PYID = value; }
		}
		
		#endregion
		
		#region PYSubProjectID
		
		private int? m_PYSubProjectID;
		
		public int? PYSubProjectID
		{
			get { return m_PYSubProjectID; }
			set { m_PYSubProjectID = value; }
		}
		
		#endregion
		
		#region PYDateTIme
		
		private DateTime? m_PYDateTIme;
		
		public DateTime? PYDateTIme
		{
			get { return m_PYDateTIme; }
			set { m_PYDateTIme = value; }
		}
		
		#endregion
		
		#region PYWorkOrder
		
		private string m_PYWorkOrder;
		
		public string PYWorkOrder
		{
			get { return m_PYWorkOrder; }
			set { m_PYWorkOrder = value; }
		}
		
		#endregion
		
		#region PYBilling
		
		private decimal? m_PYBilling;
		
		public decimal? PYBilling
		{
			get { return m_PYBilling; }
			set { m_PYBilling = value; }
		}
		
		#endregion
		
		#region PYPayment
		
		private decimal? m_PYPayment;
		
		public decimal? PYPayment
		{
			get { return m_PYPayment; }
			set { m_PYPayment = value; }
		}
		
		#endregion
		
		#region PYPayCompany
		
		private string m_PYPayCompany;
		
		public string PYPayCompany
		{
			get { return m_PYPayCompany; }
			set { m_PYPayCompany = value; }
		}
		
		#endregion
		
		#region PYMemo
		
		private string m_PYMemo;
		
		public string PYMemo
		{
			get { return m_PYMemo; }
			set { m_PYMemo = value; }
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
			TabPayment castObj = (TabPayment) obj;
			return ( castObj != null )
 && m_PYID == castObj.PYID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 33;
			hash = hash * 33
 * m_PYID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}