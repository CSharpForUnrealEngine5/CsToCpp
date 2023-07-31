#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor that holds a PhysicsControlComponent which is then used to apply controls/body modifiers to</summary>
[CppInclude("PhysicsControlActor.h")]
public partial class APhysicsControlActor : AActor {
	///<summary>ControlComponent</summary>
	public UPhysicsControlComponent ControlComponent;
	///<summary>ControlInitializerComponent</summary>
	public UPhysicsControlInitializerComponent ControlInitializerComponent;
}
