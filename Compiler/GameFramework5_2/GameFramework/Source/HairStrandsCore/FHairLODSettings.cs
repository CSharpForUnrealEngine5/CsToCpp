#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetInterpolation.h")]
public partial struct FHairLODSettings {
	public float CurveDecimation;
	public float VertexDecimation;
	public float AngularThreshold;
	public float ScreenSize;
	public float ThicknessScale;
	public bool bVisible;
	public EGroomGeometryType GeometryType;
	public EGroomBindingType BindingType;
	public EGroomOverrideType Simulation;
	public EGroomOverrideType GlobalInterpolation;
}
