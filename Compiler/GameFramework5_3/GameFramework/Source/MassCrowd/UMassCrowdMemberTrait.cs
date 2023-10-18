namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Trait to mark an entity with the crowd tag and add required fragments to track current lane</summary>
[CppInclude("MassCrowdMemberTrait.h")]
public partial class UMassCrowdMemberTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
}
