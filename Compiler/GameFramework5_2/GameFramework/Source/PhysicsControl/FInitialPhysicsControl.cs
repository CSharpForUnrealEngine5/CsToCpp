namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that determines a Physics Control used during initialization of the physics control actor</summary>
[CppInclude("PhysicsControlActor.h")]
public partial struct FInitialPhysicsControl {
	public AActor ParentActor;
	public string ParentMeshComponentName;
	public string ParentBoneName;
	public AActor ChildActor;
	public string ChildMeshComponentName;
	public string ChildBoneName;
	public FPhysicsControlData ControlData;
	public FPhysicsControlMultiplier ControlMultiplier;
	public FPhysicsControlTarget ControlTarget;
	public FPhysicsControlSettings ControlSettings;
}
