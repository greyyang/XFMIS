using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabCustomer
	{
		public TabCustomer()
		{
			m_CUID = 0;

		}

		#region CUID
		
		private int m_CUID;
		
		public int CUID
		{
			get { return m_CUID; }
			set { m_CUID = value; }
		}
		
		#endregion
		
		#region CUValue
		
		private string m_CUValue;
		
		public string CUValue
		{
			get { return m_CUValue; }
			set { m_CUValue = value; }
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
			TabCustomer castObj = (TabCustomer) obj;
			return ( castObj != null )
 && m_CUID == castObj.CUID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 58;
			hash = hash * 58
 * m_CUID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}