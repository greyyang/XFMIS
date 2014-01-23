using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabMaterialFlow
	{
		public TabMaterialFlow()
		{
			m_MFID = 0;

		}

		#region MFID
		
		private int m_MFID;
		
		public int MFID
		{
			get { return m_MFID; }
			set { m_MFID = value; }
		}
		
		#endregion
		
		#region MFSubProjectID
		
		private int? m_MFSubProjectID;
		
		public int? MFSubProjectID
		{
			get { return m_MFSubProjectID; }
			set { m_MFSubProjectID = value; }
		}
		
		#endregion
		
		#region MFProject
		
		private int? m_MFProject;
		
		public int? MFProject
		{
			get { return m_MFProject; }
			set { m_MFProject = value; }
		}
		
		#endregion
		
		#region MFAmount
		
		private decimal? m_MFAmount;
		
		public decimal? MFAmount
		{
			get { return m_MFAmount; }
			set { m_MFAmount = value; }
		}
		
		#endregion
		
		#region MFFlag
		
		private int? m_MFFlag;
		
		public int? MFFlag
		{
			get { return m_MFFlag; }
			set { m_MFFlag = value; }
		}
		
		#endregion
		
		#region MFMaterialID
		
		private int? m_MFMaterialID;
		
		public int? MFMaterialID
		{
			get { return m_MFMaterialID; }
			set { m_MFMaterialID = value; }
		}
		
		#endregion
		
		#region MFDatetime
		
		private DateTime? m_MFDatetime;
		
		public DateTime? MFDatetime
		{
			get { return m_MFDatetime; }
			set { m_MFDatetime = value; }
		}
		
		#endregion
		
		#region MFMemo
		
		private string m_MFMemo;
		
		public string MFMemo
		{
			get { return m_MFMemo; }
			set { m_MFMemo = value; }
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
			TabMaterialFlow castObj = (TabMaterialFlow) obj;
			return ( castObj != null )
 && m_MFID == castObj.MFID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 50;
			hash = hash * 50
 * m_MFID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}