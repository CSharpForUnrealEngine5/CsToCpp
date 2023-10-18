namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamInputSubsystem.h")]
public partial class UDEPRECATED_VCamInputSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>SetShouldConsumeGamepadInput</summary>
	public void SetShouldConsumeGamepadInput(bool bInShouldConsumeGamepadInput) {}
	///<summary>GetShouldConsumeGamepadInput</summary>
	public bool GetShouldConsumeGamepadInput() { return default; }
	///<summary>BindKeyDownEvent</summary>
	public void BindKeyDownEvent(FKey Key,FKeyInputDelegate Delegate) {}
	///<summary>BindKeyUpEvent</summary>
	public void BindKeyUpEvent(FKey Key,FKeyInputDelegate Delegate) {}
	///<summary>BindAnalogEvent</summary>
	public void BindAnalogEvent(FKey Key,FAnalogInputDelegate Delegate) {}
	///<summary>BindMouseMoveEvent</summary>
	public void BindMouseMoveEvent(FPointerInputDelegate Delegate) {}
	///<summary>BindMouseButtonDownEvent</summary>
	public void BindMouseButtonDownEvent(FKey Key,FPointerInputDelegate Delegate) {}
	///<summary>BindMouseButtonUpEvent</summary>
	public void BindMouseButtonUpEvent(FKey Key,FPointerInputDelegate Delegate) {}
	///<summary>BindMouseDoubleClickEvent</summary>
	public void BindMouseDoubleClickEvent(FKey Key,FPointerInputDelegate Delegate) {}
	///<summary>BindMouseWheelEvent</summary>
	public void BindMouseWheelEvent(FPointerInputDelegate Delegate) {}
}
