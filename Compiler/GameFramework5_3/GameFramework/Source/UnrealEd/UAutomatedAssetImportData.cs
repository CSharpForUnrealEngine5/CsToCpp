namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains data for a group of assets to import</summary>
[CppInclude("AutomatedAssetImportData.h")]
public partial class UAutomatedAssetImportData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Display name of the group. This is for logging purposes only.</summary>
	public string GroupName;
	///<summary>Filenames to import</summary>
	public TArray<string> Filenames;
	///<summary>Content path in the projects content directory where assets will be imported</summary>
	public string DestinationPath;
	///<summary>Name of the factory to use when importing these assets. If not specified the factory type will be auto detected</summary>
	public string FactoryName;
	///<summary>Whether or not to replace existing assets</summary>
	public bool bReplaceExisting;
	///<summary>Whether or not to skip importing over read only assets that could not be checked out</summary>
	public bool bSkipReadOnly;
	///<summary>Pointer to the factory currently being used</summary>
	public UFactory Factory;
	///<summary>Full path to level to load before importing this group (only matters if importing assets into a level)</summary>
	public string LevelToLoad;
}
