namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to replicate a late join event</summary>
[CppInclude("ContextualAnimSceneActorComponent.h")]
public partial struct FContextualAnimRepLateJoinData {
	public AActor Actor;
	public FName Role;
	public TArray<FContextualAnimWarpTarget> ExternalWarpTargets;
}
