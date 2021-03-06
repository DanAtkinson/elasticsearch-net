// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Administering
{
	public class BackupAndRestoreSecurityConfigPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line79()
		{
			// tag::92b3749a473cf2e7ff4055316662a4fe[]
			var response0 = new SearchResponse<object>();
			// end::92b3749a473cf2e7ff4055316662a4fe[]

			response0.MatchesExample(@"PUT /_snapshot/my_backup
			{
			  ""type"": ""fs"",
			  ""settings"": {
			    ""location"": ""my_backup_location""
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line103()
		{
			// tag::43a7b43711eab81ad093e67ecc221327[]
			var response0 = new SearchResponse<object>();
			// end::43a7b43711eab81ad093e67ecc221327[]

			response0.MatchesExample(@"POST /_security/user/snapshot_user
			{
			  ""password"" : ""secret"",
			  ""roles"" : [ ""snapshot_user"" ]
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line122()
		{
			// tag::7acf1099282366553cb8b093ed4fcd00[]
			var response0 = new SearchResponse<object>();
			// end::7acf1099282366553cb8b093ed4fcd00[]

			response0.MatchesExample(@"PUT /_snapshot/my_backup/snapshot_1
			{
			  ""indices"": "".security"",
			  ""include_global_state"": true \<1>
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line193()
		{
			// tag::ff930e6409b6a923ef1c9e7fc99f24cc[]
			var response0 = new SearchResponse<object>();
			// end::ff930e6409b6a923ef1c9e7fc99f24cc[]

			response0.MatchesExample(@"GET /_snapshot/my_backup");
		}

		[U(Skip = "Example not implemented")]
		public void Line200()
		{
			// tag::020c56e520ff6556ebfaf98efaef56aa[]
			var response0 = new SearchResponse<object>();
			// end::020c56e520ff6556ebfaf98efaef56aa[]

			response0.MatchesExample(@"GET /_snapshot/my_backup/snapshot_1");
		}
	}
}