using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabProjectInfo
	{
		public TabProjectInfo()
		{
			m_PID = 0;

		}

		#region PID
		
		private int m_PID;
		
		public int PID
		{
			get { return m_PID; }
			set { m_PID = value; }
		}
		
		#endregion
		
		#region PNO
		
		private string m_PNO;
		
		public string PNO
		{
			get { return m_PNO; }
			set { m_PNO = value; }
		}
		
		#endregion
		
		#region PName
		
		private string m_PName;
		
		public string PName
		{
			get { return m_PName; }
			set { m_PName = value; }
		}
		
		#endregion
		
		#region PConstruction
		
		private string m_PConstruction;
		
		public string PConstruction
		{
			get { return m_PConstruction; }
			set { m_PConstruction = value; }
		}
		
		#endregion
		
		#region PBuilder
		
		private string m_PBuilder;
		
		public string PBuilder
		{
			get { return m_PBuilder; }
			set { m_PBuilder = value; }
		}
		
		#endregion
		
		#region PState
		
		private string m_PState;
		
		public string PState
		{
			get { return m_PState; }
			set { m_PState = value; }
		}
		
		#endregion
		
		#region PCustomer
		
		private string m_PCustomer;
		
		public string PCustomer
		{
			get { return m_PCustomer; }
			set { m_PCustomer = value; }
		}
		
		#endregion
		
		#region PCategory
		
		private string m_PCategory;
		
		public string PCategory
		{
			get { return m_PCategory; }
			set { m_PCategory = value; }
		}
		
		#endregion
		
		#region PBusinessPlan
		
		private string m_PBusinessPlan;
		
		public string PBusinessPlan
		{
			get { return m_PBusinessPlan; }
			set { m_PBusinessPlan = value; }
		}
		
		#endregion
		
		#region PDateTime
		
		private DateTime? m_PDateTime;
		
		public DateTime? PDateTime
		{
			get { return m_PDateTime; }
			set { m_PDateTime = value; }
		}
		
		#endregion
		
		#region PContractAmount
		
		private decimal? m_PContractAmount;
		
		public decimal? PContractAmount
		{
			get { return m_PContractAmount; }
			set { m_PContractAmount = value; }
		}
		
		#endregion
		
		#region PAuditors
		
		private decimal? m_PAuditors;
		
		public decimal? PAuditors
		{
			get { return m_PAuditors; }
			set { m_PAuditors = value; }
		}
		
		#endregion
		
		#region PPlan
		
		private decimal? m_PPlan;
		
		public decimal? PPlan
		{
			get { return m_PPlan; }
			set { m_PPlan = value; }
		}
		
		#endregion
		
		#region PRatio
		
		private decimal? m_PRatio;
		
		public decimal? PRatio
		{
			get { return m_PRatio; }
			set { m_PRatio = value; }
		}
		
		#endregion
		
		#region PDisclosure
		
		private DateTime? m_PDisclosure;
		
		public DateTime? PDisclosure
		{
			get { return m_PDisclosure; }
			set { m_PDisclosure = value; }
		}
		
		#endregion
		
		#region PStartDate
		
		private DateTime? m_PStartDate;
		
		public DateTime? PStartDate
		{
			get { return m_PStartDate; }
			set { m_PStartDate = value; }
		}
		
		#endregion
		
		#region PEndDate
		
		private DateTime? m_PEndDate;
		
		public DateTime? PEndDate
		{
			get { return m_PEndDate; }
			set { m_PEndDate = value; }
		}
		
		#endregion
		
		#region PDesignChange
		
		private short? m_PDesignChange;
		
		public short? PDesignChange
		{
			get { return m_PDesignChange; }
			set { m_PDesignChange = value; }
		}
		
		#endregion
		
		#region PDataIn
		
		private short? m_PDataIn;
		
		public short? PDataIn
		{
			get { return m_PDataIn; }
			set { m_PDataIn = value; }
		}
		
		#endregion
		
		#region PCompletion
		
		private string m_PCompletion;
		
		public string PCompletion
		{
			get { return m_PCompletion; }
			set { m_PCompletion = value; }
		}
		
		#endregion
		
		#region PManager
		
		private string m_PManager;
		
		public string PManager
		{
			get { return m_PManager; }
			set { m_PManager = value; }
		}
		
		#endregion
		
		#region PTel
		
		private string m_PTel;
		
		public string PTel
		{
			get { return m_PTel; }
			set { m_PTel = value; }
		}
		
		#endregion
		
		#region PTeleComNO
		
		private string m_PTeleComNO;
		
		public string PTeleComNO
		{
			get { return m_PTeleComNO; }
			set { m_PTeleComNO = value; }
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
			TabProjectInfo castObj = (TabProjectInfo) obj;
			return ( castObj != null )
 && m_PID == castObj.PID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 75;
			hash = hash * 75
 * m_PID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}