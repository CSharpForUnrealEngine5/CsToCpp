#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A ML Deformer model that has a geometry cache as target mesh.</summary>
[CppInclude("MLDeformerGeomCacheModel.h")]
public partial class UMLDeformerGeomCacheModel : UMLDeformerModel {
	///<summary>The geometry cache that represents the target deformations.</summary>
	public TSoftObjectPtr<UGeometryCache> GeometryCache;
}
