#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Easy way to modify curve values on a pose</summary>
[CppInclude("AnimNodes/AnimNode_ModifyCurve.h")]
public partial struct FAnimNode_ModifyCurve {
	public FPoseLink SourcePose;
	public TMap<string,float> CurveMap;
	public TArray<float> CurveValues;
	public TArray<string> CurveNames;
	public float Alpha;
	public EModifyCurveApplyMode ApplyMode;
}
