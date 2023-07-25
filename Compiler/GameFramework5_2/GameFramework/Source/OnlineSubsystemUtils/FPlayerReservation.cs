#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineBeaconReservation.h")]
///<summary>A single player reservation</summary>
public partial struct FPlayerReservation {
// PlayerReservation
	public FUniqueNetIdRepl UniqueId;
	public string ValidationStr;
	public string Platform;
	public bool bAllowCrossplay;
	public float ElapsedTime;
}
