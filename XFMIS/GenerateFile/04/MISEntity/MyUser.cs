using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class MyUser
	{
		public MyUser()
		{
			m_Uid = 0;

		}

		#region Uid
		
		private int m_Uid;
		
		public int Uid
		{
			get { return m_Uid; }
			set { m_Uid = value; }
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
		
		#region ClassID
		
		private int? m_ClassID;
		
		public int? ClassID
		{
			get { return m_ClassID; }
			set { m_ClassID = value; }
		}
		
		#endregion
		
		#region GradeID
		
		private int? m_GradeID;
		
		public int? GradeID
		{
			get { return m_GradeID; }
			set { m_GradeID = value; }
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
			MyUser castObj = (MyUser) obj;
			return ( castObj != null )
 && m_Uid == castObj.Uid;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 89;
			hash = hash * 89
 * m_Uid.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}