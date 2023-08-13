namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Movement/MassMovementTrait.h")]
public partial class UMassMovementTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>Movement</summary>
	public FMassMovementParameters Movement;
}
