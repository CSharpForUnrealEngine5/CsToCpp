namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper for getting various properties from a MeshComponent.</summary>
[CppInclude("LearningAgentsHelpers.h")]
public partial class UMeshComponentHelper : ULearningAgentsHelper {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new mesh component helper to the given manager component.</summary>
	public static UMeshComponentHelper AddMeshComponentHelper(ULearningAgentsManagerComponent InManagerComponent,FName Name/*=NAME_None*/) { return default; }
	///<summary>Gets the bone positions for a set of bones of the mesh component in world space.</summary>
	public void GetMeshBonePositions(TArray<FVector> OutBonePositions,int AgentId,UMeshComponent MeshComponent,TArray<FName> BoneNames) {}
}
