#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that provides a directional wind source. Only affects SpeedTree assets.</summary>
[CppInclude("Components/WindDirectionalSourceComponent.h")]
public partial class UWindDirectionalSourceComponent : USceneComponent {
	///<summary>Strength</summary>
	public float Strength;
	///<summary>Speed</summary>
	public float Speed;
	///<summary>MinGustAmount</summary>
	public float MinGustAmount;
	///<summary>MaxGustAmount</summary>
	public float MaxGustAmount;
	///<summary>Radius</summary>
	public float Radius;
	///<summary>bPointWind</summary>
	public bool bPointWind;
	///<summary>Sets the strength of the generated wind</summary>
	public  void SetStrength(float InNewStrength) {}
	///<summary>Sets the windspeed of the generated wind</summary>
	public  void SetSpeed(float InNewSpeed) {}
	///<summary>Set minimum deviation for wind gusts</summary>
	public  void SetMinimumGustAmount(float InNewMinGust) {}
	///<summary>Set maximum deviation for wind gusts</summary>
	public  void SetMaximumGustAmount(float InNewMaxGust) {}
	///<summary>Set the effect radius for point wind</summary>
	public  void SetRadius(float InNewRadius) {}
	///<summary>Set the type of wind generator to use</summary>
	public  void SetWindType(EWindSourceType InNewType) {}
}
