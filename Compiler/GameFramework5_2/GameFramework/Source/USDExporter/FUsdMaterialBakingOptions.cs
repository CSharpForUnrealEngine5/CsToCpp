#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetOptions.h")]
public partial struct FUsdMaterialBakingOptions {
// UsdMaterialBakingOptions
	public TArray<FPropertyEntry> Properties;
	public FIntPoint DefaultTextureSize;
	public bool bConstantColorAsSingleValue;
	public FDirectoryPath TexturesDir;
}
