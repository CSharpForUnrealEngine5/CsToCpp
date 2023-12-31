namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the 4 point bezier interpolation</summary>
[CppInclude("Units/Deprecated/Math/RigUnit_Vector.h")]
public partial struct FRigUnit_MathVectorBezierFourPoint {
	public FRigVMFourPointBezier Bezier;
	public float T;
	public FVector Result;
	public FVector Tangent;
}
