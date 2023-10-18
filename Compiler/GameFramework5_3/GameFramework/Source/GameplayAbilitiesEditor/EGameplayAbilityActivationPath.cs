namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayAbilityAudit.h")]
///<summary>This enum indicates what flow the Blueprint takes once activated (or native if not Activate is not handled by Blueprints)</summary>
public enum EGameplayAbilityActivationPath {
	Native=0,
	Blueprint=1,
	FromEvent=2,
}
