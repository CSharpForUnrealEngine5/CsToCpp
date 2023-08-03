#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkXRSourceSettings.h")]
public partial class ULiveLinkXRSourceSettings : ULiveLinkSourceSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Update rate (in Hz) at which to read the tracking data for each device</summary>
	public uint LocalUpdateRateInHz;
}
