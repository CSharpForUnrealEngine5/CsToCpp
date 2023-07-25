#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Annotations/SmartObjectSlotLinkAnnotation.h")]
///<summary>Annotation to allow to find slots based on a Gameplay Tag.</summary>
public partial struct FSmartObjectSlotLinkAnnotation {
// SmartObjectSlotLinkAnnotation
	public FGameplayTag Tag;
	public FSmartObjectSlotReference LinkedSlot;
}
