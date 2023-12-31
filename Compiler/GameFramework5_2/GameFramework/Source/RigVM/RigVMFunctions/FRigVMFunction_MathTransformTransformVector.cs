namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Multiplies a given vector (location) by the transform</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformTransformVector {
	public FTransform Transform;
	public FVector Location;
	public FVector Result;
}
