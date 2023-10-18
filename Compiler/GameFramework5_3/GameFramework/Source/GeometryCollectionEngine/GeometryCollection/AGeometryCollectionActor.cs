namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionActor.h")]
public partial class AGeometryCollectionActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>GeometryCollectionComponent</summary>
	public UGeometryCollectionComponent GeometryCollectionComponent;
	///<summary>GeometryCollectionDebugDrawComponent_DEPRECATED</summary>
	public UGeometryCollectionDebugDrawComponent GeometryCollectionDebugDrawComponent_DEPRECATED;
	///<summary>RaycastSingle</summary>
	public bool RaycastSingle(FVector Start,FVector End,FHitResult OutHit) { return default; }
}
