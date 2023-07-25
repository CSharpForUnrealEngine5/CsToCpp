#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HoleFillTool.h")]
///<summary>* Properties. This class reflects the parameters in FSmoothFillOptions, but is decorated to allow use in the UI system.</summary>
public partial class USmoothHoleFillProperties : UInteractiveToolPropertySet {
// SmoothHoleFillProperties
	public bool bConstrainToHoleInterior;
	public int RemeshingExteriorRegionWidth;
	public int SmoothingExteriorRegionWidth;
	public int SmoothingInteriorRegionWidth;
	public float InteriorSmoothness;
	public double FillDensityScalar;
	public bool bProjectDuringRemesh;
}
