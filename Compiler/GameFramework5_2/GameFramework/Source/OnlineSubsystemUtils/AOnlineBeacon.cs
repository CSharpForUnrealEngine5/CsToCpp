#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for beacon communication (Unreal Networking, but outside normal gameplay traffic)</summary>
[CppInclude("OnlineBeacon.h")]
public partial class AOnlineBeacon : AActor {
	///<summary>Time beacon will wait to establish a connection with the beacon host</summary>
	public float BeaconConnectionInitialTimeout;
	///<summary>Time beacon will wait for packets after establishing a connection before giving up</summary>
	public float BeaconConnectionTimeout;
	///<summary>Net driver routing network traffic</summary>
	public UNetDriver NetDriver;
}
