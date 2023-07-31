#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Geometry Cache is a piece/set of geometry that consists of individual Mesh/Transformation samples.</summary>
[CppInclude("GeometryCache.h")]
public partial class UGeometryCache : UObject {
	///<summary>Importing data and options used for this Geometry cache object</summary>
	public UAssetImportData AssetImportData;
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
	///<summary>Materials</summary>
	public TArray<UMaterialInterface> Materials;
	///<summary>GeometryCache track defining the samples/geometry data for this GeomCache instance</summary>
	public TArray<UGeometryCacheTrack> Tracks;
	///<summary>StartFrame</summary>
	public int StartFrame;
	///<summary>EndFrame</summary>
	public int EndFrame;
	///<summary>Hash</summary>
	public ulong Hash;
}
