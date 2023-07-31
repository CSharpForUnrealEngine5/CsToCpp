#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A light component which emits light from a rectangle.</summary>
[CppInclude("Components/RectLightComponent.h")]
public partial class URectLightComponent : ULocalLightComponent {
	///<summary>Width of light source rect.</summary>
	public float SourceWidth;
	///<summary>Height of light source rect.</summary>
	public float SourceHeight;
	///<summary>Angle of barn door attached to the light source rect.</summary>
	public float BarnDoorAngle;
	///<summary>Length of barn door attached to the light source rect.</summary>
	public float BarnDoorLength;
	///<summary>Texture mapped to the light source rectangle</summary>
	public UTexture SourceTexture;
	///<summary>SetSourceTexture</summary>
	public  void SetSourceTexture(UTexture NewValue) {}
	///<summary>SetSourceWidth</summary>
	public  void SetSourceWidth(float NewValue) {}
	///<summary>SetSourceHeight</summary>
	public  void SetSourceHeight(float NewValue) {}
	///<summary>SetBarnDoorAngle</summary>
	public  void SetBarnDoorAngle(float NewValue) {}
	///<summary>SetBarnDoorLength</summary>
	public  void SetBarnDoorLength(float NewValue) {}
}
