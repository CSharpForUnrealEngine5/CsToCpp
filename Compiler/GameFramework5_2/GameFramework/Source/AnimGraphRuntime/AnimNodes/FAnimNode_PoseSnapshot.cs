namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provide a snapshot pose, either from the internal named pose cache or via a supplied snapshot</summary>
[CppInclude("AnimNodes/AnimNode_PoseSnapshot.h")]
public partial struct FAnimNode_PoseSnapshot {
	public FName SnapshotName;
	public FPoseSnapshot Snapshot;
	public ESnapshotSourceMode Mode;
}
