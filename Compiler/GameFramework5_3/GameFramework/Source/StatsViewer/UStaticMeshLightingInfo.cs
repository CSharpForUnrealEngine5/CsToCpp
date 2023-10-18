namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Statistics page for static meshes.</summary>
[CppInclude("StaticMeshLightingInfo.h")]
public partial class UStaticMeshLightingInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The actor that is related to this error/warning.</summary>
	public TWeakObjectPtr<AActor> StaticMeshActor;
	///<summary>The source StaticMesh that is related to this info.</summary>
	public TWeakObjectPtr<UStaticMesh> StaticMesh;
	///<summary>Cached version of the level name this object resides in</summary>
	public string LevelName;
	///<summary>Current mapping type string</summary>
	public string TextureMapping;
	///<summary>Current mapping type flag - not displayed</summary>
	public bool bTextureMapping;
	///<summary>Does the Lightmap have UVs?</summary>
	public bool bHasLightmapTexCoords;
	///<summary>The static lighting resolution the texture mapping was estimated with.</summary>
	public int StaticLightingResolution;
	///<summary>Estimated memory usage in KB for light map texel data.</summary>
	public float TextureLightMapMemoryUsage;
	///<summary>Estimated memory usage in KB for light map vertex data.</summary>
	public float VertexLightMapMemoryUsage;
	///<summary>Num lightmap lights</summary>
	public int LightMapLightCount;
	///<summary>Estimated memory usage in KB for shadow map texel data.</summary>
	public float TextureShadowMapMemoryUsage;
	///<summary>Estimated memory usage in KB for shadow map vertex data.</summary>
	public float VertexShadowMapMemoryUsage;
	///<summary>Number of lights generating shadow maps on the primitive.</summary>
	public int ShadowMapLightCount;
	///<summary>The lighting texture names that the static mesh component references.</summary>
	public TArray<string> LightmapTextureNames;
}
