#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Deprecated/RigUnit_ApplyFK.h")]
public partial struct FRigUnit_ApplyFK {
// RigUnit_ApplyFK
	public string Joint;
	public FTransform Transform;
	public FTransformFilter Filter;
	public EApplyTransformMode ApplyTransformMode;
	public ETransformSpaceMode ApplyTransformSpace;
	public FTransform BaseTransform;
	public string BaseJoint;
}
