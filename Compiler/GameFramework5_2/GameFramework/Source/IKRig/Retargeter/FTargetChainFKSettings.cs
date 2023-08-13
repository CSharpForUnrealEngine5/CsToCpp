namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FTargetChainFKSettings {
	public bool EnableFK;
	public ERetargetRotationMode RotationMode;
	public float RotationAlpha;
	public ERetargetTranslationMode TranslationMode;
	public float TranslationAlpha;
	public float PoleVectorMatching;
	public float PoleVectorOffset;
}
