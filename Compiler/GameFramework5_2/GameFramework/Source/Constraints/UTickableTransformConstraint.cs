#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TransformConstraint.h")]
///<summary>UTickableTransformConstraint</summary>
public partial class UTickableTransformConstraint : UTickableConstraint {
// TickableTransformConstraint
	public UTransformableHandle ParentTRSHandle;
	public UTransformableHandle ChildTRSHandle;
	public bool bMaintainOffset;
	public float Weight;
	public bool bDynamicOffset;
	public ETransformConstraintType Type;
}
