namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A control unit used to drive a transform from an external source</summary>
[CppInclude("Units/Control/RigUnit_Control.h")]
public partial struct FRigUnit_Control {
	public FEulerTransform Transform;
	public FTransform Base;
	public FTransform InitTransform;
	public FTransform Result;
	public FTransformFilter Filter;
	public bool bIsInitialized;
}
