namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageImportContext.h")]
public partial struct FUsdStageImportContext {
	public AActor SceneActor;
	public string ObjectName;
	public string PackagePath;
	public string FilePath;
	public UUsdStageImportOptions ImportOptions;
	public UObject ImportedAsset;
	public UUsdAssetCache2 AssetCache;
}
