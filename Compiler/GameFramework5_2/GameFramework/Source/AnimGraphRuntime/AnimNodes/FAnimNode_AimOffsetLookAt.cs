namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This node uses a source transform of a socket on the skeletal mesh to automatically calculate</summary>
[CppInclude("AnimNodes/AnimNode_AimOffsetLookAt.h")]
public partial struct FAnimNode_AimOffsetLookAt {
	public FPoseLink BasePose;
	public int LODThreshold;
	public string SourceSocketName;
	public string PivotSocketName;
	public FVector LookAtLocation;
	public FVector SocketAxis;
	public float Alpha;
}
