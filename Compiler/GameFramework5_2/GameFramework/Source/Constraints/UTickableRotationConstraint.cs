#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTickableRotationConstraint</summary>
[CppInclude("TransformConstraint.h")]
public partial class UTickableRotationConstraint : UTickableTransformConstraint {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the local child&#39;s rotation offset in the parent space.</summary>
	public FQuat OffsetRotation;
	///<summary>Defines which rotation axis is constrained.</summary>
	public FFilterOptionPerAxis AxisFilter;
}
