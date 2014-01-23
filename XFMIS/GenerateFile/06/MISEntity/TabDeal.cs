using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabDeal
	{
		public TabDeal()
		{
			m_DLID = 0;

		}

		#region DLID
		
		private int m_DLID;
		
		public int DLID
		{
			get { return m_DLID; }
			set { m_DLID = value; }
		}
		
		#endregion
		
		#region DLSubProjectID
		
		private int? m_DLSubProjectID;
		
		public int? DLSubProjectID
		{
			get { return m_DLSubProjectID; }
			set { m_DLSubProjectID = value; }
		}
		
		#endregion
		
		#region DLManager
		
		private string m_DLManager;
		
		public string DLManager
		{
			get { return m_DLManager; }
			set { m_DLManager = value; }
		}
		
		#endregion
		
		#region DLCompany
		
		private string m_DLCompany;
		
		public string DLCompany
		{
			get { return m_DLCompany; }
			set { m_DLCompany = value; }
		}
		
		#endregion
		
		#region DLMoeny
		
		private decimal? m_DLMoeny;
		
		public decimal? DLMoeny
		{
			get { return m_DLMoeny; }
			set { m_DLMoeny = value; }
		}
		
		#endregion
		
		#region DLStart
		
		private DateTime? m_DLStart;
		
		public DateTime? DLStart
		{
			get { return m_DLStart; }
			set { m_DLStart = value; }
		}
		
		#endregion
		
		#region DLEnd
		
		private DateTime? m_DLEnd;
		
		public DateTime? DLEnd
		{
			get { return m_DLEnd; }
			set { m_DLEnd = value; }
		}
		
		#endregion
		
		#region DLState
		
		private string m_DLState;
		
		public string DLState
		{
			get { return m_DLState; }
			set { m_DLState = value; }
		}
		
		#endregion
		
		#region DLDate
		
		private DateTime? m_DLDate;
		
		public DateTime? DLDate
		{
			get { return m_DLDate; }
			set { m_DLDate = value; }
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
			TabDeal castObj = (TabDeal) obj;
			return ( castObj != null )
 && m_DLID == castObj.DLID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 30;
			hash = hash * 30
 * m_DLID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}