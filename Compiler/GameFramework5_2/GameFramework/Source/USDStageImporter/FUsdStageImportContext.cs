#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
