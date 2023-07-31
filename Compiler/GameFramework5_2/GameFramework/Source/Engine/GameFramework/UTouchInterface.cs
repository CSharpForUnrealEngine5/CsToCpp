#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines an interface by which touch input can be controlled using any number of buttons and virtual joysticks</summary>
[CppInclude("GameFramework/TouchInterface.h")]
public partial class UTouchInterface : UObject {
	///<summary>Controls</summary>
	public TArray<FTouchInputControl> Controls;
	///<summary>Opacity (0.0 - 1.0) of all controls while any control is active</summary>
	public float ActiveOpacity;
	///<summary>Opacity (0.0 - 1.0) of all controls while no controls are active</summary>
	public float InactiveOpacity;
	///<summary>How long after user interaction will all controls fade out to Inactive Opacity</summary>
	public float TimeUntilDeactive;
	///<summary>How long after going inactive will controls reset/recenter themselves (0.0 will disable this feature)</summary>
	public float TimeUntilReset;
	///<summary>How long after joystick enabled for touch (0.0 will disable this feature)</summary>
	public float ActivationDelay;
	///<summary>Whether to prevent joystick re-center</summary>
	public bool bPreventRecenter;
	///<summary>Delay at startup before virtual joystick is drawn</summary>
	public float StartupDelay;
}
