#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputSubsystem.h")]
public partial class UCommonInputSubsystem : ULocalPlayerSubsystem {
// CommonInputSubsystem
	public bool IsInputMethodActive(ECommonInputType InputMethod) { return default; }
	public ECommonInputType GetCurrentInputType() { return default; }
	public ECommonInputType GetDefaultInputType() { return default; }
	public void SetCurrentInputType(ECommonInputType NewInputType) {}
	public string GetCurrentGamepadName() { return default; }
	public void SetGamepadInputType(string InGamepadInputType) {}
	public bool IsUsingPointerInput() { return default; }
	public bool ShouldShowInputKeys() { return default; }
	public void BroadcastInputMethodChanged() {}
	public FInputMethodChangedDelegate OnInputMethodChanged;
	public int NumberOfInputMethodChangesRecently;
	public double LastInputMethodChangeTime;
	public double LastTimeInputMethodThrashingBegan;
	public ECommonInputType LastInputType;
	public ECommonInputType CurrentInputType;
	public string GamepadInputType;
	public TMap<string,ECommonInputType> CurrentInputLocks;
	public UCommonInputActionDomainTable ActionDomainTable;
	public bool bIsGamepadSimulatedClick;
}
