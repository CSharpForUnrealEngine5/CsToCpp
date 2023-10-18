namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StaticMeshComponent.h")]
public partial struct FStaticMeshComponentInstanceData {
	public UStaticMesh StaticMesh;
	public TArray<FStaticMeshVertexColorLODData> VertexColorLODs;
	public TArray<FGuid> CachedStaticLighting;
	public TArray<FStreamingTextureBuildInfo> StreamingTextureData;
	public TArray<uint> MaterialStreamingRelativeBoxes;
}
