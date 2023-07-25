#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/TouchInterface.h")]
///<summary>Defines an interface by which touch input can be controlled using any number of buttons and virtual joysticks</summary>
public partial class UTouchInterface : UObject {
// TouchInterface
	public TArray<FTouchInputControl> Controls;
	public float ActiveOpacity;
	public float InactiveOpacity;
	public float TimeUntilDeactive;
	public float TimeUntilReset;
	public float ActivationDelay;
	public bool bPreventRecenter;
	public float StartupDelay;
}
