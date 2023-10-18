namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Easy way to modify curve values on a pose</summary>
[CppInclude("AnimNodes/AnimNode_ModifyCurve.h")]
public partial struct FAnimNode_ModifyCurve {
	public FPoseLink SourcePose;
	public TMap<FName,float> CurveMap;
	public TArray<float> CurveValues;
	public TArray<FName> CurveNames;
	public float Alpha;
	public EModifyCurveApplyMode ApplyMode;
}
