namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon host used for taking reservations for an existing game session</summary>
[CppInclude("PartyBeaconHost.h")]
public partial class APartyBeaconHost : AOnlineBeaconHostObject {
	public static UClass StaticClass() {return default;}
	///<summary>State of the beacon</summary>
	public UPartyBeaconState State;
	///<summary>Do the timeouts below cause a player to be removed from the reservation list</summary>
	public bool bLogoutOnSessionTimeout;
	///<summary>Seconds that can elapse before a reservation is removed due to player not being registered with the session</summary>
	public float SessionTimeoutSecs;
	///<summary>Seconds that can elapse before a reservation is removed due to player not being registered with the session during a travel</summary>
	public float TravelSessionTimeoutSecs;
}
