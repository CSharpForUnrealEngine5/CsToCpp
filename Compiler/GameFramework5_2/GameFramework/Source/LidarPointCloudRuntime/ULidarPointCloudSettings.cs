#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LidarPointCloudSettings.h")]
public partial class ULidarPointCloudSettings : UObject {
// LidarPointCloudSettings
	public ELidarPointCloudDuplicateHandling DuplicateHandling;
	public float MaxDistanceForDuplicate;
	public int MaxBucketSize;
	public int NodeGridResolution;
	public int MultithreadingInsertionBatchSize;
	public bool bUseAsyncImport;
	public bool bPrioritizeActiveViewport;
	public float CachedNodeLifetime;
	public bool bReleaseAssetAfterSaving;
	public bool bReleaseAssetAfterCooking;
	public bool bUseRenderDataSmoothing;
	public float RenderDataSmoothingMaxFrametime;
	public bool bUseFastRendering;
	public bool bEnableLidarRayTracing;
	public int MeshingBatchSize;
	public bool bAutoCenterOnImport;
	public bool bAutoCalculateNormalsOnImport;
	public bool bAutoBuildCollisionOnImport;
	public float ImportScale;
	public float ExportScale;
}
