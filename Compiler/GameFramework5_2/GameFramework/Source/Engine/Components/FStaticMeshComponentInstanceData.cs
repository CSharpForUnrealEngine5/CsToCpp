#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StaticMeshComponent.h")]
public partial struct FStaticMeshComponentInstanceData {
// StaticMeshComponentInstanceData
	public UStaticMesh StaticMesh;
	public TArray<FStaticMeshVertexColorLODData> VertexColorLODs;
	public TArray<FGuid> CachedStaticLighting;
	public TArray<FStreamingTextureBuildInfo> StreamingTextureData;
	public TArray<uint> MaterialStreamingRelativeBoxes;
}
