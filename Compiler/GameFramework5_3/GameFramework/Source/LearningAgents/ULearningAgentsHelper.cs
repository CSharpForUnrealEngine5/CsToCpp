namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for all helpers. Helpers are additional objects that can be used in getting or setting observations,</summary>
[CppInclude("LearningAgentsHelpers.h")]
public partial class ULearningAgentsHelper : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the Manager Component this helper is associated with.</summary>
	public ULearningAgentsManagerComponent ManagerComponent;
}
