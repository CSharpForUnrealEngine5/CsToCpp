#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/RectLightComponent.h")]
///<summary>A light component which emits light from a rectangle.</summary>
public partial class URectLightComponent : ULocalLightComponent {
// RectLightComponent
	public float SourceWidth;
	public float SourceHeight;
	public float BarnDoorAngle;
	public float BarnDoorLength;
	public UTexture SourceTexture;
	public void SetSourceTexture(UObject NewValue) {}
	public void SetSourceWidth(float NewValue) {}
	public void SetSourceHeight(float NewValue) {}
	public void SetBarnDoorAngle(float NewValue) {}
	public void SetBarnDoorLength(float NewValue) {}
}
