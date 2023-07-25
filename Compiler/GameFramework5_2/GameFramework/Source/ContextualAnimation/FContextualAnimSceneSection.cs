#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneAsset.h")]
///<summary>Named container with one or more ContextualAnimSet</summary>
public partial struct FContextualAnimSceneSection {
// ContextualAnimSceneSection
	public string Name;
	public TArray<FContextualAnimSet> AnimSets;
	public TMap<string,FContextualAnimIKTargetDefContainer> RoleToIKTargetDefsMap;
	public TArray<FContextualAnimSetPivotDefinition> AnimSetPivotDefinitions;
}
