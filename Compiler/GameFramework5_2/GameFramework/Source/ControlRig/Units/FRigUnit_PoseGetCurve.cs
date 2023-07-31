#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the hierarchy&#39;s pose curve value</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_PoseGetCurve {
	public FRigPose Pose;
	public string Curve;
	public bool Valid;
	public float CurveValue;
	public int CachedPoseElementIndex;
	public int CachedPoseHash;
}
