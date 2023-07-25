#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericMaterialPipeline.h")]
public partial class UInterchangeGenericMaterialPipeline : UInterchangePipelineBase {
// InterchangeGenericMaterialPipeline
	public bool bImportMaterials;
	public EInterchangeMaterialImportOption MaterialImport;
	public FSoftObjectPath ParentMaterial;
	public UInterchangeGenericTexturePipeline TexturePipeline;
	public FMaterialXPipelineSettings MaterialXSettings;
	public UInterchangeBaseNodeContainer BaseNodeContainer;
}
