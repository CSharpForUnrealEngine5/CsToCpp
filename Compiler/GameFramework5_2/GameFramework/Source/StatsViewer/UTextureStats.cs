#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureStats.h")]
///<summary>Statistics page for textures.</summary>
public partial class UTextureStats : UObject {
// TextureStats
	public TWeakObjectPtr<UTexture> Texture;
	public TArray<TWeakObjectPtr<AActor>> Actors;
	public string Type;
	public string Virtual;
	public FVector2D MaxDim;
	public FVector2D CurrentDim;
	public byte Format;
	public byte Group;
	public int LODBias;
	public float CurrentKB;
	public float FullyLoadedKB;
	public int NumUses;
	public float LastTimeRendered;
	public string Path;
}
