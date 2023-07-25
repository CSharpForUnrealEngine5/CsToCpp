#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_PoseSnapshot.h")]
///<summary>Provide a snapshot pose, either from the internal named pose cache or via a supplied snapshot</summary>
public partial struct FAnimNode_PoseSnapshot {
// AnimNode_PoseSnapshot
	public string SnapshotName;
	public FPoseSnapshot Snapshot;
	public ESnapshotSourceMode Mode;
}
