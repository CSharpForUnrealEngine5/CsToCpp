#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modifier/VCamModifierInterface.h")]
public partial class UVCamModifierInterface : UInterface {
	///<summary>Function used to monitor the status of a VCam. If it changed, function will be triggered.</summary>
	public  void OnVCamComponentChanged(UVCamComponent VCam) {}
}
