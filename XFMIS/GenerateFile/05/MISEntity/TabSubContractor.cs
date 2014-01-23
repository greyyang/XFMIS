using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabSubContractor
	{
		public TabSubContractor()
		{
			m_SCID = 0;

		}

		#region SCID
		
		private int m_SCID;
		
		public int SCID
		{
			get { return m_SCID; }
			set { m_SCID = value; }
		}
		
		#endregion
		
		#region SCName
		
		private string m_SCName;
		
		public string SCName
		{
			get { return m_SCName; }
			set { m_SCName = value; }
		}
		
		#endregion
		
		#region SCBankAccount
		
		private string m_SCBankAccount;
		
		public string SCBankAccount
		{
			get { return m_SCBankAccount; }
			set { m_SCBankAccount = value; }
		}
		
		#endregion
		
		#region SCBank
		
		private string m_SCBank;
		
		public string SCBank
		{
			get { return m_SCBank; }
			set { m_SCBank = value; }
		}
		
		#endregion
		
		#region SCContactor
		
		private string m_SCContactor;
		
		public string SCContactor
		{
			get { return m_SCContactor; }
			set { m_SCContactor = value; }
		}
		
		#endregion
		
		#region SCTel
		
		private string m_SCTel;
		
		public string SCTel
		{
			get { return m_SCTel; }
			set { m_SCTel = value; }
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
			TabSubContractor castObj = (TabSubContractor) obj;
			return ( castObj != null )
 && m_SCID == castObj.SCID;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 4;
			hash = hash * 4
 * m_SCID.GetHashCode();			return hash;
		}
		
		#endregion
		
		
	}
}