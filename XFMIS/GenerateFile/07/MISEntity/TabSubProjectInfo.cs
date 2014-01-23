using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabSubProjectInfo
	{
		public TabSubProjectInfo()
		{
			m_SPID = 0;
			m_SPProjectID = 0;

		}

		#region SPID
		
		private int m_SPID;
		
		public int SPID
		{
			get { return m_SPID; }
			set { m_SPID = value; }
		}
		
		#endregion
		
		#region SPProjectID
		
		private int m_SPProjectID;
		
		public int SPProjectID
		{
			get { return m_SPProjectID; }
			set { m_SPProjectID = value; }
		}
		
		#endregion
		
		#region SPNO
		
		private string m_SPNO;
		
		public string SPNO
		{
			get { return m_SPNO; }
			set { m_SPNO = value; }
		}
		
		#endregion
		
		#region SPName
		
		private string m_SPName;
		
		public string SPName
		{
			get { return m_SPName; }
			set { m_SPName = value; }
		}
		
		#endregion
		
		#region SPState
		
		private string m_SPState;
		
		public string SPState
		{
			get { return m_SPState; }
			set { m_SPState = value; }
		}
		
		#endregion
		
		#region SPDate
		
		private DateTime? m_SPDate;
		
		public DateTime? SPDate
		{
			get { return m_SPDate; }
			set { m_SPDate = value; }
		}
		
		#endregion
		
		#region SPContractAmount
		
		private decimal? m_SPContractAmount;
		
		public decimal? SPContractAmount
		{
			get { return m_SPContractAmount; }
			set { m_SPContractAmount = value; }
		}
		
		#endregion
		
		#region SPAuditors
		
		private decimal? m_SPAuditors;
		
		public decimal? SPAuditors
		{
			get { return m_SPAuditors; }
			set { m_SPAuditors = value; }
		}
		
		#endregion
		
		#region SPRatio
		
		private decimal? m_SPRatio;
		
		public decimal? SPRatio
		{
			get { return m_SPRatio; }
			set { m_SPRatio = value; }
		}
		
		#endregion
		
		#region SPAllocation
		
		private decimal? m_SPAllocation;
		
		public decimal? SPAllocation
		{
			get { return m_SPAllocation; }
			set { m_SPAllocation = value; }
		}
		
		#endregion
		
		#region SPManager
		
		private string m_SPManager;
		
		public string SPManager
		{
			get { return m_SPManager; }
			set { m_SPManager = value; }
		}
		
		#endregion
		
		#region SPTel
		
		private string m_SPTel;
		
		public string SPTel
		{
			get { return m_SPTel; }
			set { m_SPTel = value; }
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
			TabSubProjectInfo castObj = (TabSubProjectInfo) obj;
			return ( castObj != null )
 && m_SPID == castObj.SPID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 80;
			hash = hash * 80
 * m_SPID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}