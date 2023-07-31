#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshUVFunctions.h")]
public partial struct FGeometryScriptRecomputeUVsOptions {
	public EGeometryScriptUVFlattenMethod Method;
	public EGeometryScriptUVIslandSource IslandSource;
	public FGeometryScriptExpMapUVOptions ExpMapOptions;
	public FGeometryScriptSpectralConformalUVOptions SpectralConformalOptions;
	public FGeometryScriptGroupLayer GroupLayer;
	public bool bAutoAlignIslandsWithAxes;
}
