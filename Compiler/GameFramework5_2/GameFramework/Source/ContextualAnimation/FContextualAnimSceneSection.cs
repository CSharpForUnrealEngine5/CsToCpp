namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Named container with one or more ContextualAnimSet</summary>
[CppInclude("ContextualAnimSceneAsset.h")]
public partial struct FContextualAnimSceneSection {
	public FName Name;
	public TArray<FContextualAnimSet> AnimSets;
	public TMap<FName,FContextualAnimIKTargetDefContainer> RoleToIKTargetDefsMap;
	public TArray<FContextualAnimSetPivotDefinition> AnimSetPivotDefinitions;
}
