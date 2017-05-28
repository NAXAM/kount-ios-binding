using System;
using ObjCRuntime;

namespace Kount
{
	[Native]
	public enum KDataCollectorErrorCode : nint
	{
		Unknown = 0,
		NSError,
		Timeout,
		BadParameter,
		NoNetwork,
		ResponseValidation
	}

	[Native]
	public enum KLocationCollectorConfig : nint
	{
		RequestPermission = 0,
		Passive,
		Skip
	}

	[Native]
	public enum KEnvironment : nint
	{
		Unknown = 0,
		Test,
		Production
	}
}
