#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlActor.h")]
public partial class UPhysicsControlInitializerComponent : USceneComponent {
	///<summary>This creates all the controls specified in the Initial properties. You can call it explicitly,</summary>
	public  void CreateControls(UPhysicsControlComponent PhysicsControlComponent) {}
	///<summary>This can be filled in to automatically create whole-character controls (by specifying limbs etc) for</summary>
	public FInitialCharacterControls InitialCharacterControls;
	///<summary>This can be filled in to automatically create controls during the BeginPlay event. If a control</summary>
	public TMap<string,FInitialPhysicsControl> InitialControls;
	///<summary>This can be filled in to automatically create body modifiers during the BeginPlay event. If a body modifier</summary>
	public TMap<string,FInitialBodyModifier> InitialBodyModifiers;
	///<summary>If set, then CreateControls will be called in our BeginPlay event, attempting to find a</summary>
	public bool bCreateControlsAtBeginPlay;
}
