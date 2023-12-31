namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTickableConstraint</summary>
[CppInclude("ConstraintsManager.h")]
public partial class UTickableConstraint : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Tick function that will be registered and evaluated.</summary>
	public FConstraintTickFunction ConstraintTick;
	///<summary>@todo documentation.</summary>
	public bool Active;
}
