#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTickableLookAtConstraint</summary>
[CppInclude("TransformConstraint.h")]
public partial class UTickableLookAtConstraint : UTickableTransformConstraint {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the aiming axis.</summary>
	public FVector Axis;
}
