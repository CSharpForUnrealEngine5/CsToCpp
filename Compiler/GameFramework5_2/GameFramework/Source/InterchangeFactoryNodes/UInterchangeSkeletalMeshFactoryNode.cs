#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeSkeletalMeshFactoryNode.h")]
public partial class UInterchangeSkeletalMeshFactoryNode : UInterchangeMeshFactoryNode {
	///<summary>Initialize node data</summary>
	public  void InitializeSkeletalMeshNode(string UniqueID,string DisplayLabel,string InAssetClass) {}
	///<summary>Get the class this node want to create</summary>
	public  UClass GetObjectClass() { return default; }
	///<summary>Query the skeletal mesh factory skeleton UObject. Return false if the attribute was not set.</summary>
	public  bool GetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue) { return default; }
	///<summary>Set the skeletal mesh factory skeleton UObject. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue) { return default; }
	///<summary>Query weather the skeletal mesh factory should create the morph target. Return false if the attribute was not set.</summary>
	public  bool GetCustomImportMorphTarget(bool AttributeValue) { return default; }
	///<summary>Set weather the skeletal mesh factory should create the morph target. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomImportMorphTarget(bool AttributeValue) { return default; }
	///<summary>Query weather the skeletal mesh factory should create a physics asset. Return false if the attribute was not set.</summary>
	public  bool GetCustomCreatePhysicsAsset(bool AttributeValue) { return default; }
	///<summary>Set weather the skeletal mesh factory should create a physics asset. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomCreatePhysicsAsset(bool AttributeValue) { return default; }
	///<summary>Query a physics asset the skeletal mesh factory should use. Return false if the attribute was not set.</summary>
	public  bool GetCustomPhysicAssetSoftObjectPath(FSoftObjectPath AttributeValue) { return default; }
	///<summary>Set a physics asset the skeletal mesh factory should use. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomPhysicAssetSoftObjectPath(FSoftObjectPath AttributeValue) { return default; }
	///<summary>Query the skeletal mesh import content type. The content type is use by the factory to import partial or full translated content. Return false if the attribute was not set.</summary>
	public  bool GetCustomImportContentType(EInterchangeSkeletalMeshContentType AttributeValue) { return default; }
	///<summary>Set the skeletal mesh import content type. The content type is use by the factory to import partial or full translated content. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomImportContentType(EInterchangeSkeletalMeshContentType AttributeValue) { return default; }
	///<summary>Query the skeletal mesh UseHighPrecisionSkinWeights.</summary>
	public  bool GetCustomUseHighPrecisionSkinWeights(bool AttributeValue) { return default; }
	///<summary>Set the skeletal mesh UseHighPrecisionSkinWeights.</summary>
	public  bool SetCustomUseHighPrecisionSkinWeights(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query the skeletal mesh threshold use to decide if two vertex position are equal.</summary>
	public  bool GetCustomThresholdPosition(float AttributeValue) { return default; }
	///<summary>Set the skeletal mesh threshold use to decide if two vertex position are equal.</summary>
	public  bool SetCustomThresholdPosition(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query the skeletal mesh threshold use to decide if two normal, tangents or bi-normals are equal.</summary>
	public  bool GetCustomThresholdTangentNormal(float AttributeValue) { return default; }
	///<summary>Set the skeletal mesh threshold use to decide if two normal, tangents or bi-normals are equal.</summary>
	public  bool SetCustomThresholdTangentNormal(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query the skeletal mesh threshold use to decide if two UVs are equal.</summary>
	public  bool GetCustomThresholdUV(float AttributeValue) { return default; }
	///<summary>Set the skeletal mesh threshold use to decide if two UVs are equal.</summary>
	public  bool SetCustomThresholdUV(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query the skeletal mesh threshold to compare vertex position equality when computing morph target deltas.</summary>
	public  bool GetCustomMorphThresholdPosition(float AttributeValue) { return default; }
	///<summary>Set the skeletal mesh threshold to compare vertex position equality when computing morph target deltas.</summary>
	public  bool SetCustomMorphThresholdPosition(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Query The maximum number of bone influences to allow each vertex in this mesh to use.</summary>
	public  bool GetCustomBoneInfluenceLimit(int AttributeValue) { return default; }
	///<summary>Set The maximum number of bone influences to allow each vertex in this mesh to use.</summary>
	public  bool SetCustomBoneInfluenceLimit(int AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
}
