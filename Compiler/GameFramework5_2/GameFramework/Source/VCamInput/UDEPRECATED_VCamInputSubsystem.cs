#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamInputSubsystem.h")]
public partial class UDEPRECATED_VCamInputSubsystem : UEngineSubsystem {
// VCamInputSubsystem
	public void SetShouldConsumeGamepadInput(bool bInShouldConsumeGamepadInput) {}
	public bool GetShouldConsumeGamepadInput() { return default; }
	public void BindKeyDownEvent(FKey Key,FKeyInputDelegate Delegate) {}
	public void BindKeyUpEvent(FKey Key,FKeyInputDelegate Delegate) {}
	public void BindAnalogEvent(FKey Key,FAnalogInputDelegate Delegate) {}
	public void BindMouseMoveEvent(FPointerInputDelegate Delegate) {}
	public void BindMouseButtonDownEvent(FKey Key,FPointerInputDelegate Delegate) {}
	public void BindMouseButtonUpEvent(FKey Key,FPointerInputDelegate Delegate) {}
	public void BindMouseDoubleClickEvent(FKey Key,FPointerInputDelegate Delegate) {}
	public void BindMouseWheelEvent(FPointerInputDelegate Delegate) {}
}
