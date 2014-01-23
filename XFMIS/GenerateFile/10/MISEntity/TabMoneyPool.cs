using System;
using System.Collections.Generic;

namespace MISEntity.Entity
{
    [Serializable]
	public class TabMoneyPool
	{
		public TabMoneyPool()
		{
			m_MPID = 0;

		}

		#region MPID
		
		private int m_MPID;
		
		public int MPID
		{
			get { return m_MPID; }
			set { m_MPID = value; }
		}
		
		#endregion
		
		#region MPMoney
		
		private decimal? m_MPMoney;
		
		public decimal? MPMoney
		{
			get { return m_MPMoney; }
			set { m_MPMoney = value; }
		}
		
		#endregion
		
		#region MPHandler
		
		private string m_MPHandler;
		
		public string MPHandler
		{
			get { return m_MPHandler; }
			set { m_MPHandler = value; }
		}
		
		#endregion
		
		#region MPDate
		
		private DateTime? m_MPDate;
		
		public DateTime? MPDate
		{
			get { return m_MPDate; }
			set { m_MPDate = value; }
		}
		
		#endregion
		
		#region MPMemo
		
		private string m_MPMemo;
		
		public string MPMemo
		{
			get { return m_MPMemo; }
			set { m_MPMemo = value; }
		}
		
		#endregion
		
		#region MPFlag
		
		private int? m_MPFlag;
		
		public int? MPFlag
		{
			get { return m_MPFlag; }
			set { m_MPFlag = value; }
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
			TabMoneyPool castObj = (TabMoneyPool) obj;
			return ( castObj != null )
;		}
		
		/// <summary>
		/// 用唯一值实现GetHashCode
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 35;
			hash = hash * 35
;			return hash;
		}
		
		#endregion
		
		
	}
}