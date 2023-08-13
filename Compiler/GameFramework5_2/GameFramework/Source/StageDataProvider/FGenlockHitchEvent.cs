namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stage event to notify of missed sync (genlock) signals</summary>
[CppInclude("GenlockWatchdog.h")]
public partial struct FGenlockHitchEvent {
	public int MissedSyncSignals;
}
