namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Properties. This class reflects the parameters in FSmoothFillOptions, but is decorated to allow use in the UI system.</summary>
[CppInclude("HoleFillTool.h")]
public partial class USmoothHoleFillProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Allow smoothing and remeshing of triangles outside of the fill region</summary>
	public bool bConstrainToHoleInterior;
	///<summary>Number of vertex rings outside of the fill region to allow remeshing</summary>
	public int RemeshingExteriorRegionWidth;
	///<summary>Number of vertex rings outside of the fill region to perform smoothing</summary>
	public int SmoothingExteriorRegionWidth;
	///<summary>Number of vertex rings away from the fill region boundary to constrain smoothing</summary>
	public int SmoothingInteriorRegionWidth;
	///<summary>Desired Smoothness. This is not a linear quantity, but larger numbers produce smoother results</summary>
	public float InteriorSmoothness;
	///<summary>Relative triangle density of fill region</summary>
	public double FillDensityScalar;
	///<summary>Whether to project to the original mesh during post-smooth remeshing. This can be expensive on large meshes with</summary>
	public bool bProjectDuringRemesh;
}
