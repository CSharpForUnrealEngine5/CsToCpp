#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the node that apply corrective morphtarget for twist</summary>
[CppInclude("BoneControllers/AnimNode_TwistCorrectiveNode.h")]
public partial struct FAnimNode_TwistCorrectiveNode {
	public FReferenceBoneFrame BaseFrame;
	public FReferenceBoneFrame TwistFrame;
	public FAxis TwistPlaneNormalAxis;
	public float RangeMax;
	public float RemappedMin;
	public float RemappedMax;
	public FAnimCurveParam Curve;
}
