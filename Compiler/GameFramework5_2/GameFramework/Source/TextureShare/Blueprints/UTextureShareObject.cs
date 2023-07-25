#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/TextureShareBlueprintContainers.h")]
///<summary>TextureShare UObject container</summary>
public partial class UTextureShareObject : UObject {
// TextureShareObject
	public void SendCustomData(TMap<string,string> InSendParameters) {}
	public bool bEnable;
	public FTextureShareObjectDesc Desc;
	public FTextureShareTexturesDesc Textures;
	public FTextureShareCustomData CustomData;
}
