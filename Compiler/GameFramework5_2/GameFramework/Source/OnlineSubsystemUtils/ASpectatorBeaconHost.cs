#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpectatorBeaconHost.h")]
///<summary>A beacon host used for taking reservations for an existing game session</summary>
public partial class ASpectatorBeaconHost : AOnlineBeaconHostObject {
// SpectatorBeaconHost
	public USpectatorBeaconState State;
	public bool bLogoutOnSessionTimeout;
	public float SessionTimeoutSecs;
	public float TravelSessionTimeoutSecs;
}
