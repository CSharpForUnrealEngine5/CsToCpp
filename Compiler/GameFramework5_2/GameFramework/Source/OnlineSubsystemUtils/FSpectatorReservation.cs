#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A whole Spectator reservation</summary>
[CppInclude("SpectatorBeaconState.h")]
public partial struct FSpectatorReservation {
	public FUniqueNetIdRepl SpectatorId;
	public FPlayerReservation Spectator;
}
