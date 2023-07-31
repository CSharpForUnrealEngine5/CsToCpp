#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The asset containing various options and the schema itself.</summary>
[CppInclude("WebAPIDefinition.h")]
public partial class UWebAPIDefinition : UObject {
	///<summary>Importing data and options used for this definition.</summary>
	public UAssetImportData AssetImportData;
	///<summary>Settings for the WebAPI provider.</summary>
	public FWebAPIProviderSettings ProviderSettings;
	///<summary>Settings for code generation.</summary>
	public FWebAPICodeGeneratorSettings GeneratorSettings;
	///<summary>Optional data store, ie. schema file contents.</summary>
	public TMap<string,UObject> ImportedDataCache;
	///<summary>The schema written by the provider.</summary>
	public UWebAPISchema WebAPISchema;
}
