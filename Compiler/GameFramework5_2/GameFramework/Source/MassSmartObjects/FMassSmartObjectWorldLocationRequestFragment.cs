#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassSmartObjectRequest.h")]
///<summary>Fragment used to build a list potential smart objects to use. Once added to an entity</summary>
public partial struct FMassSmartObjectWorldLocationRequestFragment {
// MassSmartObjectWorldLocationRequestFragment
	public FVector SearchOrigin;
	public FMassEntityHandle RequestingEntity;
	public FGameplayTagContainer UserTags;
	public FGameplayTagQuery ActivityRequirements;
}
