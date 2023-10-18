namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Annotation to check if a smart object user can stand on the slot without overlaps.</summary>
[CppInclude("Annotations/SmartObjectAnnotation_SlotUserCollision.h")]
public partial struct FSmartObjectAnnotation_SlotUserCollision {
	public bool bUseUserCapsuleSize;
	public FSmartObjectUserCapsuleParams Capsule;
}
