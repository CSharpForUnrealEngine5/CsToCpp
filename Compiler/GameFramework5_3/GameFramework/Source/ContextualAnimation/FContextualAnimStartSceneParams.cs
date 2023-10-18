namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DEPRECATED: Kept around only to do not break existing content. It will go away in the future.</summary>
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimStartSceneParams {
	public TMap<FName,FContextualAnimSceneBindingContext> RoleToActorMap;
	public int SectionIdx;
	public int AnimSetIdx;
}
