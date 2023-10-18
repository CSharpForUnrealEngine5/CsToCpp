namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Debug/RigUnit_DebugBezier.h")]
public partial struct FRigUnit_DebugBezier {
	public FRigVMFourPointBezier Bezier;
	public float MinimumU;
	public float MaximumU;
	public FLinearColor Color;
	public float Thickness;
	public int Detail;
	public FName Space;
	public FTransform WorldOffset;
	public bool bEnabled;
}
