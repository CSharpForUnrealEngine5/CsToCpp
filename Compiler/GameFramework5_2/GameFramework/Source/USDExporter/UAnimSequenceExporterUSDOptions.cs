#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options for exporting skeletal mesh animations to USD format.</summary>
[CppInclude("AnimSequenceExporterUSDOptions.h")]
public partial class UAnimSequenceExporterUSDOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Export options to use for the layer where the animation is emitted</summary>
	public FUsdStageOptions StageOptions;
	///<summary>Whether to also export the skeletal mesh data of the preview mesh</summary>
	public bool bExportPreviewMesh;
	///<summary>Export options to use for the preview mesh, if enabled</summary>
	public FUsdMeshAssetOptions PreviewMeshOptions;
	///<summary>Whether to export any asset (StaticMesh, Material, etc.) even if the existing file already describes the same version of a compatible asset.</summary>
	public bool bReExportIdenticalAssets;
}
