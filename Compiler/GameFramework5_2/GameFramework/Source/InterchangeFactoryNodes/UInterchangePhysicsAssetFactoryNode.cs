#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePhysicsAssetFactoryNode.h")]
public partial class UInterchangePhysicsAssetFactoryNode : UInterchangeFactoryBaseNode {
	///<summary>Initialize node data</summary>
	public  void InitializePhysicsAssetNode(string UniqueID,string DisplayLabel,string InAssetClass) {}
	///<summary>Get the class this node want to create</summary>
	public  UClass GetObjectClass() { return default; }
	///<summary>Get skeletalMesh asset Uid used to create the data in the post pipeline step.</summary>
	public  bool GetCustomSkeletalMeshUid(string AttributeValue) { return default; }
	///<summary>Set skeletalMesh asset Uid used to create the data in the post pipeline step.</summary>
	public  bool SetCustomSkeletalMeshUid(string AttributeValue) { return default; }
}
