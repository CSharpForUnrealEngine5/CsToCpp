namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fragment used to build a list potential smart objects to use. Once added to an entity</summary>
[CppInclude("MassSmartObjectRequest.h")]
public partial struct FMassSmartObjectWorldLocationRequestFragment {
	public FVector SearchOrigin;
	public FMassEntityHandle RequestingEntity;
	public FGameplayTagContainer UserTags;
	public FGameplayTagQuery ActivityRequirements;
}
