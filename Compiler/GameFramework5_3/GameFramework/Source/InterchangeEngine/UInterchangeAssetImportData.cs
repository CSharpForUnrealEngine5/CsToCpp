namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAssetImportData.h")]
public partial class UInterchangeAssetImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>Return the first filename stored in this data. The resulting filename will be absolute (ie, not relative to the asset).</summary>
	public string ScriptGetFirstFilename() { return default; }
	///<summary>Extract all the (resolved) filenames.</summary>
	public TArray<string> ScriptExtractFilenames() { return default; }
	///<summary>Extract all the filename labels.</summary>
	public TArray<string> ScriptExtractDisplayLabels() { return default; }
	///<summary>On a level import, set to the UInterchangeSceneImportAsset created during the import</summary>
	public FSoftObjectPath SceneImportAsset;
	///<summary>The Node UID pass to the factory that exist in the graph that was use to create this asset</summary>
	public string NodeUniqueID;
	///<summary>GetNodeContainer</summary>
	public UInterchangeBaseNodeContainer GetNodeContainer() { return default; }
	///<summary>SetNodeContainer</summary>
	public void SetNodeContainer(UInterchangeBaseNodeContainer InNodeContainer) {}
	///<summary>Returns Array of non-null pipelines</summary>
	public TArray<UObject> GetPipelines() { return default; }
	///<summary>GetNumberOfPipelines</summary>
	public int GetNumberOfPipelines() { return default; }
	///<summary>SetPipelines</summary>
	public void SetPipelines(TArray<UObject> InPipelines) {}
	///<summary>GetStoredNode</summary>
	public UInterchangeBaseNode GetStoredNode(string InNodeUniqueId) { return default; }
	///<summary>GetStoredFactoryNode</summary>
	public UInterchangeFactoryBaseNode GetStoredFactoryNode(string InNodeUniqueId) { return default; }
	///<summary>NodeContainer_DEPRECATED</summary>
	public UInterchangeBaseNodeContainer NodeContainer_DEPRECATED;
	///<summary>Pipelines_DEPRECATED</summary>
	public TArray<UObject> Pipelines_DEPRECATED;
	///<summary>TransientNodeContainer</summary>
	public UInterchangeBaseNodeContainer TransientNodeContainer;
	///<summary>TransientPipelines</summary>
	public TArray<UObject> TransientPipelines;
}
