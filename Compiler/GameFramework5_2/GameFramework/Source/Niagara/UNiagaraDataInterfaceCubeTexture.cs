namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of a texture</summary>
[CppInclude("NiagaraDataInterfaceCubeTexture.h")]
public partial class UNiagaraDataInterfaceCubeTexture : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Texture</summary>
	public UTexture Texture;
	///<summary>When valid the user parameter is used as the texture rather than the one on the data interface</summary>
	public FNiagaraUserParameterBinding TextureUserParameter;
}
