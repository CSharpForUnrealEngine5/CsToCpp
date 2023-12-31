namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/StereoLayerComponent.h")]
public partial class UStereoLayerShapeCylinder : UStereoLayerShape {
	public static UClass StaticClass() {return default;}
	///<summary>Radial size of the rendered stereo layer cylinder *</summary>
	public float Radius;
	///<summary>Arc angle for the stereo layer cylinder *</summary>
	public float OverlayArc;
	///<summary>Height of the stereo layer cylinder *</summary>
	public int Height;
	///<summary>SetRadius</summary>
	public void SetRadius(float InRadius) {}
	///<summary>SetOverlayArc</summary>
	public void SetOverlayArc(float InOverlayArc) {}
	///<summary>SetHeight</summary>
	public void SetHeight(int InHeight) {}
}
