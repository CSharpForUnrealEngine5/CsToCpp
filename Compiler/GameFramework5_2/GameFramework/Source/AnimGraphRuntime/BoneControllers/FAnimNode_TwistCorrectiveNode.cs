#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_TwistCorrectiveNode.h")]
///<summary>This is the node that apply corrective morphtarget for twist</summary>
public partial struct FAnimNode_TwistCorrectiveNode {
// AnimNode_TwistCorrectiveNode
	public FReferenceBoneFrame BaseFrame;
	public FReferenceBoneFrame TwistFrame;
	public FAxis TwistPlaneNormalAxis;
	public float RangeMax;
	public float RemappedMin;
	public float RemappedMax;
	public FAnimCurveParam Curve;
}
