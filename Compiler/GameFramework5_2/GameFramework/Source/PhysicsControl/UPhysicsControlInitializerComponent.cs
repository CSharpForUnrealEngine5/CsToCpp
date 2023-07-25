#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlActor.h")]
public partial class UPhysicsControlInitializerComponent : USceneComponent {
// PhysicsControlInitializerComponent
	public void CreateControls(UObject PhysicsControlComponent) {}
	public FInitialCharacterControls InitialCharacterControls;
	public TMap<string,FInitialPhysicsControl> InitialControls;
	public TMap<string,FInitialBodyModifier> InitialBodyModifiers;
	public bool bCreateControlsAtBeginPlay;
}
