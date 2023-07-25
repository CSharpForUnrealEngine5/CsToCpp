#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimSequenceExporterUSDOptions.h")]
///<summary>Options for exporting skeletal mesh animations to USD format.</summary>
public partial class UAnimSequenceExporterUSDOptions : UObject {
// AnimSequenceExporterUSDOptions
	public FUsdStageOptions StageOptions;
	public bool bExportPreviewMesh;
	public FUsdMeshAssetOptions PreviewMeshOptions;
	public bool bReExportIdenticalAssets;
}
