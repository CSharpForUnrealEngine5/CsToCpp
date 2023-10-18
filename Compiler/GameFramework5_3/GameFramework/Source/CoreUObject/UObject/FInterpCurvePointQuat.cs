namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes one specific point on an interpolation curve.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurvePointQuat {
	public float InVal;
	public FQuat OutVal;
	public FQuat ArriveTangent;
	public FQuat LeaveTangent;
	public EInterpCurveMode InterpMode;
}
