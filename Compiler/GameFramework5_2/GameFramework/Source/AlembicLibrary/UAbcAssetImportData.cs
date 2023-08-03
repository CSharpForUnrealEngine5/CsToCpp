#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for import data and options used when importing any asset from Alembic</summary>
[CppInclude("AbcAssetImportData.h")]
public partial class UAbcAssetImportData : UAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>TrackNames</summary>
	public TArray<string> TrackNames;
	///<summary>SamplingSettings</summary>
	public FAbcSamplingSettings SamplingSettings;
	///<summary>NormalGenerationSettings</summary>
	public FAbcNormalGenerationSettings NormalGenerationSettings;
	///<summary>MaterialSettings</summary>
	public FAbcMaterialSettings MaterialSettings;
	///<summary>CompressionSettings</summary>
	public FAbcCompressionSettings CompressionSettings;
	///<summary>StaticMeshSettings</summary>
	public FAbcStaticMeshSettings StaticMeshSettings;
	///<summary>GeometryCacheSettings</summary>
	public FAbcGeometryCacheSettings GeometryCacheSettings;
	///<summary>ConversionSettings</summary>
	public FAbcConversionSettings ConversionSettings;
}
