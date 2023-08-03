#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericTexturePipeline.h")]
public partial class UInterchangeGenericTexturePipeline : UInterchangePipelineBase {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, imports the texture assets found in the sources.</summary>
	public bool bImportTextures;
	///<summary>If enable, after a new import a test will be run to see if the texture is a normal map.</summary>
	public bool bDetectNormalMapTexture;
	///<summary>If enabled, the texture&#39;s green channel will be inverted for normal maps.</summary>
	public bool bFlipNormalMapGreenChannel;
	///<summary>If enabled detect if a texture use a UDIM pattern and if so import it as UIDMs.</summary>
	public bool bImportUDIMs;
	///<summary>Specify the files type that should be imported as long/lat cubemap</summary>
	public TSet<string> FileExtensionsToImportAsLongLatCubemap;
	///<summary>If true, tell the translator to provide a compressed source data payload when available.</summary>
	public bool bPreferCompressedSourceData;
	///<summary>Should the textures that have a non-power of two resolution be imported</summary>
	public bool bAllowNonPowerOfTwo;
	///<summary>BaseNodeContainer</summary>
	public UInterchangeBaseNodeContainer BaseNodeContainer;
}
