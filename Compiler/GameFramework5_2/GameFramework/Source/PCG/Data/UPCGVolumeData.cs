#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGVolumeData.h")]
public partial class UPCGVolumeData : UPCGSpatialDataWithPointCache {
// PCGVolumeData
	public FVector VoxelSize;
	public TWeakObjectPtr<AVolume> Volume;
	public FBox Bounds;
	public FBox StrictBounds;
}
