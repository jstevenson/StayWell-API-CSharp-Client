namespace StayWell.ServiceDefinitions.Content.Objects {
	/// <summary>
	/// Reference used for added, updated, or deleted content
	/// </summary>
	public class ContentModificationItem {
		/// <summary>
		/// Content slug
		/// </summary>
		public string ContentSlug { get; set; }

		/// <summary>
		/// Bucket slug
		/// </summary>
		public string BucketSlug { get; set; }
	}
}
