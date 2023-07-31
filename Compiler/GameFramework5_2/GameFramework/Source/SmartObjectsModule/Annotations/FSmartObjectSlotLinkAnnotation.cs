#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Annotation to allow to find slots based on a Gameplay Tag.</summary>
[CppInclude("Annotations/SmartObjectSlotLinkAnnotation.h")]
public partial struct FSmartObjectSlotLinkAnnotation {
	public FGameplayTag Tag;
	public FSmartObjectSlotReference LinkedSlot;
}
