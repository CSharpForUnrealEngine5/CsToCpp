#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbcImportSettings.h")]
///<summary>Class that contains all options for importing an alembic file</summary>
public partial class UAbcImportSettings : UObject {
// AbcImportSettings
	public EAlembicImportType ImportType;
	public FAbcSamplingSettings SamplingSettings;
	public FAbcNormalGenerationSettings NormalGenerationSettings;
	public FAbcMaterialSettings MaterialSettings;
	public FAbcCompressionSettings CompressionSettings;
	public FAbcStaticMeshSettings StaticMeshSettings;
	public FAbcGeometryCacheSettings GeometryCacheSettings;
	public FAbcConversionSettings ConversionSettings;
}
