#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TextureShare UObject container</summary>
[CppInclude("Blueprints/TextureShareBlueprintContainers.h")]
public partial class UTextureShareObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Override CustomData SendParameters</summary>
	public  void SendCustomData(TMap<string,string> InSendParameters) {}
	///<summary>Enable this texture share object</summary>
	public bool bEnable;
	///<summary>Object description</summary>
	public FTextureShareObjectDesc Desc;
	///<summary>Shared resources</summary>
	public FTextureShareTexturesDesc Textures;
	///<summary>Shared custom data</summary>
	public FTextureShareCustomData CustomData;
}
