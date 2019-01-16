using System.Runtime.Serialization;

namespace Nest
{
	[StringEnum]
	public enum LogLevel
	{
		[EnumMember(Value = "error")]
		Error,

		[EnumMember(Value = "warn")]
		Warn,

		[EnumMember(Value = "info")]
		Info,

		[EnumMember(Value = "debug")]
		Debug,

		[EnumMember(Value = "trace")]
		Trace
	}
}
