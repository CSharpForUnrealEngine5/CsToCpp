#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes one specific point on an interpolation curve.</summary>
public partial struct FInterpCurvePointVector {
// InterpCurvePointVector
	public float InVal;
	public FVector OutVal;
	public FVector ArriveTangent;
	public FVector LeaveTangent;
	public EInterpCurveMode InterpMode;
}
