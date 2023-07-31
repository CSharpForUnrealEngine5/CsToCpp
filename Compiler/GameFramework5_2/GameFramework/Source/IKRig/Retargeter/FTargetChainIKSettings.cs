#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FTargetChainIKSettings {
	public bool EnableIK;
	public float BlendToSource;
	public FVector BlendToSourceWeights;
	public FVector StaticOffset;
	public FVector StaticLocalOffset;
	public FRotator StaticRotationOffset;
	public float ScaleVertical;
	public float Extension;
	public bool bAffectedByIKWarping;
}
