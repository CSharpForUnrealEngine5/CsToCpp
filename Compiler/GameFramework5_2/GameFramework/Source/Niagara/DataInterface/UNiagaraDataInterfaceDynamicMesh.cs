#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of a texture</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceDynamicMesh.h")]
public partial class UNiagaraDataInterfaceDynamicMesh : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Sections to render, each section will generally result in a draw call.</summary>
	public TArray<FNiagaraDynamicMeshSection> Sections;
	///<summary>List of materials to use</summary>
	public TArray<FNiagaraDynamicMeshMaterial> Materials;
	///<summary>Allocates space for the number of vertices we will use, leave as zero if you intend to allocate dynamically via VM calls.</summary>
	public int NumVertices;
	///<summary>Allocates space for the number of texture coordinates requested.</summary>
	public int NumTexCoords;
	///<summary>Allocates space for vertex colors when enabled.</summary>
	public bool bHasColors;
	///<summary>Allocates space for tangent basis when enabled.</summary>
	public bool bHasTangentBasis;
	///<summary>Should we auto clear section triangle allocations per frame or not.</summary>
	public bool bClearTrianglesPerFrame;
	///<summary>Should we auto clear section triangle allocations per frame or not.</summary>
	public FBox DefaultBounds;
}
