namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for all observations. Observations define the inputs to your agents.</summary>
[CppInclude("LearningAgentsObservations.h")]
public partial class ULearningAgentsObservation : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the Interactor this observation is associated with.</summary>
	public ULearningAgentsInteractor Interactor;
}
