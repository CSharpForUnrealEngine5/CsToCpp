#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationModifiersAssetUserData.h")]
///<summary>Asset user data which can be added to a USkeleton or UAnimSequence to keep track of Animation Modifiers</summary>
public partial class UAnimationModifiersAssetUserData : UAssetUserData {
// AnimationModifiersAssetUserData
	public TArray<UAnimationModifier> AnimationModifierInstances;
	public TMap<FSoftObjectPath,UAnimationModifier> AppliedModifiers;
}
