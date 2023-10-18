namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to replicate start/stop contextual anim events</summary>
[CppInclude("ContextualAnimSceneActorComponent.h")]
public partial struct FContextualAnimRepBindingsData {
	public FContextualAnimSceneBindings Bindings;
	public TArray<FContextualAnimWarpTarget> ExternalWarpTargets;
}
