using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class Sysdiagrams
	{
		public Sysdiagrams()
		{
			m_Name = ;
			m_PrincipalId = 0;
			m_DiagramId = 0;

		}

		#region Name
		
		private  m_Name;
		
		public  Name
		{
			get { return m_Name; }
			set { m_Name = value; }
		}
		
		#endregion
		
		#region PrincipalId
		
		private int m_PrincipalId;
		
		public int PrincipalId
		{
			get { return m_PrincipalId; }
			set { m_PrincipalId = value; }
		}
		
		#endregion
		
		#region DiagramId
		
		private int m_DiagramId;
		
		public int DiagramId
		{
			get { return m_DiagramId; }
			set { m_DiagramId = value; }
		}
		
		#endregion
		
		#region Version
		
		private int? m_Version;
		
		public int? Version
		{
			get { return m_Version; }
			set { m_Version = value; }
		}
		
		#endregion
		
		#region Definition
		
		private byte[] m_Definition;
		
		public byte[] Definition
		{
			get { return m_Definition; }
			set { m_Definition = value; }
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
			Sysdiagrams castObj = (Sysdiagrams) obj;
			return ( castObj != null )
 && m_DiagramId == castObj.DiagramId;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 12;
			hash = hash * 12
 * m_DiagramId.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}