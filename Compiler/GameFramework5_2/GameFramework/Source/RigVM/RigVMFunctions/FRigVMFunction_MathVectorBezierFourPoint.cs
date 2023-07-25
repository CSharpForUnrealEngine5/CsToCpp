#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
///<summary>Returns the 4 point bezier interpolation</summary>
public partial struct FRigVMFunction_MathVectorBezierFourPoint {
// RigVMFunction_MathVectorBezierFourPoint
	public FRigVMFourPointBezier Bezier;
	public float T;
	public FVector Result;
	public FVector Tangent;
}
