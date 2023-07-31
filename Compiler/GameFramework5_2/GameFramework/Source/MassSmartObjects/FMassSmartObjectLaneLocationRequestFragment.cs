#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fragment used to build a list potential smart objects to use. Once added to an entity</summary>
[CppInclude("MassSmartObjectRequest.h")]
public partial struct FMassSmartObjectLaneLocationRequestFragment {
	public FMassEntityHandle RequestingEntity;
	public FGameplayTagContainer UserTags;
	public FGameplayTagQuery ActivityRequirements;
}
