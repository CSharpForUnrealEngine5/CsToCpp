namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Annotation to allow to find slots based on a Gameplay Tag.</summary>
[CppInclude("Annotations/SmartObjectSlotLinkAnnotation.h")]
public partial struct FSmartObjectSlotLinkAnnotation {
	public FGameplayTag Tag;
	public FSmartObjectSlotReference LinkedSlot;
}
