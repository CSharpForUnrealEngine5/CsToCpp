#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceLandscape.h")]
///<summary>Data Interface allowing sampling of a Landscape</summary>
public partial class UNiagaraDataInterfaceLandscape : UNiagaraDataInterface {
// NiagaraDataInterfaceLandscape
	public AActor SourceLandscape;
	public ENDILandscape_SourceMode SourceMode;
	public TArray<UPhysicalMaterial> PhysicalMaterials;
}
