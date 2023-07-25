#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes one specific point on an interpolation curve.</summary>
public partial struct FInterpCurvePointTwoVectors {
// InterpCurvePointTwoVectors
	public float InVal;
	public FTwoVectors OutVal;
	public FTwoVectors ArriveTangent;
	public FTwoVectors LeaveTangent;
	public byte InterpMode;
}
