#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineBeacon.h")]
///<summary>Base class for beacon communication (Unreal Networking, but outside normal gameplay traffic)</summary>
public partial class AOnlineBeacon : AActor {
// OnlineBeacon
	public float BeaconConnectionInitialTimeout;
	public float BeaconConnectionTimeout;
	public UNetDriver NetDriver;
}
