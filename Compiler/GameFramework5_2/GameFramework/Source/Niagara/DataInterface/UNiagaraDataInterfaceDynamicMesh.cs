#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDynamicMesh.h")]
///<summary>Data Interface allowing sampling of a texture</summary>
public partial class UNiagaraDataInterfaceDynamicMesh : UNiagaraDataInterface {
// NiagaraDataInterfaceDynamicMesh
	public TArray<FNiagaraDynamicMeshSection> Sections;
	public TArray<FNiagaraDynamicMeshMaterial> Materials;
	public int NumVertices;
	public int NumTexCoords;
	public bool bHasColors;
	public bool bHasTangentBasis;
	public bool bClearTrianglesPerFrame;
	public FBox DefaultBounds;
}
