#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputSubsystem.h")]
public partial class UCommonInputSubsystem : ULocalPlayerSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>IsInputMethodActive</summary>
	public  bool IsInputMethodActive(ECommonInputType InputMethod) { return default; }
	///<summary>The current input type based on the last input received on the device.</summary>
	public  ECommonInputType GetCurrentInputType() { return default; }
	///<summary>The default input type for the current platform.</summary>
	public  ECommonInputType GetDefaultInputType() { return default; }
	///<summary>SetCurrentInputType</summary>
	public  void SetCurrentInputType(ECommonInputType NewInputType) {}
	///<summary>GetCurrentGamepadName</summary>
	public  string GetCurrentGamepadName() { return default; }
	///<summary>SetGamepadInputType</summary>
	public  void SetGamepadInputType(string InGamepadInputType) {}
	///<summary>IsUsingPointerInput</summary>
	public  bool IsUsingPointerInput() { return default; }
	///<summary>Should display indicators for the current input device on screen.  This is needed when capturing videos, but we don&#39;t want to reveal the capture source device.</summary>
	public  bool ShouldShowInputKeys() { return default; }
	///<summary>BroadcastInputMethodChanged</summary>
	public  void BroadcastInputMethodChanged() {}
	///<summary>OnInputMethodChanged</summary>
	public FInputMethodChangedDelegate OnInputMethodChanged;
	///<summary>NumberOfInputMethodChangesRecently</summary>
	public int NumberOfInputMethodChangesRecently;
	///<summary>LastInputMethodChangeTime</summary>
	public double LastInputMethodChangeTime;
	///<summary>LastTimeInputMethodThrashingBegan</summary>
	public double LastTimeInputMethodThrashingBegan;
	///<summary>LastInputType</summary>
	public ECommonInputType LastInputType;
	///<summary>CurrentInputType</summary>
	public ECommonInputType CurrentInputType;
	///<summary>GamepadInputType</summary>
	public string GamepadInputType;
	///<summary>CurrentInputLocks</summary>
	public TMap<string,ECommonInputType> CurrentInputLocks;
	///<summary>ActionDomainTable</summary>
	public UCommonInputActionDomainTable ActionDomainTable;
	///<summary>Is the current click simulated by the gamepad&#39;s face button down/right (platform dependent)</summary>
	public bool bIsGamepadSimulatedClick;
}
