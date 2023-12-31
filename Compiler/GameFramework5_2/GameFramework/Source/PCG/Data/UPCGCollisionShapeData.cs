namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGCollisionShapeData.h")]
public partial class UPCGCollisionShapeData : UPCGSpatialDataWithPointCache {
	public static UClass StaticClass() {return default;}
	///<summary>Transform</summary>
	public FTransform Transform;
	///<summary>CachedBounds</summary>
	public FBox CachedBounds;
	///<summary>CachedStrictBounds</summary>
	public FBox CachedStrictBounds;
}
