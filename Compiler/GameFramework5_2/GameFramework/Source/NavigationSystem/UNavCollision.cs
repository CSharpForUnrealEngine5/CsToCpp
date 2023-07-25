#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavCollision.h")]
public partial class UNavCollision : UNavCollisionBase {
// NavCollision
	public TArray<FNavCollisionCylinder> CylinderCollision;
	public TArray<FNavCollisionBox> BoxCollision;
	public UClass AreaClass;
	public bool bGatherConvexGeometry;
	public bool bCreateOnClient;
}
