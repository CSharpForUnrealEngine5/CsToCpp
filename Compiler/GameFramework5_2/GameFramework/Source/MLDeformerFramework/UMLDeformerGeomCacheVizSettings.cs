#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The vizualization settings for a model that has a geometry cache.</summary>
[CppInclude("MLDeformerGeomCacheVizSettings.h")]
public partial class UMLDeformerGeomCacheVizSettings : UMLDeformerVizSettings {
	///<summary>The geometry cache that represents the ground truth of the test anim sequence.</summary>
	public TSoftObjectPtr<UGeometryCache> GroundTruth;
}
