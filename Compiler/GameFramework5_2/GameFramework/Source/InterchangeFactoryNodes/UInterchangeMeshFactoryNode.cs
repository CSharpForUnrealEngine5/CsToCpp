#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeMeshFactoryNode.h")]
///<summary>namespace Interchange</summary>
public partial class UInterchangeMeshFactoryNode : UInterchangeFactoryBaseNode {
// InterchangeMeshFactoryNode
	public int GetLodDataCount() { return default; }
	public void GetLodDataUniqueIds(TArray<string> OutLodDataUniqueIds) {}
	public bool AddLodDataUniqueId(string LodDataUniqueId) { return default; }
	public bool RemoveLodDataUniqueId(string LodDataUniqueId) { return default; }
	public bool GetCustomVertexColorReplace(bool AttributeValue) { return default; }
	public bool SetCustomVertexColorReplace(bool AttributeValue) { return default; }
	public bool GetCustomVertexColorIgnore(bool AttributeValue) { return default; }
	public bool SetCustomVertexColorIgnore(bool AttributeValue) { return default; }
	public bool GetCustomVertexColorOverride(FColor AttributeValue) { return default; }
	public bool SetCustomVertexColorOverride(FColor AttributeValue) { return default; }
	public void GetSlotMaterialDependencies(TMap<string,string> OutMaterialDependencies) {}
	public bool GetSlotMaterialDependencyUid(string SlotName,string OutMaterialDependency) { return default; }
	public bool SetSlotMaterialDependencyUid(string SlotName,string MaterialDependencyUid) { return default; }
	public bool RemoveSlotMaterialDependencyUid(string SlotName) { return default; }
	public bool GetCustomRecomputeNormals(bool AttributeValue) { return default; }
	public bool SetCustomRecomputeNormals(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public bool GetCustomRecomputeTangents(bool AttributeValue) { return default; }
	public bool SetCustomRecomputeTangents(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public bool GetCustomUseMikkTSpace(bool AttributeValue) { return default; }
	public bool SetCustomUseMikkTSpace(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public bool GetCustomComputeWeightedNormals(bool AttributeValue) { return default; }
	public bool SetCustomComputeWeightedNormals(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public bool GetCustomUseHighPrecisionTangentBasis(bool AttributeValue) { return default; }
	public bool SetCustomUseHighPrecisionTangentBasis(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public bool GetCustomUseFullPrecisionUVs(bool AttributeValue) { return default; }
	public bool SetCustomUseFullPrecisionUVs(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public bool GetCustomUseBackwardsCompatibleF16TruncUVs(bool AttributeValue) { return default; }
	public bool SetCustomUseBackwardsCompatibleF16TruncUVs(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public bool GetCustomRemoveDegenerates(bool AttributeValue) { return default; }
	public bool SetCustomRemoveDegenerates(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
}
