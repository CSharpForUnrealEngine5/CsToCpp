namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNode_RemapCurvesBase.h")]
public partial struct FAnimNode_RemapCurvesBase {
	public FPoseLink SourcePose;
	public ERemapCurvesExpressionSource ExpressionSource;
	public FCurveExpressionList ExpressionList;
	public UCurveExpressionsDataAsset CurveExpressionsDataAsset;
	public TMap<FName,string> CurveExpressions;
	public bool bExpressionsImmutable;
	public TArray<FName> CachedConstantNames;
}
