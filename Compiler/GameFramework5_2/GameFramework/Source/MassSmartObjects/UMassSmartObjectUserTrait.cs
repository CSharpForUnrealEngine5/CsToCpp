#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Trait to allow an entity to interact with SmartObjects</summary>
[CppInclude("MassSmartObjectUserTrait.h")]
public partial class UMassSmartObjectUserTrait : UMassEntityTraitBase {
	///<summary>Tags describing the SmartObject user. Used when searching smart objects.</summary>
	public FGameplayTagContainer UserTags;
}
