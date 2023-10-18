namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct contains only the key data, this is only used to pass animation data from translators to factories</summary>
[CppInclude("InterchangeCommonAnimationPayload.h")]
public partial struct FInterchangeCurveKey {
	public EInterchangeCurveInterpMode InterpMode;
	public EInterchangeCurveTangentMode TangentMode;
	public EInterchangeCurveTangentWeightMode TangentWeightMode;
	public float Time;
	public float Value;
	public float ArriveTangent;
	public float ArriveTangentWeight;
	public float LeaveTangent;
	public float LeaveTangentWeight;
}
