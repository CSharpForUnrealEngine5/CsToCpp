namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that determines a &quot;control&quot; - this contains all the information needed to drive (with spring-dampers)</summary>
[CppInclude("PhysicsControlData.h")]
public partial struct FPhysicsControl {
	public UMeshComponent ParentMeshComponent;
	public FName ParentBoneName;
	public UMeshComponent ChildMeshComponent;
	public FName ChildBoneName;
	public FPhysicsControlData ControlData;
	public FPhysicsControlMultiplier ControlMultiplier;
	public FPhysicsControlTarget ControlTarget;
	public FPhysicsControlSettings ControlSettings;
}
