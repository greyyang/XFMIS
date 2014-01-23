using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabProjectCategory
	{
		public TabProjectCategory()
		{
			m_PCID = 0;

		}

		#region PCID
		
		private int m_PCID;
		
		public int PCID
		{
			get { return m_PCID; }
			set { m_PCID = value; }
		}
		
		#endregion
		
		#region PCName
		
		private string m_PCName;
		
		public string PCName
		{
			get { return m_PCName; }
			set { m_PCName = value; }
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
			TabProjectCategory castObj = (TabProjectCategory) obj;
			return ( castObj != null )
 && m_PCID == castObj.PCID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 59;
			hash = hash * 59
 * m_PCID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}