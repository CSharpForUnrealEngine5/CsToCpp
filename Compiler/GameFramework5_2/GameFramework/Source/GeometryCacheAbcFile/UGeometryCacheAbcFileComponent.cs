namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GeometryCacheAbcFileComponent, encapsulates a transient GeometryCache asset instance that fetches its data from an Alembic file and implements functionality for rendering and playback</summary>
[CppInclude("GeometryCacheAbcFileComponent.h")]
public partial class UGeometryCacheAbcFileComponent : UGeometryCacheComponent {
	public static UClass StaticClass() {return default;}
	///<summary>AlembicFilePath</summary>
	public FFilePath AlembicFilePath;
	///<summary>SamplingSettings</summary>
	public FAbcSamplingSettings SamplingSettings;
	///<summary>ConversionSettings</summary>
	public FAbcConversionSettings ConversionSettings;
	///<summary>GeometryCacheSettings</summary>
	public FAbcGeometryCacheSettings GeometryCacheSettings;
	///<summary>NormalGenerationSettings</summary>
	public FAbcNormalGenerationSettings NormalGenerationSettings;
	///<summary>MaterialSettings</summary>
	public FAbcMaterialSettings MaterialSettings;
	///<summary>AbcSettings</summary>
	public UAbcImportSettings AbcSettings;
}
