#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>namespace Interchange</summary>
[CppInclude("InterchangeMeshFactoryNode.h")]
public partial class UInterchangeMeshFactoryNode : UInterchangeFactoryBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Return The number of LOD this static mesh has.</summary>
	public  int GetLodDataCount() { return default; }
	///<summary>GetLodDataUniqueIds</summary>
	public  void GetLodDataUniqueIds(TArray<string> OutLodDataUniqueIds) {}
	///<summary>AddLodDataUniqueId</summary>
	public  bool AddLodDataUniqueId(string LodDataUniqueId) { return default; }
	///<summary>RemoveLodDataUniqueId</summary>
	public  bool RemoveLodDataUniqueId(string LodDataUniqueId) { return default; }
	///<summary>Query whether the static mesh factory should replace the vertex color. Return false if the attribute was not set.</summary>
	public  bool GetCustomVertexColorReplace(bool AttributeValue) { return default; }
	///<summary>Set whether the static mesh factory should replace the vertex color. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomVertexColorReplace(bool AttributeValue) { return default; }
	///<summary>Query whether the static mesh factory should ignore the vertex color. Return false if the attribute was not set.</summary>
	public  bool GetCustomVertexColorIgnore(bool AttributeValue) { return default; }
	///<summary>Set whether the static mesh factory should ignore the vertex color. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomVertexColorIgnore(bool AttributeValue) { return default; }
	///<summary>Query whether the static mesh factory should override the vertex color. Return false if the attribute was not set.</summary>
	public  bool GetCustomVertexColorOverride(FColor AttributeValue) { return default; }
	///<summary>Set whether the static mesh factory should override the vertex color. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomVertexColorOverride(FColor AttributeValue) { return default; }
	///<summary>Allow to retrieve the correspondence table between slot names and assigned materials for this object.</summary>
	public  void GetSlotMaterialDependencies(TMap<string,string> OutMaterialDependencies) {}
	///<summary>Allow to retrieve one Material dependency for a given slot of this object.</summary>
	public  bool GetSlotMaterialDependencyUid(string SlotName,string OutMaterialDependency) { return default; }
	///<summary>Add one Material dependency to a specific slot name of this object.</summary>
	public  bool SetSlotMaterialDependencyUid(string SlotName,string MaterialDependencyUid) { return default; }
	///<summary>Remove the Material dependency associated with the given slot name from this object.</summary>
	public  bool RemoveSlotMaterialDependencyUid(string SlotName) { return default; }
	///<summary>Query whether normals in the imported mesh are ignored and recomputed. When normals are recomputed the tangents are also recomputed.</summary>
	public  bool GetCustomRecomputeNormals(bool AttributeValue) { return default; }
	///<summary>Set whether normals in the imported mesh are ignored and recomputed. When normals are recomputed the tangents are also recomputed.</summary>
	public  bool SetCustomRecomputeNormals(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query whether tangents in the imported mesh are ignored and recomputed.</summary>
	public  bool GetCustomRecomputeTangents(bool AttributeValue) { return default; }
	///<summary>Set whether tangents in the imported mesh are ignored and recomputed.</summary>
	public  bool SetCustomRecomputeTangents(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query whether tangents recompute will use mikkt space if tangents are recomputed.</summary>
	public  bool GetCustomUseMikkTSpace(bool AttributeValue) { return default; }
	///<summary>Set whether tangents recompute will use mikkt space if tangents are recomputed.</summary>
	public  bool SetCustomUseMikkTSpace(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query whether normals recompute will use the surface area and the corner angle of the triangle as a ratio when computing the normals.</summary>
	public  bool GetCustomComputeWeightedNormals(bool AttributeValue) { return default; }
	///<summary>Set whether normals recompute will use the surface area and the corner angle of the triangle as a ratio when computing the normals.</summary>
	public  bool SetCustomComputeWeightedNormals(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query whether Tangents will be stored at 16 bit vs 8 bit precision.</summary>
	public  bool GetCustomUseHighPrecisionTangentBasis(bool AttributeValue) { return default; }
	///<summary>Set whether Tangents will be stored at 16 bit vs 8 bit precision.</summary>
	public  bool SetCustomUseHighPrecisionTangentBasis(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query whether UVs will be stored at full floating point precision.</summary>
	public  bool GetCustomUseFullPrecisionUVs(bool AttributeValue) { return default; }
	///<summary>Set whether UVs will be stored at full floating point precision.</summary>
	public  bool SetCustomUseFullPrecisionUVs(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query whether UVs will be stored at full floating point precision.</summary>
	public  bool GetCustomUseBackwardsCompatibleF16TruncUVs(bool AttributeValue) { return default; }
	///<summary>Set whether UVs will be stored at full floating point precision.</summary>
	public  bool SetCustomUseBackwardsCompatibleF16TruncUVs(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query whether degenerate triangles will be removed.</summary>
	public  bool GetCustomRemoveDegenerates(bool AttributeValue) { return default; }
	///<summary>Set whether degenerate triangles will be removed.</summary>
	public  bool SetCustomRemoveDegenerates(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
}
