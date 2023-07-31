#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Deprecated/RigUnit_ApplyFK.h")]
public partial struct FRigUnit_ApplyFK {
	public string Joint;
	public FTransform Transform;
	public FTransformFilter Filter;
	public EApplyTransformMode ApplyTransformMode;
	public ETransformSpaceMode ApplyTransformSpace;
	public FTransform BaseTransform;
	public string BaseJoint;
}
