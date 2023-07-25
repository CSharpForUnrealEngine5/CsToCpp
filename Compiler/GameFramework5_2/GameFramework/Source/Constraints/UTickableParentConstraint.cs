#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TransformConstraint.h")]
///<summary>UTickableParentConstraint</summary>
public partial class UTickableParentConstraint : UTickableTransformConstraint {
// TickableParentConstraint
	public FTransform OffsetTransform;
	public bool bScaling;
	public FTransformFilter TransformFilter;
}
