namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes one specific point on an interpolation curve.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurvePointFloat {
	public float InVal;
	public float OutVal;
	public float ArriveTangent;
	public float LeaveTangent;
	public EInterpCurveMode InterpMode;
}
