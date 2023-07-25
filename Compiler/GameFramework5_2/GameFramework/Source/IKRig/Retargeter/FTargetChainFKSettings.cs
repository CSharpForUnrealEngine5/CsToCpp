#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FTargetChainFKSettings {
// TargetChainFKSettings
	public bool EnableFK;
	public ERetargetRotationMode RotationMode;
	public float RotationAlpha;
	public ERetargetTranslationMode TranslationMode;
	public float TranslationAlpha;
	public float PoleVectorMatching;
	public float PoleVectorOffset;
}
