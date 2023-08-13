namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>namespace UE</summary>
[CppInclude("InterchangeStaticMeshFactoryNode.h")]
public partial class UInterchangeStaticMeshFactoryNode : UInterchangeMeshFactoryNode {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize node data</summary>
	public void InitializeStaticMeshNode(string UniqueID,string DisplayLabel,string InAssetClass) {}
	///<summary>Get the class this node want to create</summary>
	public virtual UClass GetObjectClass() { return default; }
	///<summary>Get weather the static mesh factory should set the nanite build settings. Return false if the attribute was not set.</summary>
	public bool GetCustomBuildNanite(bool AttributeValue) { return default; }
	///<summary>Set weather the static mesh factory should set the nanite build settings. Return false if the attribute was not set.</summary>
	public bool SetCustomBuildNanite(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return The number of socket UIDs this static mesh has.</summary>
	public int GetSocketUidCount() { return default; }
	///<summary>GetSocketUids</summary>
	public void GetSocketUids(TArray<string> OutSocketUids) {}
	///<summary>AddSocketUid</summary>
	public bool AddSocketUid(string SocketUid) { return default; }
	///<summary>AddSocketUids</summary>
	public bool AddSocketUids(TArray<string> InSocketUids) { return default; }
	///<summary>RemoveSocketUd</summary>
	public bool RemoveSocketUd(string SocketUid) { return default; }
	///<summary>Get weather the static mesh should build build a reverse index buffer.</summary>
	public bool GetCustomBuildReversedIndexBuffer(bool AttributeValue) { return default; }
	///<summary>Set weather the static mesh should build build a reverse index buffer.</summary>
	public bool SetCustomBuildReversedIndexBuffer(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get weather the static mesh should build build a reverse index buffer.</summary>
	public bool GetCustomGenerateLightmapUVs(bool AttributeValue) { return default; }
	///<summary>Set weather the static mesh should build build a reverse index buffer.</summary>
	public bool SetCustomGenerateLightmapUVs(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get Whether to generate the distance field treating every triangle hit as a front face.</summary>
	public bool GetCustomGenerateDistanceFieldAsIfTwoSided(bool AttributeValue) { return default; }
	///<summary>Set Whether to generate the distance field treating every triangle hit as a front face.</summary>
	public bool SetCustomGenerateDistanceFieldAsIfTwoSided(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get weather the static mesh ... (TODO add documentation)</summary>
	public bool GetCustomSupportFaceRemap(bool AttributeValue) { return default; }
	///<summary>Set weather the static mesh ... (TODO add documentation)</summary>
	public bool SetCustomSupportFaceRemap(bool AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get weather the static mesh ... (TODO add documentation)</summary>
	public bool GetCustomMinLightmapResolution(int AttributeValue) { return default; }
	///<summary>Set weather the static mesh ... (TODO add documentation)</summary>
	public bool SetCustomMinLightmapResolution(int AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get weather the static mesh ... (TODO add documentation)</summary>
	public bool GetCustomSrcLightmapIndex(int AttributeValue) { return default; }
	///<summary>Set weather the static mesh ... (TODO add documentation)</summary>
	public bool SetCustomSrcLightmapIndex(int AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get weather the static mesh ... (TODO add documentation)</summary>
	public bool GetCustomDstLightmapIndex(int AttributeValue) { return default; }
	///<summary>Set weather the static mesh ... (TODO add documentation)</summary>
	public bool SetCustomDstLightmapIndex(int AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get the static mesh local scale applied when building the static mesh.</summary>
	public bool GetCustomBuildScale3D(FVector AttributeValue) { return default; }
	///<summary>Set the static mesh local scale applied when building the static mesh.</summary>
	public bool SetCustomBuildScale3D(FVector AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get the Scale to apply to the mesh when allocating the distance field volume texture.</summary>
	public bool GetCustomDistanceFieldResolutionScale(float AttributeValue) { return default; }
	///<summary>Set the Scale to apply to the mesh when allocating the distance field volume texture.</summary>
	public bool SetCustomDistanceFieldResolutionScale(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get the static mesh local scale applied when building the static mesh.</summary>
	public bool GetCustomDistanceFieldReplacementMesh(FSoftObjectPath AttributeValue) { return default; }
	///<summary>Set the static mesh local scale applied when building the static mesh.</summary>
	public bool SetCustomDistanceFieldReplacementMesh(FSoftObjectPath AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Max Lumen mesh cards to generate for this mesh.</summary>
	public bool GetCustomMaxLumenMeshCards(int AttributeValue) { return default; }
	///<summary>Max Lumen mesh cards to generate for this mesh.</summary>
	public bool SetCustomMaxLumenMeshCards(int AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
}
