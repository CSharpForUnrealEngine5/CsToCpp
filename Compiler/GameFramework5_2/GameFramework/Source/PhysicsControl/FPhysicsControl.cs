#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlData.h")]
///<summary>Structure that determines a "control" - this contains all the information needed to drive (with spring-dampers)</summary>
public partial struct FPhysicsControl {
// PhysicsControl
	public UMeshComponent ParentMeshComponent;
	public string ParentBoneName;
	public UMeshComponent ChildMeshComponent;
	public string ChildBoneName;
	public FPhysicsControlData ControlData;
	public FPhysicsControlMultiplier ControlMultiplier;
	public FPhysicsControlTarget ControlTarget;
	public FPhysicsControlSettings ControlSettings;
}
