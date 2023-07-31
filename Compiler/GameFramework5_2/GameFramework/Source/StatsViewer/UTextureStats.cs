#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Statistics page for textures.</summary>
[CppInclude("TextureStats.h")]
public partial class UTextureStats : UObject {
	///<summary>Texture - click to go to asset</summary>
	public TWeakObjectPtr<UTexture> Texture;
	///<summary>Actor(s) - click to select &amp; zoom Actor(s)</summary>
	public TArray<TWeakObjectPtr<AActor>> Actors;
	///<summary>Texture type e.g. 2D, 3D, Cube, &quot;&quot; if not known, ...</summary>
	public string Type;
	///<summary>Is the texture virtual? Yes/No</summary>
	public string Virtual;
	///<summary>Max Dimension e.g. 256x256, not including the format</summary>
	public FVector2D MaxDim;
	///<summary>Current Dimension e.g 256x256</summary>
	public FVector2D CurrentDim;
	///<summary>The texture format, e.g. PF_DXT1</summary>
	public EPixelFormat Format;
	///<summary>The texture group, TEXTUREGROUP_MAX is not used, e.g. TEXTUREGROUP_World</summary>
	public TextureGroup Group;
	///<summary>LOD Bias for this texture. (Texture LODBias + Texture group)</summary>
	public int LODBias;
	///<summary>The memory used currently in KB</summary>
	public float CurrentKB;
	///<summary>The memory used when the texture is fully loaded in KB</summary>
	public float FullyLoadedKB;
	///<summary>The number of times the texture is used</summary>
	public int NumUses;
	///<summary>Relative time it was used for rendering the last time</summary>
	public float LastTimeRendered;
	///<summary>Texture path without the name &quot;package.[group.]&quot;</summary>
	public string Path;
}
