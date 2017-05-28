using System;
using Foundation;
using ObjCRuntime;

namespace Kount
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull KDataCollectorErrorDomain;
		[Field ("KDataCollectorErrorDomain", "__Internal")]
		NSString KDataCollectorErrorDomain { get; }

		// extern NSString *const _Nonnull KDataCollectorVersion;
		[Field ("KDataCollectorVersion", "__Internal")]
		NSString KDataCollectorVersion { get; }
	}

	// @interface KDataCollector : NSObject
	[BaseType (typeof(NSObject))]
	interface KDataCollector
	{
		// +(KDataCollector * _Nonnull)sharedCollector;
		[Static]
		[Export ("sharedCollector")]
		[Verify (MethodToProperty)]
		KDataCollector SharedCollector { get; }

		// @property NSInteger merchantID;
		[Export ("merchantID")]
		nint MerchantID { get; set; }

		// @property KLocationCollectorConfig locationCollectorConfig;
		[Export ("locationCollectorConfig", ArgumentSemantic.Assign)]
		KLocationCollectorConfig LocationCollectorConfig { get; set; }

		// @property BOOL debug;
		[Export ("debug")]
		bool Debug { get; set; }

		// @property NSInteger timeoutInMS;
		[Export ("timeoutInMS")]
		nint TimeoutInMS { get; set; }

		// @property KEnvironment environment;
		[Export ("environment", ArgumentSemantic.Assign)]
		KEnvironment Environment { get; set; }

		// -(void)collectForSession:(NSString * _Nonnull)sessionID completion:(void (^ _Nullable)(NSString * _Nonnull, BOOL, NSError * _Nullable))completionBlock;
		[Export ("collectForSession:completion:")]
		void CollectForSession (string sessionID, [NullAllowed] Action<NSString, bool, NSError> completionBlock);
	}
}
