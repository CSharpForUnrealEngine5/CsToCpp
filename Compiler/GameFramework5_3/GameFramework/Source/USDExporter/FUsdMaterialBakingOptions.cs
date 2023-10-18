namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetOptions.h")]
public partial struct FUsdMaterialBakingOptions {
	public TArray<FPropertyEntry> Properties;
	public FIntPoint DefaultTextureSize;
	public bool bConstantColorAsSingleValue;
	public FDirectoryPath TexturesDir;
}
