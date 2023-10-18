namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A coordinate on a mesh usable in Niagara.</summary>
[CppInclude("NiagaraDataInterfaceMeshCommon.h")]
public partial struct FMeshTriCoordinate {
	public int Tri;
	public FVector3f BaryCoord;
}
