using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabBusinessMode
	{
		public TabBusinessMode()
		{
			m_BPID = 0;

		}

		#region BPID
		
		private int m_BPID;
		
		public int BPID
		{
			get { return m_BPID; }
			set { m_BPID = value; }
		}
		
		#endregion
		
		#region BPValue
		
		private string m_BPValue;
		
		public string BPValue
		{
			get { return m_BPValue; }
			set { m_BPValue = value; }
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
			TabBusinessMode castObj = (TabBusinessMode) obj;
			return ( castObj != null )
 && m_BPID == castObj.BPID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 37;
			hash = hash * 37
 * m_BPID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}