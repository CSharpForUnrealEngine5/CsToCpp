#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericMaterialPipeline.h")]
public partial class UInterchangeGenericMaterialPipeline : UInterchangePipelineBase {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, imports the material assets found in the sources.</summary>
	public bool bImportMaterials;
	///<summary>MaterialImport</summary>
	public EInterchangeMaterialImportOption MaterialImport;
	///<summary>Optional material used as the parent when importing materials as instances. If no parent material is specified, one will be automatically selected during the import process.</summary>
	public FSoftObjectPath ParentMaterial;
	///<summary>TexturePipeline</summary>
	public UInterchangeGenericTexturePipeline TexturePipeline;
	///<summary>MaterialXSettings</summary>
	public FMaterialXPipelineSettings MaterialXSettings;
	///<summary>END UInterchangePipelineBase overrides</summary>
	public UInterchangeBaseNodeContainer BaseNodeContainer;
}
