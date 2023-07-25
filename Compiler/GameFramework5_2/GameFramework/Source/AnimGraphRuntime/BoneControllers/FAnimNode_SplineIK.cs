#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_SplineIK.h")]
public partial struct FAnimNode_SplineIK {
// AnimNode_SplineIK
	public FBoneReference StartBone;
	public FBoneReference EndBone;
	public ESplineBoneAxis BoneAxis;
	public bool bAutoCalculateSpline;
	public int PointCount;
	public TArray<FTransform> ControlPoints;
	public float Roll;
	public float TwistStart;
	public float TwistEnd;
	public FAlphaBlend TwistBlend;
	public float Stretch;
	public float Offset;
}
