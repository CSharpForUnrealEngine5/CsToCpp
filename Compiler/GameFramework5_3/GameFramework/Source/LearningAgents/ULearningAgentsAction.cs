namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for all actions. Actions define the outputs from your agents. Action getters are marked non-pure by</summary>
[CppInclude("LearningAgentsActions.h")]
public partial class ULearningAgentsAction : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the Interactor this action is associated with.</summary>
	public ULearningAgentsInteractor Interactor;
}
