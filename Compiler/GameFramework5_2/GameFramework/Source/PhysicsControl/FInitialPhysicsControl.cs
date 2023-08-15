namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that determines a Physics Control used during initialization of the physics control actor</summary>
[CppInclude("PhysicsControlActor.h")]
public partial struct FInitialPhysicsControl {
	public AActor ParentActor;
	public FName ParentMeshComponentName;
	public FName ParentBoneName;
	public AActor ChildActor;
	public FName ChildMeshComponentName;
	public FName ChildBoneName;
	public FPhysicsControlData ControlData;
	public FPhysicsControlMultiplier ControlMultiplier;
	public FPhysicsControlTarget ControlTarget;
	public FPhysicsControlSettings ControlSettings;
}
