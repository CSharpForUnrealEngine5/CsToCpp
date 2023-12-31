namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeSkeletonFactoryNode.h")]
public partial class UInterchangeSkeletonFactoryNode : UInterchangeFactoryBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize node data</summary>
	public void InitializeSkeletonNode(string UniqueID,string DisplayLabel,string InAssetClass) {}
	///<summary>Get the class this node want to create</summary>
	public virtual UClass GetObjectClass() { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public bool GetCustomRootJointUid(string AttributeValue) { return default; }
	///<summary>SetCustomRootJointUid</summary>
	public bool SetCustomRootJointUid(string AttributeValue) { return default; }
	///<summary>Query if this skeleton should replace joint transform with time zero evaluation instead of bind pose.</summary>
	public bool GetCustomUseTimeZeroForBindPose(bool AttributeValue) { return default; }
	///<summary>If AttributeValue is true, force this skeleton bind pose to use time zero instead of bind pose.</summary>
	public bool SetCustomUseTimeZeroForBindPose(bool AttributeValue) { return default; }
	///<summary>GetCustomSkeletalMeshFactoryNodeUid</summary>
	public bool GetCustomSkeletalMeshFactoryNodeUid(string AttributeValue) { return default; }
	///<summary>SetCustomSkeletalMeshFactoryNodeUid</summary>
	public bool SetCustomSkeletalMeshFactoryNodeUid(string AttributeValue) { return default; }
}
