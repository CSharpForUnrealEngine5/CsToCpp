namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericMaterialPipeline.h")]
public partial class UInterchangeGenericMaterialPipeline : UInterchangePipelineBase {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, imports the material assets found in the sources.</summary>
	public bool bImportMaterials;
	///<summary>If not empty, and there is only one asset and one source data, we will name the asset with this string.</summary>
	public string AssetName;
	///<summary>MaterialImport</summary>
	public EInterchangeMaterialImportOption MaterialImport;
	///<summary>Optional material used as the parent when importing materials as instances. If no parent material is specified, one will be automatically selected during the import process.</summary>
	public FSoftObjectPath ParentMaterial;
	///<summary>TexturePipeline</summary>
	public UInterchangeGenericTexturePipeline TexturePipeline;
	///<summary>END UInterchangePipelineBase overrides</summary>
	public UInterchangeBaseNodeContainer BaseNodeContainer;
}
