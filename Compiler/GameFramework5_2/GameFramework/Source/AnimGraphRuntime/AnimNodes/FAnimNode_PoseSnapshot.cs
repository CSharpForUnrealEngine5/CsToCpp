#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provide a snapshot pose, either from the internal named pose cache or via a supplied snapshot</summary>
[CppInclude("AnimNodes/AnimNode_PoseSnapshot.h")]
public partial struct FAnimNode_PoseSnapshot {
	public string SnapshotName;
	public FPoseSnapshot Snapshot;
	public ESnapshotSourceMode Mode;
}
