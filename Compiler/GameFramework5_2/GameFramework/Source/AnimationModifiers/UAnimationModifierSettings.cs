namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationModifierSettings.h")]
public partial class UAnimationModifierSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Set of Animation Modifiers to be added whenever a new Animation Sequence is imported</summary>
	public TArray<UClass> DefaultAnimationModifiers;
	///<summary>Whether or not to apply animation modifiers post (re)import</summary>
	public bool bApplyAnimationModifiersOnImport;
}
