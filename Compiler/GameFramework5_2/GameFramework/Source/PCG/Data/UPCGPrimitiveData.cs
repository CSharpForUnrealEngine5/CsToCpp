namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGPrimitiveData.h")]
public partial class UPCGPrimitiveData : UPCGSpatialDataWithPointCache {
	public static UClass StaticClass() {return default;}
	///<summary>~End UPCGSpatialDataWithPointCache implementation</summary>
	public FVector VoxelSize;
	///<summary>Primitive</summary>
	public TWeakObjectPtr<UPrimitiveComponent> Primitive;
	///<summary>CachedBounds</summary>
	public FBox CachedBounds;
	///<summary>CachedStrictBounds</summary>
	public FBox CachedStrictBounds;
}
