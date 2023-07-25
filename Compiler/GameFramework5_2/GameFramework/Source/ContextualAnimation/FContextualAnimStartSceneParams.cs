#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimStartSceneParams {
// ContextualAnimStartSceneParams
	public TMap<string,FContextualAnimSceneBindingContext> RoleToActorMap;
	public int SectionIdx;
	public int AnimSetIdx;
}
