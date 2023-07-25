#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCache.h")]
///<summary>A Geometry Cache is a piece/set of geometry that consists of individual Mesh/Transformation samples.</summary>
public partial class UGeometryCache : UObject {
// GeometryCache
	public UAssetImportData AssetImportData;
	public UThumbnailInfo ThumbnailInfo;
	public TArray<UMaterialInterface> Materials;
	public TArray<UGeometryCacheTrack> Tracks;
	public int StartFrame;
	public int EndFrame;
	public ulong Hash;
}
