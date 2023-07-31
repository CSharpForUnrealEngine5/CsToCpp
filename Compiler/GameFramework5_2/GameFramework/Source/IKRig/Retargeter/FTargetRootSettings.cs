#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FTargetRootSettings {
	public float RotationAlpha;
	public float TranslationAlpha;
	public float BlendToSource;
	public FVector BlendToSourceWeights;
	public float ScaleHorizontal;
	public float ScaleVertical;
	public FVector TranslationOffset;
	public FRotator RotationOffset;
	public float AffectIKHorizontal;
	public float AffectIKVertical;
}
