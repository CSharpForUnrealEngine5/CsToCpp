#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGPrimitiveData.h")]
public partial class UPCGPrimitiveData : UPCGSpatialDataWithPointCache {
// PCGPrimitiveData
	public FVector VoxelSize;
	public TWeakObjectPtr<UPrimitiveComponent> Primitive;
	public FBox CachedBounds;
	public FBox CachedStrictBounds;
}
