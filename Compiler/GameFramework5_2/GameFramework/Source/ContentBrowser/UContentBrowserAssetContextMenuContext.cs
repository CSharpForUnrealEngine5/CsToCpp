#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserMenuContexts.h")]
public partial class UContentBrowserAssetContextMenuContext : UObject {
// ContentBrowserAssetContextMenuContext
	public UAssetDefinition CommonAssetDefinition;
	public TArray<FAssetData> SelectedAssets;
	public UClass CommonClass;
	public bool bCanBeModified;
	public  TArray<UObject> GetSelectedObjects() { return default; }
	public  TArray<UObject> LoadSelectedObjectsIfNeeded() { return default; }
	public  TArray<UObject> LoadSelectedObjects(TSet<string> LoadTags) { return default; }
}
