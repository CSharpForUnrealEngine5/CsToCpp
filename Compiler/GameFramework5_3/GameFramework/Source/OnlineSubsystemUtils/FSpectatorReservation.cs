namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A whole Spectator reservation</summary>
[CppInclude("SpectatorBeaconState.h")]
public partial struct FSpectatorReservation {
	public FUniqueNetIdRepl SpectatorId;
	public FPlayerReservation Spectator;
}
