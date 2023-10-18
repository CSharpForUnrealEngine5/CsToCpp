namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of a Landscape</summary>
[CppInclude("NiagaraDataInterfaceLandscape.h")]
public partial class UNiagaraDataInterfaceLandscape : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>SourceLandscape</summary>
	public AActor SourceLandscape;
	///<summary>SourceMode</summary>
	public ENDILandscape_SourceMode SourceMode;
	///<summary>PhysicalMaterials</summary>
	public TArray<UPhysicalMaterial> PhysicalMaterials;
}
