namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithPostProcessElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithPostProcessElement : UDatasmithObjectElement {
	public static UClass StaticClass() {return default;}
	///<summary>Get color filter temperature in Kelvin</summary>
	public float GetTemperature() { return default; }
	///<summary>Set color filter temperature in Kelvin</summary>
	public void SetTemperature(float Temperature) {}
	///<summary>Set color filter in linear color scale</summary>
	public FLinearColor GetColorFilter() { return default; }
	///<summary>Get color filter in linear color scale</summary>
	public void SetColorFilter(FLinearColor ColorFilter) {}
	///<summary>Get vignette amount</summary>
	public float GetVignette() { return default; }
	///<summary>Set vignette amount</summary>
	public void SetVignette(float Vignette) {}
	///<summary>Get depth of field multiplier</summary>
	public float GetDof() { return default; }
	///<summary>Set depth of field multiplier</summary>
	public void SetDof(float Dof) {}
	///<summary>Get motion blur multiplier</summary>
	public float GetMotionBlur() { return default; }
	///<summary>Set motion blur multiplier</summary>
	public void SetMotionBlur(float MotionBlur) {}
	///<summary>Get color saturation</summary>
	public float GetSaturation() { return default; }
	///<summary>Set color saturation</summary>
	public void SetSaturation(float Saturation) {}
	///<summary>Get camera ISO</summary>
	public float GetCameraISO() { return default; }
	///<summary>Set camera ISO</summary>
	public void SetCameraISO(float CameraISO) {}
	///<summary>Get camera shutter speed in 1/seconds (ie: 60 = 1/60s)</summary>
	public float GetCameraShutterSpeed() { return default; }
	///<summary>Set camera shutter speed in 1/seconds (ie: 60 = 1/60s)</summary>
	public void SetCameraShutterSpeed(float CameraShutterSpeed) {}
}
