#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTickableParentConstraint</summary>
[CppInclude("TransformConstraint.h")]
public partial class UTickableParentConstraint : UTickableTransformConstraint {
	///<summary>Defines the local child&#39;s transform offset in the parent space.</summary>
	public FTransform OffsetTransform;
	///<summary>Defines whether we propagate the parent scale.</summary>
	public bool bScaling;
	///<summary>Defines which translation/rotation/scale axis are constrained.</summary>
	public FTransformFilter TransformFilter;
}
