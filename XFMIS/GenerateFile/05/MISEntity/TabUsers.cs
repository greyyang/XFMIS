using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabUsers
	{
		public TabUsers()
		{
			m_UID = 0;

		}

		#region UID
		
		private int m_UID;
		
		public int UID
		{
			get { return m_UID; }
			set { m_UID = value; }
		}
		
		#endregion
		
		#region UAccount
		
		private string m_UAccount;
		
		public string UAccount
		{
			get { return m_UAccount; }
			set { m_UAccount = value; }
		}
		
		#endregion
		
		#region UPassword
		
		private string m_UPassword;
		
		public string UPassword
		{
			get { return m_UPassword; }
			set { m_UPassword = value; }
		}
		
		#endregion
		
		#region UName
		
		private string m_UName;
		
		public string UName
		{
			get { return m_UName; }
			set { m_UName = value; }
		}
		
		#endregion
		
		#region UDepart
		
		private string m_UDepart;
		
		public string UDepart
		{
			get { return m_UDepart; }
			set { m_UDepart = value; }
		}
		
		#endregion
		
		#region UPrivilege
		
		private string m_UPrivilege;
		
		public string UPrivilege
		{
			get { return m_UPrivilege; }
			set { m_UPrivilege = value; }
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
			TabUsers castObj = (TabUsers) obj;
			return ( castObj != null )
 && m_UID == castObj.UID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 90;
			hash = hash * 90
 * m_UID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}