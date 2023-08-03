#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavCollision.h")]
public partial class UNavCollision : UNavCollisionBase {
	public static UClass StaticClass() {return default;}
	///<summary>list of nav collision cylinders</summary>
	public TArray<FNavCollisionCylinder> CylinderCollision;
	///<summary>list of nav collision boxes</summary>
	public TArray<FNavCollisionBox> BoxCollision;
	///<summary>navigation area type that will be use when this static mesh is used as</summary>
	public UClass AreaClass;
	///<summary>If set, convex collisions will be exported offline for faster runtime navmesh building (increases memory usage)</summary>
	public bool bGatherConvexGeometry;
	///<summary>If false, will not create nav collision when connecting as a client</summary>
	public bool bCreateOnClient;
}
