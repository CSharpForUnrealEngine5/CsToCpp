namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an array of enumerations.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UEnumArrayObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new enum array observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UEnumArrayObservation AddEnumArrayObservation(ULearningAgentsInteractor InInteractor,UEnum EnumType,FName Name/*=NAME_None*/,int EnumNum/*=1*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetEnumArrayObservation(int AgentId,TArray<byte> Values) {}
}
