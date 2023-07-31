#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stage event to notify of missed sync (genlock) signals</summary>
[CppInclude("GenlockWatchdog.h")]
public partial struct FGenlockHitchEvent {
	public int MissedSyncSignals;
}
