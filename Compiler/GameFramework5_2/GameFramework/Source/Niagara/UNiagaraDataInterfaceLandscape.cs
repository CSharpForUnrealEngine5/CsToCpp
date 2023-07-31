#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of a Landscape</summary>
[CppInclude("NiagaraDataInterfaceLandscape.h")]
public partial class UNiagaraDataInterfaceLandscape : UNiagaraDataInterface {
	///<summary>SourceLandscape</summary>
	public AActor SourceLandscape;
	///<summary>SourceMode</summary>
	public ENDILandscape_SourceMode SourceMode;
	///<summary>PhysicalMaterials</summary>
	public TArray<UPhysicalMaterial> PhysicalMaterials;
}
