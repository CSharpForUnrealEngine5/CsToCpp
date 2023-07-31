#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ns UE</summary>
[CppInclude("InterchangeMeshNode.h")]
public partial class UInterchangeMeshNode : UInterchangeBaseNode {
	///<summary>Return true if this node represent a skinned mesh</summary>
	public  bool IsSkinnedMesh() { return default; }
	///<summary>Set the IsSkinnedMesh attribute to determine if this node represent a skinned mesh.</summary>
	public  bool SetSkinnedMesh(bool bIsSkinnedMesh) { return default; }
	///<summary>Return true if this node represent a morph target</summary>
	public  bool IsMorphTarget() { return default; }
	///<summary>Set the IsMorphTarget attribute to determine if this node represent a morph target.</summary>
	public  bool SetMorphTarget(bool bIsMorphTarget) { return default; }
	///<summary>Get the morph target name.</summary>
	public  bool GetMorphTargetName(string OutMorphTargetName) { return default; }
	///<summary>Set the MorphTargetName attribute to determine if this node represent a morph target.</summary>
	public  bool SetMorphTargetName(string MorphTargetName) { return default; }
	///<summary>SetPayLoadKey</summary>
	public  void SetPayLoadKey(string PayloadKey) {}
	///<summary>SetAnimationCurvePayLoadKey</summary>
	public  void SetAnimationCurvePayLoadKey(string PayloadKey) {}
	///<summary>Query this mesh vertices count. Return false if the attribute was not set.</summary>
	public  bool GetCustomVertexCount(int AttributeValue) { return default; }
	///<summary>Set this mesh vertices count. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomVertexCount(int AttributeValue) { return default; }
	///<summary>Query this mesh polygon count. Return false if the attribute was not set.</summary>
	public  bool GetCustomPolygonCount(int AttributeValue) { return default; }
	///<summary>Set this mesh polygon count. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomPolygonCount(int AttributeValue) { return default; }
	///<summary>Query this mesh bounding box. Return false if the attribute was not set.</summary>
	public  bool GetCustomBoundingBox(FBox AttributeValue) { return default; }
	///<summary>Set this mesh bounding box. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomBoundingBox(FBox AttributeValue) { return default; }
	///<summary>Query if this mesh has vertex normal. Return false if the attribute was not set.</summary>
	public  bool GetCustomHasVertexNormal(bool AttributeValue) { return default; }
	///<summary>Set this mesh has vertex normal attribute. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomHasVertexNormal(bool AttributeValue) { return default; }
	///<summary>Query if this mesh has vertex bi-normal. Return false if the attribute was not set.</summary>
	public  bool GetCustomHasVertexBinormal(bool AttributeValue) { return default; }
	///<summary>Set this mesh has vertex bi-normal attribute. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomHasVertexBinormal(bool AttributeValue) { return default; }
	///<summary>Query if this mesh has vertex tangent. Return false if the attribute was not set.</summary>
	public  bool GetCustomHasVertexTangent(bool AttributeValue) { return default; }
	///<summary>Set this mesh has vertex tangent attribute. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomHasVertexTangent(bool AttributeValue) { return default; }
	///<summary>Query if this mesh has smooth group. Return false if the attribute was not set.</summary>
	public  bool GetCustomHasSmoothGroup(bool AttributeValue) { return default; }
	///<summary>Set this mesh has smooth group attribute. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomHasSmoothGroup(bool AttributeValue) { return default; }
	///<summary>Query if this mesh has vertex color. Return false if the attribute was not set.</summary>
	public  bool GetCustomHasVertexColor(bool AttributeValue) { return default; }
	///<summary>Set this mesh has vertex color attribute. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomHasVertexColor(bool AttributeValue) { return default; }
	///<summary>Query this mesh UV count. Return false if the attribute was not set.</summary>
	public  bool GetCustomUVCount(int AttributeValue) { return default; }
	///<summary>Set this mesh UV count attribute. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomUVCount(int AttributeValue) { return default; }
	///<summary>This function allow to retrieve the number of skeleton dependencies for this object.</summary>
	public  int GetSkeletonDependeciesCount() { return default; }
	///<summary>This function allow to retrieve the skeleton dependency for this object.</summary>
	public  void GetSkeletonDependencies(TArray<string> OutDependencies) {}
	///<summary>This function allow to retrieve one skeleton dependency for this object.</summary>
	public  void GetSkeletonDependency(int Index,string OutDependency) {}
	///<summary>Add one skeleton dependency to this object.</summary>
	public  bool SetSkeletonDependencyUid(string DependencyUid) { return default; }
	///<summary>Remove one skeleton dependency from this object.</summary>
	public  bool RemoveSkeletonDependencyUid(string DependencyUid) { return default; }
	///<summary>This function allow to retrieve the number of morph target dependencies for this object.</summary>
	public  int GetMorphTargetDependeciesCount() { return default; }
	///<summary>This function allow to retrieve the morph target dependency for this object.</summary>
	public  void GetMorphTargetDependencies(TArray<string> OutDependencies) {}
	///<summary>This function allow to retrieve one morph target dependency for this object.</summary>
	public  void GetMorphTargetDependency(int Index,string OutDependency) {}
	///<summary>Add one morph target dependency to this object.</summary>
	public  bool SetMorphTargetDependencyUid(string DependencyUid) { return default; }
	///<summary>Remove one morph target dependency from this object.</summary>
	public  bool RemoveMorphTargetDependencyUid(string DependencyUid) { return default; }
	///<summary>This function allow to retrieve the number of scene node instancing this mesh.</summary>
	public  int GetSceneInstanceUidsCount() { return default; }
	///<summary>This function allow to retrieve the asset instances this scene node is refering.</summary>
	public  void GetSceneInstanceUids(TArray<string> OutDependencies) {}
	///<summary>This function allow to retrieve an asset instance this scene node is refering.</summary>
	public  void GetSceneInstanceUid(int Index,string OutDependency) {}
	///<summary>Add one asset instance this scene node is refering.</summary>
	public  bool SetSceneInstanceUid(string DependencyUid) { return default; }
	///<summary>Remove one asset instance this scene node is refering.</summary>
	public  bool RemoveSceneInstanceUid(string DependencyUid) { return default; }
	///<summary>Allow to retrieve the correspondence table between slot names and assigned materials for this object.</summary>
	public  void GetSlotMaterialDependencies(TMap<string,string> OutMaterialDependencies) {}
	///<summary>Allow to retrieve one Material dependency for a given slot of this object.</summary>
	public  bool GetSlotMaterialDependencyUid(string SlotName,string OutMaterialDependency) { return default; }
	///<summary>Add one Material dependency to a specific slot name of this object.</summary>
	public  bool SetSlotMaterialDependencyUid(string SlotName,string MaterialDependencyUid) { return default; }
	///<summary>Remove the Material dependency associated with the given slot name from this object.</summary>
	public  bool RemoveSlotMaterialDependencyUid(string SlotName) { return default; }
}
