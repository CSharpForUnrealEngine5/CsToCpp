namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset user data which can be added to a USkeleton or UAnimSequence to keep track of Animation Modifiers</summary>
[CppInclude("AnimationModifiersAssetUserData.h")]
public partial class UAnimationModifiersAssetUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>AnimationModifierInstances</summary>
	public TArray<UAnimationModifier> AnimationModifierInstances;
	///<summary>Animation modifiers APPLIED on the owning animation sequence</summary>
	public TMap<FSoftObjectPath,UAnimationModifier> AppliedModifiers;
}
