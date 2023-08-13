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
	///<summary>The graph that was use to create this asset</summary>
	public UInterchangeBaseNodeContainer NodeContainer;
	///<summary>The Node UID pass to the factory that exist in the graph that was use to create this asset</summary>
	public string NodeUniqueID;
	///<summary>List of pipelines use to import an asset</summary>
	public TArray<UObject> Pipelines;
}
