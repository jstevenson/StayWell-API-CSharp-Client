using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace StayWell.ServiceDefinitions.Content.Objects {
	/// <summary>
	/// List of added, updated, or deleted content
	/// </summary>
	[XmlType("ModifiedContentResponse")]
	public class ContentModifications {
		/// <summary>
		/// Requested start time to return modifications from.
		/// </summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// List of content items that have been added
		/// </summary>
		public List<ContentModificationItem> Additions { get; set; }

		/// <summary>
		/// List of content items that have been removed
		/// </summary>
		public List<ContentModificationItem> Removals { get; set; }

		/// <summary>
		/// List of content items that have been updated
		/// </summary>
		public List<ContentModificationItem> Updates { get; set; }
	}
}
