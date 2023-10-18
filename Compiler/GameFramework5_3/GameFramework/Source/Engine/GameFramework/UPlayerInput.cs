namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object within PlayerController that processes player input.</summary>
[CppInclude("GameFramework/PlayerInput.h")]
public partial class UPlayerInput : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Generic bindings of keys to Exec()-compatible strings for development purposes only</summary>
	public TArray<FKeyBind> DebugExecBindings;
	///<summary>List of Axis Mappings that have been inverted</summary>
	public TArray<FName> InvertedAxis;
	///<summary>Sets both X and Y axis sensitivity to the supplied value.</summary>
	public void SetMouseSensitivity(float Sensitivity) {}
	///<summary>Exec function to add a debug exec command</summary>
	public void SetBind(FName BindName,string Command) {}
	///<summary>Exec function to invert an axis key</summary>
	public void InvertAxisKey(FKey AxisKey) {}
	///<summary>Exec function to invert an axis mapping</summary>
	public void InvertAxis(FName AxisName) {}
	///<summary>Exec function to reset mouse smoothing values</summary>
	public void ClearSmoothing() {}
	///<summary>Return&#39;s this object casted to a player controller. This can be null if there is no player controller.</summary>
	public APlayerController GetOuterAPlayerController() { return default; }
}
