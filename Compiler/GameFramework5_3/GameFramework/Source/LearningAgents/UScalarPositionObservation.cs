namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of a position along a single axis. Can be useful for providing information like object heights.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UScalarPositionObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new scalar position observation to the given agent interactor. Call during</summary>
	public static UScalarPositionObservation AddScalarPositionObservation(ULearningAgentsInteractor InInteractor,FName Name/*=NAME_None*/,float Scale/*=100.0f*/) { return default; }
	///<summary>Sets the data for this observation. The relative position can be used to make this observation</summary>
	public void SetScalarPositionObservation(int AgentId,float Position,float RelativePosition/*=0.0f*/) {}
	///<summary>Sets the data for this observation. The relative position can be used to make this observation</summary>
	public void SetScalarPositionObservationWithAxis(int AgentId,FVector Position,FVector RelativePosition/*=FVector.ZeroVector*/,FVector Axis/*=FVector.UpVector*/) {}
}
