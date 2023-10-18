namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of a sparse volume texture</summary>
[CppInclude("NiagaraDataInterfaceSparseVolumeTexture.h")]
public partial class UNiagaraDataInterfaceSparseVolumeTexture : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>SparseVolumeTexture</summary>
	public USparseVolumeTexture SparseVolumeTexture;
	///<summary>When valid the user parameter is used as the texture rather than the one on the data interface</summary>
	public FNiagaraUserParameterBinding SparseVolumeTextureUserParameter;
}
