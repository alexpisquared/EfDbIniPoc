
using System;
using System.Collections.Generic;
namespace xDbIni
{
	public class LkuLange       /**/ { public int ID { get; set; } public string Name { get; set; } public string Desc { get; set; } }

//public class LkuGenre       /**/ { public int ID { get; set; } public string Name { get; set; } public string Desc { get; set; } }
	public class LkuGenre
	{
		public LkuGenre()
		{
			this.MediaUnits = new List<MediaUnit>();
		}

		public int ID { get; set; }
		public string Name { get; set; }
		public string Desc { get; set; }
		public virtual ICollection<MediaUnit> MediaUnits { get; set; }
	}

	public class MediaUnit
	{
		public MediaUnit()
		{
		}

		public int ID { get; set; }
		public string FileName { get; set; }
		public double DurationSec { get; set; }
		public double CurPositionSec { get; set; }
		public string Notes { get; set; }
		public System.DateTime AddedAt { get; set; }
		public Nullable<int> Genre_ID { get; set; }
		public virtual LkuGenre LkuGenre { get; set; }
	}
}
