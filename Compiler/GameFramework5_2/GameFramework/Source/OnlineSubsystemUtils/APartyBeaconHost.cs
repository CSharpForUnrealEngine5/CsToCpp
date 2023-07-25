#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PartyBeaconHost.h")]
///<summary>A beacon host used for taking reservations for an existing game session</summary>
public partial class APartyBeaconHost : AOnlineBeaconHostObject {
// PartyBeaconHost
	public UPartyBeaconState State;
	public bool bLogoutOnSessionTimeout;
	public float SessionTimeoutSecs;
	public float TravelSessionTimeoutSecs;
}
