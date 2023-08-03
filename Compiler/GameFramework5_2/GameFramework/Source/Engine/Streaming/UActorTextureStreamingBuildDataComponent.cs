#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Streaming/ActorTextureStreamingBuildDataComponent.h")]
public partial class UActorTextureStreamingBuildDataComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>StreamableTextures</summary>
	public TArray<FStreamableTexture> StreamableTextures;
	///<summary>PackedTextureStreamingQualityLevelFeatureLevel</summary>
	public uint PackedTextureStreamingQualityLevelFeatureLevel;
}
