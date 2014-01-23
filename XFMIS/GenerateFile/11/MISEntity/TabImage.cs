using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabImage
	{
		public TabImage()
		{
			m_TIID = 0;

		}

		#region TIID
		
		private int m_TIID;
		
		public int TIID
		{
			get { return m_TIID; }
			set { m_TIID = value; }
		}
		
		#endregion
		
		#region TIProjectID
		
		private int? m_TIProjectID;
		
		public int? TIProjectID
		{
			get { return m_TIProjectID; }
			set { m_TIProjectID = value; }
		}
		
		#endregion
		
		#region TISubProjectID
		
		private int? m_TISubProjectID;
		
		public int? TISubProjectID
		{
			get { return m_TISubProjectID; }
			set { m_TISubProjectID = value; }
		}
		
		#endregion
		
		#region TINO
		
		private int? m_TINO;
		
		public int? TINO
		{
			get { return m_TINO; }
			set { m_TINO = value; }
		}
		
		#endregion
		
		#region TIImage
		
		private byte[] m_TIImage;
		
		public byte[] TIImage
		{
			get { return m_TIImage; }
			set { m_TIImage = value; }
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
			TabImage castObj = (TabImage) obj;
			return ( castObj != null )
 && m_TIID == castObj.TIID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 77;
			hash = hash * 77
 * m_TIID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}