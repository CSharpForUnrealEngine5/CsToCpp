#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Returns the hierarchy's pose curve value</summary>
public partial struct FRigUnit_PoseGetCurve {
// RigUnit_PoseGetCurve
	public FRigPose Pose;
	public string Curve;
	public bool Valid;
	public float CurveValue;
	public int CachedPoseElementIndex;
	public int CachedPoseHash;
}
