#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of a texture</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceVirtualTexture.h")]
public partial class UNiagaraDataInterfaceVirtualTexture : UNiagaraDataInterface {
	///<summary>, meta = (AllowedClasses = &quot;/Script/Engine.VirtualTexture2D&quot;))</summary>
	public URuntimeVirtualTexture Texture;
	///<summary>When valid the user parameter is used as the texture rather than the one on the data interface</summary>
	public FNiagaraUserParameterBinding TextureUserParameter;
}
