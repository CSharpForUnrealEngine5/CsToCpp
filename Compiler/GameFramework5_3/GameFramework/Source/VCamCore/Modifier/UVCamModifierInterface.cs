namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modifier/VCamModifierInterface.h")]
public partial class UVCamModifierInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Function used to monitor the status of a VCam. If it changed, function will be triggered.</summary>
	public void OnVCamComponentChanged(UVCamComponent VCam) {}
}
