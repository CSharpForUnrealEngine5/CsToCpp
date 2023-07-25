#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlActor.h")]
///<summary>Actor that holds a PhysicsControlComponent which is then used to apply controls/body modifiers to</summary>
public partial class APhysicsControlActor : AActor {
// PhysicsControlActor
	public UPhysicsControlComponent ControlComponent;
	public UPhysicsControlInitializerComponent ControlInitializerComponent;
}
