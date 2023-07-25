#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimDistanceMatchingLibrary.h")]
///<summary>Library of techniques for driving animations by distance metrics rather than by time.</summary>
public partial class UAnimDistanceMatchingLibrary : UBlueprintFunctionLibrary {
// AnimDistanceMatchingLibrary
	public FSequenceEvaluatorReference AdvanceTimeByDistanceMatching(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,float DistanceTraveled,string DistanceCurveName,FVector2D PlayRateClamp/*=new FVector2D(0.75f,1.25f)*/) { return default; }
	public FSequenceEvaluatorReference DistanceMatchToTarget(FSequenceEvaluatorReference SequenceEvaluator,float DistanceToTarget,string DistanceCurveName) { return default; }
	public FSequencePlayerReference SetPlayrateToMatchSpeed(FSequencePlayerReference SequencePlayer,float SpeedToMatch,FVector2D PlayRateClamp/*=new FVector2D(0.75f,1.25f)*/) { return default; }
}
