#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WindDirectionalSourceComponent.h")]
///<summary>Component that provides a directional wind source. Only affects SpeedTree assets.</summary>
public partial class UWindDirectionalSourceComponent : USceneComponent {
// WindDirectionalSourceComponent
	public float Strength;
	public float Speed;
	public float MinGustAmount;
	public float MaxGustAmount;
	public float Radius;
	public bool bPointWind;
	public  void SetStrength(float InNewStrength) {}
	public  void SetSpeed(float InNewSpeed) {}
	public  void SetMinimumGustAmount(float InNewMinGust) {}
	public  void SetMaximumGustAmount(float InNewMaxGust) {}
	public  void SetRadius(float InNewRadius) {}
	public  void SetWindType(EWindSourceType InNewType) {}
}
