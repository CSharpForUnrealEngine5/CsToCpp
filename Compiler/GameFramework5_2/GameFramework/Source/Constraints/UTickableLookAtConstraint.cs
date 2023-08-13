namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTickableLookAtConstraint</summary>
[CppInclude("TransformConstraint.h")]
public partial class UTickableLookAtConstraint : UTickableTransformConstraint {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the aiming axis.</summary>
	public FVector Axis;
}
