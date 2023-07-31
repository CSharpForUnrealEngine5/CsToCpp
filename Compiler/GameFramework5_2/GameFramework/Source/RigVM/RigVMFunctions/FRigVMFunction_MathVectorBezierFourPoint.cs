#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the 4 point bezier interpolation</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathVector.h")]
public partial struct FRigVMFunction_MathVectorBezierFourPoint {
	public FRigVMFourPointBezier Bezier;
	public float T;
	public FVector Result;
	public FVector Tangent;
}
