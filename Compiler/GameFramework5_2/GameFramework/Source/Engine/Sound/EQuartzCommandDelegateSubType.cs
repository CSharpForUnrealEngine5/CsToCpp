#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
///<summary>An enumeration for specifying different TYPES of delegates</summary>
public enum EQuartzCommandDelegateSubType {
	CommandOnFailedToQueue=0,
	CommandOnQueued=1,
	CommandOnCanceled=2,
	CommandOnAboutToStart=3,
	CommandOnStarted=4,
	Count=5,
}
