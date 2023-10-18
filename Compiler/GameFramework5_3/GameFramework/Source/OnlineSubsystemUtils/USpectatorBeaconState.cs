namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A beacon host used for taking reservations for an existing game session</summary>
[CppInclude("SpectatorBeaconState.h")]
public partial class USpectatorBeaconState : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Session tied to the beacon</summary>
	public FName SessionName;
	///<summary>Number of currently consumed reservations</summary>
	public int NumConsumedReservations;
	///<summary>Maximum allowed reservations</summary>
	public int MaxReservations;
	///<summary>Are multiple consoles types allowed to play together</summary>
	public bool bRestrictCrossConsole;
	///<summary>Current reservations in the system</summary>
	public TArray<FSpectatorReservation> Reservations;
}
