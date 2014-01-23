using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabTestUsers
	{
		public TabTestUsers()
		{
			m_ID = 0;

		}

		#region ID
		
		private int m_ID;
		
		public int ID
		{
			get { return m_ID; }
			set { m_ID = value; }
		}
		
		#endregion
		
		#region UserName
		
		private string m_UserName;
		
		public string UserName
		{
			get { return m_UserName; }
			set { m_UserName = value; }
		}
		
		#endregion
		
		#region Password
		
		private string m_Password;
		
		public string Password
		{
			get { return m_Password; }
			set { m_Password = value; }
		}
		
		#endregion
		
		#region Memo
		
		private string m_Memo;
		
		public string Memo
		{
			get { return m_Memo; }
			set { m_Memo = value; }
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
			TabTestUsers castObj = (TabTestUsers) obj;
			return ( castObj != null )
;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 83;
			hash = hash * 83
;			return hash;
		}
		
		#endregion
		
		
	}
}