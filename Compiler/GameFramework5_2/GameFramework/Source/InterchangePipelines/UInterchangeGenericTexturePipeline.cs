#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericTexturePipeline.h")]
public partial class UInterchangeGenericTexturePipeline : UInterchangePipelineBase {
// InterchangeGenericTexturePipeline
	public bool bImportTextures;
	public bool bDetectNormalMapTexture;
	public bool bFlipNormalMapGreenChannel;
	public bool bImportUDIMs;
	public TSet<string> FileExtensionsToImportAsLongLatCubemap;
	public bool bPreferCompressedSourceData;
	public bool bAllowNonPowerOfTwo;
	public UInterchangeBaseNodeContainer BaseNodeContainer;
}
