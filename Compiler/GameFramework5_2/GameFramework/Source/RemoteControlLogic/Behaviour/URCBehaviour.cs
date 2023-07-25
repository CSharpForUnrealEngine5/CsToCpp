#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Behaviour/RCBehaviour.h")]
///<summary>Base class for remote control behaviour.</summary>
public partial class URCBehaviour : UObject {
// RCBehaviour
	public UClass BehaviourNodeClass;
	public FSoftClassPath OverrideBehaviourBlueprintClassPath;
	public FGuid Id;
	public URCActionContainer ActionContainer;
	public TWeakObjectPtr<URCController> ControllerWeakPtr;
	public URCBehaviourNode CachedBehaviourNode;
	public bool bIsEnabled;
	public bool bExecuteBehavioursDuringPreChange;
}
