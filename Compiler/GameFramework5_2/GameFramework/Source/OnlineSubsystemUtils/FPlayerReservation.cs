#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single player reservation</summary>
[CppInclude("OnlineBeaconReservation.h")]
public partial struct FPlayerReservation {
	public FUniqueNetIdRepl UniqueId;
	public string ValidationStr;
	public string Platform;
	public bool bAllowCrossplay;
	public float ElapsedTime;
}
