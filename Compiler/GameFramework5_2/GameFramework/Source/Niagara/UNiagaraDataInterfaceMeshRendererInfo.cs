namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Data Interface can be used to query information about the mesh renderers of an emitter</summary>
[CppInclude("NiagaraDataInterfaceMeshRendererInfo.h")]
public partial class UNiagaraDataInterfaceMeshRendererInfo : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the mesh renderer</summary>
	public UNiagaraMeshRendererProperties MeshRenderer;
}
