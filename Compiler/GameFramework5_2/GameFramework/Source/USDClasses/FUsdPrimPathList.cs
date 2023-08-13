namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple wrapper because we&#39;re not allowed to have TMap properties with TArray&lt;FString&gt; as values</summary>
[CppInclude("USDAssetImportData.h")]
public partial struct FUsdPrimPathList {
	public TArray<string> PrimPaths;
}
