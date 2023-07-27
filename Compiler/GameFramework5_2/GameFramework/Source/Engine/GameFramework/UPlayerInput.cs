#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerInput.h")]
///<summary>Object within PlayerController that processes player input.</summary>
public partial class UPlayerInput : UObject {
// PlayerInput
	public TArray<FKeyBind> DebugExecBindings;
	public TArray<string> InvertedAxis;
	public  void SetMouseSensitivity(float Sensitivity) {}
	public  void SetBind(string BindName,string Command) {}
	public  void InvertAxisKey(FKey AxisKey) {}
	public  void InvertAxis(string AxisName) {}
	public  void ClearSmoothing() {}
	public  APlayerController GetOuterAPlayerController() { return default; }
}
