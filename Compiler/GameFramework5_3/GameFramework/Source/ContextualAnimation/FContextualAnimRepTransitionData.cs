namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to transition events</summary>
[CppInclude("ContextualAnimSceneActorComponent.h")]
public partial struct FContextualAnimRepTransitionData {
	public byte Id;
	public byte SectionIdx;
	public byte AnimSetIdx;
	public TArray<FContextualAnimWarpTarget> ExternalWarpTargets;
}
