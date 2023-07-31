#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Named container with one or more ContextualAnimSet</summary>
[CppInclude("ContextualAnimSceneAsset.h")]
public partial struct FContextualAnimSceneSection {
	public string Name;
	public TArray<FContextualAnimSet> AnimSets;
	public TMap<string,FContextualAnimIKTargetDefContainer> RoleToIKTargetDefsMap;
	public TArray<FContextualAnimSetPivotDefinition> AnimSetPivotDefinitions;
}
