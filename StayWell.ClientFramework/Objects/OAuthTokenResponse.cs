﻿// ReSharper disable InconsistentNaming

using System.Xml.Serialization;

namespace KswApi.Interface.Objects
{
	[XmlRoot("token")]
	public class OAuthTokenResponse
	{
		public string access_token { get; set; }
		public string token_type { get; set; }
		public int expires_in { get; set; }
		public string refresh_token { get; set; }
		public string scope { get; set; }
	}
}
