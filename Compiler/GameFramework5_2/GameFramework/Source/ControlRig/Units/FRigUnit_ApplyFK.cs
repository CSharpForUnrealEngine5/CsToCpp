namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Deprecated/RigUnit_ApplyFK.h")]
public partial struct FRigUnit_ApplyFK {
	public FName Joint;
	public FTransform Transform;
	public FTransformFilter Filter;
	public EApplyTransformMode ApplyTransformMode;
	public ETransformSpaceMode ApplyTransformSpace;
	public FTransform BaseTransform;
	public FName BaseJoint;
}
