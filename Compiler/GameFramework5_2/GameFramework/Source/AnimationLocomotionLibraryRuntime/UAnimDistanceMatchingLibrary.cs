namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of techniques for driving animations by distance metrics rather than by time.</summary>
[CppInclude("AnimDistanceMatchingLibrary.h")]
public partial class UAnimDistanceMatchingLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Advance the sequence evaluator forward by distance traveled rather than time. A distance curve is required on the animation that</summary>
	public static FSequenceEvaluatorReference AdvanceTimeByDistanceMatching(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,float DistanceTraveled,string DistanceCurveName,FVector2D PlayRateClamp/*=new FVector2D(0.75f,1.25f)*/) { return default; }
	///<summary>Set the time of the sequence evaluator to the point in the animation where the distance curve matches the DistanceToTarget input.</summary>
	public static FSequenceEvaluatorReference DistanceMatchToTarget(FSequenceEvaluatorReference SequenceEvaluator,float DistanceToTarget,string DistanceCurveName) { return default; }
	///<summary>Set the play rate of the sequence player so that the speed of the animation matches in-game movement speed.</summary>
	public static FSequencePlayerReference SetPlayrateToMatchSpeed(FSequencePlayerReference SequencePlayer,float SpeedToMatch,FVector2D PlayRateClamp/*=new FVector2D(0.75f,1.25f)*/) { return default; }
}
