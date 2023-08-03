#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TextureShare UObject interface</summary>
[CppInclude("Blueprints/TextureShareBlueprintContainers.h")]
public partial class UTextureShare : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Create new or get exist UTextureShare object</summary>
	public  UTextureShareObject GetOrCreateTextureShareObject(string InShareName) { return default; }
	///<summary>RemoveTextureShareObject</summary>
	public  bool RemoveTextureShareObject(string InShareName) { return default; }
	///<summary>GetTextureShareObjects</summary>
	public  TArray<UTextureShareObject> GetTextureShareObjects() { return default; }
	///<summary>Enable sharing for all objects</summary>
	public bool bEnable;
	///<summary>Unique process name (optional). When empty, used default name</summary>
	public string ProcessName;
	///<summary>Objects for sharing</summary>
	public TArray<UTextureShareObject> TextureShareObjects;
}
