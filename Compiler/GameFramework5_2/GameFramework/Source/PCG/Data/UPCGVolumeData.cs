namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGVolumeData.h")]
public partial class UPCGVolumeData : UPCGSpatialDataWithPointCache {
	public static UClass StaticClass() {return default;}
	///<summary>~End UPCGSpatialDataWithPointCache interface</summary>
	public FVector VoxelSize;
	///<summary>Volume</summary>
	public TWeakObjectPtr<AVolume> Volume;
	///<summary>Bounds</summary>
	public FBox Bounds;
	///<summary>StrictBounds</summary>
	public FBox StrictBounds;
}
