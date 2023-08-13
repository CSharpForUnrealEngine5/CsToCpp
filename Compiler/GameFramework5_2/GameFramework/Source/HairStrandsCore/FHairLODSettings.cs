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
