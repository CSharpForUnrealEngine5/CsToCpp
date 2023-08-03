#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionDebugDrawComponent.h")]
public partial class UGeometryCollectionDebugDrawComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Singleton actor, containing the debug draw properties. Automatically populated at play time unless explicitly set.</summary>
	public AGeometryCollectionDebugDrawActor GeometryCollectionDebugDrawActor_DEPRECATED;
	///<summary>Level Set singleton actor, containing the Render properties. Automatically populated at play time unless explicitly set.</summary>
	public AGeometryCollectionRenderLevelSetActor GeometryCollectionRenderLevelSetActor;
}
