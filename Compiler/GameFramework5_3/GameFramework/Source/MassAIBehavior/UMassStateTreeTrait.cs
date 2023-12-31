namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Feature that adds StateTree execution functionality to a mass agent.</summary>
[CppInclude("MassStateTreeTrait.h")]
public partial class UMassStateTreeTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>StateTree</summary>
	public UStateTree StateTree;
}
