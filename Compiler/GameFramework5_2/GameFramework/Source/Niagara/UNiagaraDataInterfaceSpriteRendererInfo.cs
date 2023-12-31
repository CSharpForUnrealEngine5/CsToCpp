namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Data Interface can be used to query information about the sprite renderers of an emitter</summary>
[CppInclude("NiagaraDataInterfaceSpriteRendererInfo.h")]
public partial class UNiagaraDataInterfaceSpriteRendererInfo : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the sprite renderer</summary>
	public UNiagaraSpriteRendererProperties SpriteRenderer;
}
