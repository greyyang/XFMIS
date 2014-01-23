using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabStorage
	{
		public TabStorage()
		{
			m_StID = 0;

		}

		#region StID
		
		private int m_StID;
		
		public int StID
		{
			get { return m_StID; }
			set { m_StID = value; }
		}
		
		#endregion
		
		#region StSubProjectID
		
		private int? m_StSubProjectID;
		
		public int? StSubProjectID
		{
			get { return m_StSubProjectID; }
			set { m_StSubProjectID = value; }
		}
		
		#endregion
		
		#region StMaterial
		
		private string m_StMaterial;
		
		public string StMaterial
		{
			get { return m_StMaterial; }
			set { m_StMaterial = value; }
		}
		
		#endregion
		
		#region StCount
		
		private decimal? m_StCount;
		
		public decimal? StCount
		{
			get { return m_StCount; }
			set { m_StCount = value; }
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
			TabStorage castObj = (TabStorage) obj;
			return ( castObj != null )
 && m_StID == castObj.StID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 74;
			hash = hash * 74
 * m_StID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}