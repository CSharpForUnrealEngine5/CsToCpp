#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbcAssetImportData.h")]
///<summary>Base class for import data and options used when importing any asset from Alembic</summary>
public partial class UAbcAssetImportData : UAssetImportData {
// AbcAssetImportData
	public TArray<string> TrackNames;
	public FAbcSamplingSettings SamplingSettings;
	public FAbcNormalGenerationSettings NormalGenerationSettings;
	public FAbcMaterialSettings MaterialSettings;
	public FAbcCompressionSettings CompressionSettings;
	public FAbcStaticMeshSettings StaticMeshSettings;
	public FAbcGeometryCacheSettings GeometryCacheSettings;
	public FAbcConversionSettings ConversionSettings;
}
