#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeMeshNode.h")]
///<summary>ns UE</summary>
public partial class UInterchangeMeshNode : UInterchangeBaseNode {
// InterchangeMeshNode
	public  bool IsSkinnedMesh() { return default; }
	public  bool SetSkinnedMesh(bool bIsSkinnedMesh) { return default; }
	public  bool IsMorphTarget() { return default; }
	public  bool SetMorphTarget(bool bIsMorphTarget) { return default; }
	public  bool GetMorphTargetName(string OutMorphTargetName) { return default; }
	public  bool SetMorphTargetName(string MorphTargetName) { return default; }
	public  void SetPayLoadKey(string PayloadKey) {}
	public  void SetAnimationCurvePayLoadKey(string PayloadKey) {}
	public  bool GetCustomVertexCount(int AttributeValue) { return default; }
	public  bool SetCustomVertexCount(int AttributeValue) { return default; }
	public  bool GetCustomPolygonCount(int AttributeValue) { return default; }
	public  bool SetCustomPolygonCount(int AttributeValue) { return default; }
	public  bool GetCustomBoundingBox(FBox AttributeValue) { return default; }
	public  bool SetCustomBoundingBox(FBox AttributeValue) { return default; }
	public  bool GetCustomHasVertexNormal(bool AttributeValue) { return default; }
	public  bool SetCustomHasVertexNormal(bool AttributeValue) { return default; }
	public  bool GetCustomHasVertexBinormal(bool AttributeValue) { return default; }
	public  bool SetCustomHasVertexBinormal(bool AttributeValue) { return default; }
	public  bool GetCustomHasVertexTangent(bool AttributeValue) { return default; }
	public  bool SetCustomHasVertexTangent(bool AttributeValue) { return default; }
	public  bool GetCustomHasSmoothGroup(bool AttributeValue) { return default; }
	public  bool SetCustomHasSmoothGroup(bool AttributeValue) { return default; }
	public  bool GetCustomHasVertexColor(bool AttributeValue) { return default; }
	public  bool SetCustomHasVertexColor(bool AttributeValue) { return default; }
	public  bool GetCustomUVCount(int AttributeValue) { return default; }
	public  bool SetCustomUVCount(int AttributeValue) { return default; }
	public  int GetSkeletonDependeciesCount() { return default; }
	public  void GetSkeletonDependencies(TArray<string> OutDependencies) {}
	public  void GetSkeletonDependency(int Index,string OutDependency) {}
	public  bool SetSkeletonDependencyUid(string DependencyUid) { return default; }
	public  bool RemoveSkeletonDependencyUid(string DependencyUid) { return default; }
	public  int GetMorphTargetDependeciesCount() { return default; }
	public  void GetMorphTargetDependencies(TArray<string> OutDependencies) {}
	public  void GetMorphTargetDependency(int Index,string OutDependency) {}
	public  bool SetMorphTargetDependencyUid(string DependencyUid) { return default; }
	public  bool RemoveMorphTargetDependencyUid(string DependencyUid) { return default; }
	public  int GetSceneInstanceUidsCount() { return default; }
	public  void GetSceneInstanceUids(TArray<string> OutDependencies) {}
	public  void GetSceneInstanceUid(int Index,string OutDependency) {}
	public  bool SetSceneInstanceUid(string DependencyUid) { return default; }
	public  bool RemoveSceneInstanceUid(string DependencyUid) { return default; }
	public  void GetSlotMaterialDependencies(TMap<string,string> OutMaterialDependencies) {}
	public  bool GetSlotMaterialDependencyUid(string SlotName,string OutMaterialDependency) { return default; }
	public  bool SetSlotMaterialDependencyUid(string SlotName,string MaterialDependencyUid) { return default; }
	public  bool RemoveSlotMaterialDependencyUid(string SlotName) { return default; }
}
