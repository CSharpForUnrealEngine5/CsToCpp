#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This represents a baked transition</summary>
[CppInclude("AnimNodes/AnimNode_MultiWayBlend.h")]
public partial struct FAnimNode_MultiWayBlend {
	public TArray<FPoseLink> Poses;
	public TArray<float> DesiredAlphas;
	public FInputScaleBias AlphaScaleBias;
	public bool bAdditiveNode;
	public bool bNormalizeAlpha;
}
