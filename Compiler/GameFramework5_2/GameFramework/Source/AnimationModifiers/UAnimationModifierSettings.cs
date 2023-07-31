#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationModifierSettings.h")]
public partial class UAnimationModifierSettings : UDeveloperSettings {
	///<summary>Set of Animation Modifiers to be added whenever a new Animation Sequence is imported</summary>
	public TArray<UClass> DefaultAnimationModifiers;
	///<summary>Whether or not to apply animation modifiers post (re)import</summary>
	public bool bApplyAnimationModifiersOnImport;
}
