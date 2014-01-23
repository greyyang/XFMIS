using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabStateRecord
	{
		public TabStateRecord()
		{
			m_SRID = 0;
			m_SRProjectID = 0;

		}

		#region SRID
		
		private int m_SRID;
		
		public int SRID
		{
			get { return m_SRID; }
			set { m_SRID = value; }
		}
		
		#endregion
		
		#region SRProjectID
		
		private int m_SRProjectID;
		
		public int SRProjectID
		{
			get { return m_SRProjectID; }
			set { m_SRProjectID = value; }
		}
		
		#endregion
		
		#region SRModifier
		
		private string m_SRModifier;
		
		public string SRModifier
		{
			get { return m_SRModifier; }
			set { m_SRModifier = value; }
		}
		
		#endregion
		
		#region SRDate
		
		private  m_SRDate;
		
		public  SRDate
		{
			get { return m_SRDate; }
			set { m_SRDate = value; }
		}
		
		#endregion
		
		#region SRMemo
		
		private string m_SRMemo;
		
		public string SRMemo
		{
			get { return m_SRMemo; }
			set { m_SRMemo = value; }
		}
		
		#endregion
		
		#region SRSub
		
		private int? m_SRSub;
		
		public int? SRSub
		{
			get { return m_SRSub; }
			set { m_SRSub = value; }
		}
		
		#endregion
		
		#region SRFlag
		
		private int? m_SRFlag;
		
		public int? SRFlag
		{
			get { return m_SRFlag; }
			set { m_SRFlag = value; }
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
			TabStateRecord castObj = (TabStateRecord) obj;
			return ( castObj != null )
 && m_SRID == castObj.SRID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 25;
			hash = hash * 25
 * m_SRID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}