namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Trait to allow an entity to interact with SmartObjects</summary>
[CppInclude("MassSmartObjectUserTrait.h")]
public partial class UMassSmartObjectUserTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>Tags describing the SmartObject user. Used when searching smart objects.</summary>
	public FGameplayTagContainer UserTags;
}
