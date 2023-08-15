namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserMenuContexts.h")]
public partial class UContentBrowserAssetContextMenuContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CommonAssetDefinition</summary>
	public UAssetDefinition CommonAssetDefinition;
	///<summary>The currently selected assets in the content browser.</summary>
	public TArray<FAssetData> SelectedAssets;
	///<summary>CommonClass</summary>
	public UClass CommonClass;
	///<summary>bCanBeModified</summary>
	public bool bCanBeModified;
	///<summary>UE_DEPRECATED(5.2, &quot;GetSelectedObjects has been deprecated.  We no longer automatically load assets on right click.  Please use SelectedAssets and determine whatever you need for your context menu options without actually loading the assets.  When you finally need all or a subset of the selected assets use LoadSelectedAssets or LoadSelectedAssetsIf&quot;)</summary>
	public TArray<UObject> GetSelectedObjects() { return default; }
	///<summary>Loads the selected assets (if needed) which is based on AssetViewUtils::LoadAssetsIfNeeded, this exists primarily</summary>
	public TArray<UObject> LoadSelectedObjectsIfNeeded() { return default; }
	///<summary>Loads all the selected assets and returns an array of the objects.</summary>
	public TArray<UObject> LoadSelectedObjects(TSet<FName> LoadTags) { return default; }
}
