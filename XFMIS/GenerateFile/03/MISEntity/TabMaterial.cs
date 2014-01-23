using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabMaterial
	{
		public TabMaterial()
		{
			m_MID = 0;

		}

		#region MID
		
		private int m_MID;
		
		public int MID
		{
			get { return m_MID; }
			set { m_MID = value; }
		}
		
		#endregion
		
		#region MName
		
		private string m_MName;
		
		public string MName
		{
			get { return m_MName; }
			set { m_MName = value; }
		}
		
		#endregion
		
		#region MType
		
		private string m_MType;
		
		public string MType
		{
			get { return m_MType; }
			set { m_MType = value; }
		}
		
		#endregion
		
		#region MUnit
		
		private string m_MUnit;
		
		public string MUnit
		{
			get { return m_MUnit; }
			set { m_MUnit = value; }
		}
		
		#endregion
		
		#region MCode
		
		private string m_MCode;
		
		public string MCode
		{
			get { return m_MCode; }
			set { m_MCode = value; }
		}
		
		#endregion
		
		#region MMemo
		
		private string m_MMemo;
		
		public string MMemo
		{
			get { return m_MMemo; }
			set { m_MMemo = value; }
		}
		
		#endregion
		
		#region MClass
		
		private string m_MClass;
		
		public string MClass
		{
			get { return m_MClass; }
			set { m_MClass = value; }
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
			TabMaterial castObj = (TabMaterial) obj;
			return ( castObj != null )
 && m_MID == castObj.MID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 28;
			hash = hash * 28
 * m_MID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}