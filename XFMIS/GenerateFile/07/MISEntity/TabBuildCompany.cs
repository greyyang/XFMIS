using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabBuildCompany
	{
		public TabBuildCompany()
		{
			m_BCID = 0;

		}

		#region BCID
		
		private int m_BCID;
		
		public int BCID
		{
			get { return m_BCID; }
			set { m_BCID = value; }
		}
		
		#endregion
		
		#region BCSubProjectID
		
		private int? m_BCSubProjectID;
		
		public int? BCSubProjectID
		{
			get { return m_BCSubProjectID; }
			set { m_BCSubProjectID = value; }
		}
		
		#endregion
		
		#region BCName
		
		private string m_BCName;
		
		public string BCName
		{
			get { return m_BCName; }
			set { m_BCName = value; }
		}
		
		#endregion
		
		#region BCWork
		
		private string m_BCWork;
		
		public string BCWork
		{
			get { return m_BCWork; }
			set { m_BCWork = value; }
		}
		
		#endregion
		
		#region BCContactor
		
		private string m_BCContactor;
		
		public string BCContactor
		{
			get { return m_BCContactor; }
			set { m_BCContactor = value; }
		}
		
		#endregion
		
		#region BCTel
		
		private string m_BCTel;
		
		public string BCTel
		{
			get { return m_BCTel; }
			set { m_BCTel = value; }
		}
		
		#endregion
		
		#region BCMemo
		
		private string m_BCMemo;
		
		public string BCMemo
		{
			get { return m_BCMemo; }
			set { m_BCMemo = value; }
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
			TabBuildCompany castObj = (TabBuildCompany) obj;
			return ( castObj != null )
 && m_BCID == castObj.BCID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 18;
			hash = hash * 18
 * m_BCID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}