#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeCommonAnimationPayload.h")]
///<summary>This struct contains only the key data, this is only used to pass animation data from translators to factories</summary>
public partial struct FInterchangeCurveKey {
// InterchangeCurveKey
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
