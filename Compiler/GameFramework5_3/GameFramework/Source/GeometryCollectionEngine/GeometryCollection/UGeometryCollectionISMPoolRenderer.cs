namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implementation of a geometry collection custom renderer that pushes AutoInstanceMeshes to an ISMPool.</summary>
[CppInclude("GeometryCollection/GeometryCollectionISMPoolRenderer.h")]
public partial class UGeometryCollectionISMPoolRenderer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Instanced Static Mesh Pool actor that is used to render our meshes.</summary>
	public AGeometryCollectionISMPoolActor ISMPoolActor;
}
