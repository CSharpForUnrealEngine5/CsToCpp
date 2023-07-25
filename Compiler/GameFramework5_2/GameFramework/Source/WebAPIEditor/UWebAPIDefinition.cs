#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPIDefinition.h")]
///<summary>The asset containing various options and the schema itself.</summary>
public partial class UWebAPIDefinition : UObject {
// WebAPIDefinition
	public UAssetImportData AssetImportData;
	public FWebAPIProviderSettings ProviderSettings;
	public FWebAPICodeGeneratorSettings GeneratorSettings;
	public TMap<string,UObject> ImportedDataCache;
	public UWebAPISchema WebAPISchema;
}
