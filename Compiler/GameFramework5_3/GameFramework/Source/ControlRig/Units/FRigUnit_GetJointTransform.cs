namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Deprecated/RigUnit_GetJointTransform.h")]
public partial struct FRigUnit_GetJointTransform {
	public FName Joint;
	public ETransformGetterType Type;
	public ETransformSpaceMode TransformSpace;
	public FTransform BaseTransform;
	public FName BaseJoint;
	public FTransform Output;
}
