#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon host used for taking reservations for an existing game session</summary>
[CppInclude("SpectatorBeaconHost.h")]
public partial class ASpectatorBeaconHost : AOnlineBeaconHostObject {
	///<summary>State of the beacon</summary>
	public USpectatorBeaconState State;
	///<summary>Do the timeouts below cause a player to be removed from the reservation list</summary>
	public bool bLogoutOnSessionTimeout;
	///<summary>Seconds that can elapse before a reservation is removed due to player not being registered with the session</summary>
	public float SessionTimeoutSecs;
	///<summary>Seconds that can elapse before a reservation is removed due to player not being registered with the session during a travel</summary>
	public float TravelSessionTimeoutSecs;
}
