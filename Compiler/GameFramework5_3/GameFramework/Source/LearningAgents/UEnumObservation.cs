namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An observation of an enumeration.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class UEnumObservation : ULearningAgentsObservation {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new enum observation to the given agent interactor. Call during ULearningAgentsInteractor::SetupObservations event.</summary>
	public static UEnumObservation AddEnumObservation(ULearningAgentsInteractor InInteractor,UEnum EnumType,FName Name/*=NAME_None*/) { return default; }
	///<summary>Sets the data for this observation. Call during ULearningAgentsInteractor::SetObservations event.</summary>
	public void SetEnumObservation(int AgentId,byte Value) {}
}
