#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CurveDataAbstraction.h")]
///<summary>Extended attributes that the curve editor understands</summary>
public partial struct FKeyAttributes {
// KeyAttributes
	public bool bHasArriveTangent;
	public bool bHasLeaveTangent;
	public bool bHasInterpMode;
	public bool bHasTangentMode;
	public bool bHasTangentWeightMode;
	public bool bHasArriveTangentWeight;
	public bool bHasLeaveTangentWeight;
	public float ArriveTangent;
	public float LeaveTangent;
	public ERichCurveInterpMode InterpMode;
	public ERichCurveTangentMode TangentMode;
	public ERichCurveTangentWeightMode TangentWeightMode;
	public float ArriveTangentWeight;
	public float LeaveTangentWeight;
}
