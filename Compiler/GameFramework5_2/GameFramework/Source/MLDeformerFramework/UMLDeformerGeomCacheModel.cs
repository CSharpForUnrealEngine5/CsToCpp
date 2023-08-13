namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A ML Deformer model that has a geometry cache as target mesh.</summary>
[CppInclude("MLDeformerGeomCacheModel.h")]
public partial class UMLDeformerGeomCacheModel : UMLDeformerModel {
	public static UClass StaticClass() {return default;}
	///<summary>The geometry cache that represents the target deformations.</summary>
	public TSoftObjectPtr<UGeometryCache> GeometryCache;
}
