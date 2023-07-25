#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticMeshLightingInfo.h")]
///<summary>Statistics page for static meshes.</summary>
public partial class UStaticMeshLightingInfo : UObject {
// StaticMeshLightingInfo
	public TWeakObjectPtr<AActor> StaticMeshActor;
	public TWeakObjectPtr<UStaticMesh> StaticMesh;
	public string LevelName;
	public string TextureMapping;
	public bool bTextureMapping;
	public bool bHasLightmapTexCoords;
	public int StaticLightingResolution;
	public float TextureLightMapMemoryUsage;
	public float VertexLightMapMemoryUsage;
	public int LightMapLightCount;
	public float TextureShadowMapMemoryUsage;
	public float VertexShadowMapMemoryUsage;
	public int ShadowMapLightCount;
	public TArray<string> LightmapTextureNames;
}
