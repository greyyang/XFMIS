using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabProjectState
	{
		public TabProjectState()
		{
			m_PSID = 0;

		}

		#region PSID
		
		private int m_PSID;
		
		public int PSID
		{
			get { return m_PSID; }
			set { m_PSID = value; }
		}
		
		#endregion
		
		#region PSValue
		
		private string m_PSValue;
		
		public string PSValue
		{
			get { return m_PSValue; }
			set { m_PSValue = value; }
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
			TabProjectState castObj = (TabProjectState) obj;
			return ( castObj != null )
 && m_PSID == castObj.PSID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 70;
			hash = hash * 70
 * m_PSID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}