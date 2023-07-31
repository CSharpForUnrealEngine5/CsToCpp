#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTickableScaleConstraint</summary>
[CppInclude("TransformConstraint.h")]
public partial class UTickableScaleConstraint : UTickableTransformConstraint {
	///<summary>Defines the local child&#39;s scale offset in the parent space.</summary>
	public FVector OffsetScale;
	///<summary>Defines which scale axis is constrained.</summary>
	public FFilterOptionPerAxis AxisFilter;
}
