namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes one specific point on an interpolation curve.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurvePointTwoVectors {
	public float InVal;
	public FTwoVectors OutVal;
	public FTwoVectors ArriveTangent;
	public FTwoVectors LeaveTangent;
	public EInterpCurveMode InterpMode;
}
