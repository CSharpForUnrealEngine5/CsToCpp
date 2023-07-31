#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithLightActorElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithLightActorElement : UDatasmithActorElement {
	///<summary>Return true on light enabled, false otherwise</summary>
	public  bool IsEnabled() { return default; }
	///<summary>Set enable property of the light</summary>
	public  void SetEnabled(bool bIsEnabled) {}
	///<summary>Get light intensity</summary>
	public  float GetIntensity() { return default; }
	///<summary>Set light intensity</summary>
	public  void SetIntensity(float Intensity) {}
	///<summary>Get light color on linear mode</summary>
	public  FLinearColor GetColor() { return default; }
	///<summary>Set light color on linear mode</summary>
	public  void SetColor(FLinearColor Color) {}
	///<summary>Get the light temperature in Kelvin</summary>
	public  float GetTemperature() { return default; }
	///<summary>Set the light temperature in Kelvin</summary>
	public  void SetTemperature(float Temperature) {}
	///<summary>Get if the light color is controlled by temperature</summary>
	public  bool GetUseTemperature() { return default; }
	///<summary>Set if the light color is controlled by temperature</summary>
	public  void SetUseTemperature(bool bUseTemperature) {}
	///<summary>Get the path of the Ies definition file</summary>
	public  string GetIesFile() { return default; }
	///<summary>Set the path of the Ies definition file</summary>
	public  void SetIesFile(string IesFile) {}
	///<summary>Set if this light is controlled by Ies definition file</summary>
	public  bool GetUseIes() { return default; }
	///<summary>Get if this light is controlled by Ies definition file</summary>
	public  void SetUseIes(bool bUseIes) {}
	///<summary>Get the Ies brightness multiplier</summary>
	public  float GetIesBrightnessScale() { return default; }
	///<summary>Set the Ies brightness multiplier</summary>
	public  void SetIesBrightnessScale(float IesBrightnessScale) {}
	///<summary>Get if the emissive amount of the ies is controlled by the brightness scale</summary>
	public  bool GetUseIesBrightness() { return default; }
	///<summary>Set if the emissive amount of the ies is controlled by the brightness scale</summary>
	public  void SetUseIesBrightness(bool bUseIesBrightness) {}
}
