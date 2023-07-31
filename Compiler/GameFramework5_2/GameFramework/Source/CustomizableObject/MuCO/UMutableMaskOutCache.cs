#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
public partial class UMutableMaskOutCache : UObject {
	///<summary>Materials</summary>
	public TMap<string,string> Materials;
	///<summary>Maps a UMaterial&#39;s asset path to a UTexture&#39;s asset path</summary>
	public TMap<string,FMaskOutTexture> Textures;
}
