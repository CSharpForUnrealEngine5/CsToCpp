#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GeometryCacheAbcFileComponent, encapsulates a transient GeometryCache asset instance that fetches its data from an Alembic file and implements functionality for rendering and playback</summary>
[CppInclude("GeometryCacheAbcFileComponent.h")]
public partial class UGeometryCacheAbcFileComponent : UGeometryCacheComponent {
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
