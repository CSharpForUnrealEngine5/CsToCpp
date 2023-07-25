#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpectatorBeaconState.h")]
///<summary>A beacon host used for taking reservations for an existing game session</summary>
public partial class USpectatorBeaconState : UObject {
// SpectatorBeaconState
	public string SessionName;
	public int NumConsumedReservations;
	public int MaxReservations;
	public bool bRestrictCrossConsole;
	public TArray<FSpectatorReservation> Reservations;
}
