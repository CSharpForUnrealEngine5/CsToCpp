#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTickableTransformConstraint</summary>
[CppInclude("TransformConstraint.h")]
public partial class UTickableTransformConstraint : UTickableConstraint {
	///<summary>The transformable handle representing the parent of that constraint.</summary>
	public UTransformableHandle ParentTRSHandle;
	///<summary>The transformable handle representing the child of that constraint.</summary>
	public UTransformableHandle ChildTRSHandle;
	///<summary>Should that constraint maintain the default offset.</summary>
	public bool bMaintainOffset;
	///<summary>Defines how much the constraint will be applied. // UPROPERTY(EditAnywhere, BlueprintReadWrite,Category=&quot;Weight&quot;, meta = (Input, ClampMin = &quot;0.0&quot;, ClampMax = &quot;1.0&quot;, UIMin = &quot;0.0&quot;, UIMax = &quot;1.0&quot;))</summary>
	public float Weight;
	///<summary>Should the child be able to change it&#39;s offset dynamically.</summary>
	public bool bDynamicOffset;
	///<summary>Defines the constraint&#39;s type (Position, Parent, Aim...).</summary>
	public ETransformConstraintType Type;
}
