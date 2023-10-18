namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for remote control behaviour.</summary>
[CppInclude("Behaviour/RCBehaviour.h")]
public partial class URCBehaviour : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Associated cpp behaviour</summary>
	public UClass BehaviourNodeClass;
	///<summary>Class path to associated blueprint class behaviour</summary>
	public FSoftClassPath OverrideBehaviourBlueprintClassPath;
	///<summary>Behaviour Id</summary>
	public FGuid Id;
	///<summary>Action container which is associated with current behaviour</summary>
	public URCActionContainer ActionContainer;
	///<summary>Reference to controller virtual property with this behaviour</summary>
	public TWeakObjectPtr<URCController> ControllerWeakPtr;
	///<summary>Cached behaviour node</summary>
	public URCBehaviourNode CachedBehaviourNode;
	///<summary>Whether this Behaviour is currently enabled.</summary>
	public bool bIsEnabled;
	///<summary>Indicates whether we want a behavour to trigger during live scrubbing of values.</summary>
	public bool bExecuteBehavioursDuringPreChange;
}
