namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extended attributes that the curve editor understands</summary>
[CppInclude("CurveDataAbstraction.h")]
public partial struct FKeyAttributes {
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
