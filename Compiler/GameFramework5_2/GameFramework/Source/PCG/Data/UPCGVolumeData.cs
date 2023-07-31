#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGVolumeData.h")]
public partial class UPCGVolumeData : UPCGSpatialDataWithPointCache {
	///<summary>~End UPCGSpatialDataWithPointCache interface</summary>
	public FVector VoxelSize;
	///<summary>Volume</summary>
	public TWeakObjectPtr<AVolume> Volume;
	///<summary>Bounds</summary>
	public FBox Bounds;
	///<summary>StrictBounds</summary>
	public FBox StrictBounds;
}
