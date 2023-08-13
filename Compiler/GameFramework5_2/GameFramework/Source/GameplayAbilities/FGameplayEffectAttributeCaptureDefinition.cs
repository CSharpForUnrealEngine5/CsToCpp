namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct defining gameplay attribute capture options for gameplay effects</summary>
[CppInclude("GameplayEffectAttributeCaptureDefinition.h")]
public partial struct FGameplayEffectAttributeCaptureDefinition {
	public FGameplayAttribute AttributeToCapture;
	public EGameplayEffectAttributeCaptureSource AttributeSource;
	public bool bSnapshot;
}
