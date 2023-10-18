namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes one specific point on an interpolation curve.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurvePointVector2D {
	public float InVal;
	public FVector2D OutVal;
	public FVector2D ArriveTangent;
	public FVector2D LeaveTangent;
	public EInterpCurveMode InterpMode;
}
