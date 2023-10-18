namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEditorAssetSubsystem</summary>
[CppInclude("Subsystems/EditorAssetSubsystem.h")]
public partial class UEditorAssetSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Load an asset. It will verify if the object is already loaded and only load it if it&#39;s necessary.</summary>
	public UObject LoadAsset(string AssetPath) { return default; }
	///<summary>Load a Blueprint asset and return its generated class. It will verify if the object is already loaded and only load it if it&#39;s necessary.</summary>
	public UClass LoadBlueprintClass(string AssetPath) { return default; }
	///<summary>Return a valid AssetPath for a loaded asset.</summary>
	public string GetPathNameForLoadedAsset(UObject LoadedAsset) { return default; }
	///<summary>Return the AssetData for the Asset that can then be used with AssetRegistryHelpers.</summary>
	public FAssetData FindAssetData(string AssetPath) { return default; }
	///<summary>Check if an asset exists in the Asset Registry.</summary>
	public bool DoesAssetExist(string AssetPath) { return default; }
	///<summary>Check if assets exist in the Asset Registry.</summary>
	public bool DoAssetsExist(TArray<string> AssetPaths) { return default; }
	///<summary>Find Package Referencers for an asset. Only Soft and Hard dependencies will be looked for.</summary>
	public TArray<string> FindPackageReferencersForAsset(string AssetPath,bool bLoadAssetsToConfirm/*=false*/) { return default; }
	///<summary>Consolidates assets by replacing all references/uses of the provided AssetsToConsolidate with references to AssetToConsolidateTo.</summary>
	public bool ConsolidateAssets(UObject AssetToConsolidateTo,TArray<UObject> AssetsToConsolidate) { return default; }
	///<summary>Delete an asset that is already loaded.</summary>
	public bool DeleteLoadedAsset(UObject AssetToDelete) { return default; }
	///<summary>Delete assets that are already loaded.</summary>
	public bool DeleteLoadedAssets(TArray<UObject> AssetsToDelete) { return default; }
	///<summary>Delete the package an asset is in. All objects in the package will be deleted.</summary>
	public bool DeleteAsset(string AssetPathToDelete) { return default; }
	///<summary>Delete the packages inside a directory. If the directory is then empty, delete the directory.</summary>
	public bool DeleteDirectory(string DirectoryPath) { return default; }
	///<summary>Duplicate an asset that is already loaded. Will try to checkout the file.</summary>
	public UObject DuplicateLoadedAsset(UObject SourceAsset,string DestinationAssetPath) { return default; }
	///<summary>Duplicate an asset. Will try to checkout the file. The Asset will be loaded before being duplicated.</summary>
	public UObject DuplicateAsset(string SourceAssetPath,string DestinationAssetPath) { return default; }
	///<summary>Duplicate a directory and the assets in it.</summary>
	public bool DuplicateDirectory(string SourceDirectoryPath,string DestinationDirectoryPath) { return default; }
	///<summary>Rename an asset that is already loaded. Equivalent to a Move operation.</summary>
	public bool RenameLoadedAsset(UObject SourceAsset,string DestinationAssetPath) { return default; }
	///<summary>Rename an asset. Equivalent to a Move operation.</summary>
	public bool RenameAsset(string SourceAssetPath,string DestinationAssetPath) { return default; }
	///<summary>Rename a directory. Equivalent to a Move operation moving all contained assets.</summary>
	public bool RenameDirectory(string SourceDirectoryPath,string DestinationDirectoryPath) { return default; }
	///<summary>Checkout the asset corresponding to an object.</summary>
	public bool CheckoutLoadedAsset(UObject AssetToCheckout) { return default; }
	///<summary>Checkout the assets.</summary>
	public bool CheckoutLoadedAssets(TArray<UObject> AssetsToCheckout) { return default; }
	///<summary>Checkout an asset.</summary>
	public bool CheckoutAsset(string AssetToCheckout) { return default; }
	///<summary>Checkout all assets in a directory. It will load the assets if needed.</summary>
	public bool CheckoutDirectory(string DirectoryPath,bool bRecursive/*=true*/) { return default; }
	///<summary>Save the package the asset lives in. All objects that live in the package will be saved. Will try to checkout the file.</summary>
	public bool SaveLoadedAsset(UObject AssetToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	///<summary>Save the packages the assets live in. All objects that live in the packages will be saved. Will try to checkout the files.</summary>
	public bool SaveLoadedAssets(TArray<UObject> AssetsToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	///<summary>Save the packages the assets live in. All objects that live in the package will be saved.</summary>
	public bool SaveAsset(string AssetToSave,bool bOnlyIfIsDirty/*=true*/) { return default; }
	///<summary>Save the packages the assets live in inside the directory. All objects that are in the directory will be saved.</summary>
	public bool SaveDirectory(string DirectoryPath,bool bOnlyIfIsDirty/*=true*/,bool bRecursive/*=true*/) { return default; }
	///<summary>Check if a directory exists.</summary>
	public bool DoesDirectoryExist(string DirectoryPath) { return default; }
	///<summary>Check if a directory contains any assets.</summary>
	public bool DoesDirectoryContainAssets(string DirectoryPath,bool bRecursive/*=true*/) { return default; }
	///<summary>Create a directory on disk.</summary>
	public bool MakeDirectory(string DirectoryPath) { return default; }
	///<summary>Return the list of all the assets found in the DirectoryPath.</summary>
	public TArray<string> ListAssets(string DirectoryPath,bool bRecursive/*=true*/,bool bIncludeFolder/*=false*/) { return default; }
	///<summary>Return the list of all the assets that have the pair of Tag/Value.</summary>
	public TArray<string> ListAssetsByTagValue(FName TagName,string TagValue) { return default; }
	///<summary>Gets all TagValues (from Asset Registry) associated with an (unloaded) asset as strings value.</summary>
	public TMap<FName,string> GetTagValues(string AssetPath) { return default; }
	///<summary>Get all tags/values of a loaded asset&#39;s metadata.</summary>
	public TMap<FName,string> GetMetadataTagValues(UObject Object) { return default; }
	///<summary>Get the value associated with the given tag of a loaded asset&#39;s metadata.</summary>
	public string GetMetadataTag(UObject Object,FName Tag) { return default; }
	///<summary>Set the value associated with a given tag of a loaded asset&#39;s metadata.</summary>
	public void SetMetadataTag(UObject Object,FName Tag,string Value) {}
	///<summary>Remove the given tag from a loaded asset&#39;s metadata.</summary>
	public void RemoveMetadataTag(UObject Object,FName Tag) {}
	///<summary>Dynamic version of FOnExtractAssetFromFile.</summary>
	public void FOnExtractAssetFromFileDynamic(TArray<string> Files,TArray<FAssetData> AssetDataArray) {}
	///<summary>Call this to add a callback to extract an asset from a file,</summary>
	public void AddOnExtractAssetFromFile(FOnExtractAssetFromFileDynamic Delegate) {}
	///<summary>Call this to remove a callback added with AddOnExtractAssetFromFile.</summary>
	public void RemoveOnExtractAssetFromFile(FOnExtractAssetFromFileDynamic Delegate) {}
}
