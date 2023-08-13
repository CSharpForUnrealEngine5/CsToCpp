namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimStartSceneParams {
	public TMap<string,FContextualAnimSceneBindingContext> RoleToActorMap;
	public int SectionIdx;
	public int AnimSetIdx;
}
