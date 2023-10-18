namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes some native Level Snapshots events to Blueprint scripting.</summary>
[CppInclude("LevelSnapshotsEngineSubsystem.h")]
public partial class ULevelSnapshotsEngineSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>FPreTakeSnapshotEvent</summary>
	public void FPreTakeSnapshotEvent(FPreTakeSnapshotEventData_Blueprint EventData) {}
	///<summary>Called before a level snapshot captures the world&#39;s data.</summary>
	public FPreTakeSnapshotEvent OnPreTakeSnapshot;
	///<summary>FPostTakeSnapshotEvent</summary>
	public void FPostTakeSnapshotEvent(FPostTakeSnapshotEventData_Blueprint EventData) {}
	///<summary>Called after a level snapshot captures the world&#39;s data.</summary>
	public FPostTakeSnapshotEvent OnPostTakeSnapshot;
	///<summary>FPreApplySnapshotEvent</summary>
	public void FPreApplySnapshotEvent(FPreApplySnapshotEventData_Blueprint EventData) {}
	///<summary>Called before a level snapshot is applied to a world.</summary>
	public FPreApplySnapshotEvent OnPreApplySnapshot;
	///<summary>FPostApplySnapshotEvent</summary>
	public void FPostApplySnapshotEvent(FPostApplySnapshotEventData_Blueprint EventData) {}
	///<summary>Called after a level snapshot was applied to a world.</summary>
	public FPostApplySnapshotEvent OnPostApplySnapshot;
}
