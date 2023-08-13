namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePhysicsAssetFactoryNode.h")]
public partial class UInterchangePhysicsAssetFactoryNode : UInterchangeFactoryBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize node data</summary>
	public void InitializePhysicsAssetNode(string UniqueID,string DisplayLabel,string InAssetClass) {}
	///<summary>Get the class this node want to create</summary>
	public virtual UClass GetObjectClass() { return default; }
	///<summary>Get skeletalMesh asset Uid used to create the data in the post pipeline step.</summary>
	public bool GetCustomSkeletalMeshUid(string AttributeValue) { return default; }
	///<summary>Set skeletalMesh asset Uid used to create the data in the post pipeline step.</summary>
	public bool SetCustomSkeletalMeshUid(string AttributeValue) { return default; }
}
