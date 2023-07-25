#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_MultiWayBlend.h")]
///<summary>This represents a baked transition</summary>
public partial struct FAnimNode_MultiWayBlend {
// AnimNode_MultiWayBlend
	public TArray<FPoseLink> Poses;
	public TArray<float> DesiredAlphas;
	public FInputScaleBias AlphaScaleBias;
	public bool bAdditiveNode;
	public bool bNormalizeAlpha;
}
