#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCacheAbcFileComponent.h")]
///<summary>GeometryCacheAbcFileComponent, encapsulates a transient GeometryCache asset instance that fetches its data from an Alembic file and implements functionality for rendering and playback</summary>
public partial class UGeometryCacheAbcFileComponent : UGeometryCacheComponent {
// GeometryCacheAbcFileComponent
	public FFilePath AlembicFilePath;
	public FAbcSamplingSettings SamplingSettings;
	public FAbcConversionSettings ConversionSettings;
	public FAbcGeometryCacheSettings GeometryCacheSettings;
	public FAbcNormalGenerationSettings NormalGenerationSettings;
	public FAbcMaterialSettings MaterialSettings;
	public UAbcImportSettings AbcSettings;
}
