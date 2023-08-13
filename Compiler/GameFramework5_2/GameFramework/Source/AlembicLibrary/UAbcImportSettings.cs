namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that contains all options for importing an alembic file</summary>
[CppInclude("AbcImportSettings.h")]
public partial class UAbcImportSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Type of asset to import from Alembic file</summary>
	public EAlembicImportType ImportType;
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
