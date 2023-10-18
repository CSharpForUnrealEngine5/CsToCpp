namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event data is extracted to structs so event delegate signature does not need to be modified in the future.</summary>
[CppInclude("LevelSnapshotsEngineSubsystem.h")]
public partial struct FLevelSnapshotEvent_Blueprint {
	public ULevelSnapshot Snapshot;
}
