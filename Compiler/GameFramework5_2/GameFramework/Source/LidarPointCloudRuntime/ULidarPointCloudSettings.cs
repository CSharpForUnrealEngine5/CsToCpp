#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudSettings.h")]
public partial class ULidarPointCloudSettings : UObject {
	///<summary>Determines how to handle duplicate points (distance &lt; 0.0001).</summary>
	public ELidarPointCloudDuplicateHandling DuplicateHandling;
	///<summary>Maximum distance between points, within which they are considered to be duplicates</summary>
	public float MaxDistanceForDuplicate;
	///<summary>Maximum number of unallocated points to keep inside the node before they need to be converted in to a full child node.</summary>
	public int MaxBucketSize;
	///<summary>Virtual grid resolution to divide the node into.</summary>
	public int NodeGridResolution;
	///<summary>Determines the maximum amount of points to process in a single batch when using multi-threading.</summary>
	public int MultithreadingInsertionBatchSize;
	///<summary>Enabling this will allow editor to import the point clouds in the background, without blocking the main thread.</summary>
	public bool bUseAsyncImport;
	///<summary>Enabling this will allocate larger portion of the available point budget to the viewport with focus.</summary>
	public bool bPrioritizeActiveViewport;
	///<summary>Sets how long the nodes wil be kept in RAM after they are no longer visible.</summary>
	public float CachedNodeLifetime;
	///<summary>Enabling this will automatically release memory used by the asset once it&#39;s saved</summary>
	public bool bReleaseAssetAfterSaving;
	///<summary>Enabling this will automatically release memory used by the asset once it&#39;s cooked</summary>
	public bool bReleaseAssetAfterCooking;
	///<summary>If enabled, the render data generation will be spread across multiple frames to avoid freezes</summary>
	public bool bUseRenderDataSmoothing;
	///<summary>If UseRenderDataSmoothing is enabled, this will determine how much of the frame time can be spent on render data generation.</summary>
	public float RenderDataSmoothingMaxFrametime;
	///<summary>Enabling this will greatly improve runtime performance at a cost of quadrupling VRAM use</summary>
	public bool bUseFastRendering;
	///<summary>If enabled, Lidar assets will become visible to Ray Tracing.</summary>
	public bool bEnableLidarRayTracing;
	///<summary>Affects the size of per-thread data for the meshing algorithm.</summary>
	public int MeshingBatchSize;
	///<summary>Automatically centers the cloud on import.</summary>
	public bool bAutoCenterOnImport;
	///<summary>If enabled, the assets will automatically calculate normals upon their successful import.</summary>
	public bool bAutoCalculateNormalsOnImport;
	///<summary>If enabled, the assets will automatically build collision upon their successful import.</summary>
	public bool bAutoBuildCollisionOnImport;
	///<summary>Scale to apply during import</summary>
	public float ImportScale;
	///<summary>Scale to apply during export. In most cases, this should be equal to an inverted ImportScale</summary>
	public float ExportScale;
}
