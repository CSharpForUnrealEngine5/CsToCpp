#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/TextureShareBlueprintContainers.h")]
///<summary>TextureShare UObject interface</summary>
public partial class UTextureShare : UObject {
// TextureShare
	public UObject GetOrCreateTextureShareObject(string InShareName) { return default; }
	public bool RemoveTextureShareObject(string InShareName) { return default; }
	public TArray<UObject> GetTextureShareObjects() { return default; }
	public bool bEnable;
	public string ProcessName;
	public TArray<UTextureShareObject> TextureShareObjects;
}
