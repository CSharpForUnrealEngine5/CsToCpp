#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetImportData.h")]
///<summary>Simple wrapper because we're not allowed to have TMap properties with TArray<FString> as values</summary>
public partial struct FUsdPrimPathList {
// UsdPrimPathList
	public TArray<string> PrimPaths;
}
