#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluates a point in a blendspace, using a specific time input rather than advancing time internally.</summary>
[CppInclude("AnimNodes/AnimNode_BlendSpaceEvaluator.h")]
public partial struct FAnimNode_BlendSpaceEvaluator {
	public float NormalizedTime;
	public bool bTeleportToNormalizedTime;
}
