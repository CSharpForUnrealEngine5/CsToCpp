#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialExporterUSDOptions.h")]
///<summary>Options for exporting materials to USD format.</summary>
public partial class UMaterialExporterUSDOptions : UObject {
// MaterialExporterUSDOptions
	public FUsdMaterialBakingOptions MaterialBakingOptions;
	public bool bReExportIdenticalAssets;
}
