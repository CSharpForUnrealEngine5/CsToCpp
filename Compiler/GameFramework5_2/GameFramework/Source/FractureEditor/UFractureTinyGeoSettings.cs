#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolFixTinyGeo.h")]
///<summary>Settings controlling how geometry is selected and merged into neighboring geometry</summary>
public partial class UFractureTinyGeoSettings : UFractureToolSettings {
// FractureTinyGeoSettings
	public ENeighborSelectionMethod NeighborSelection;
	public EUseBoneSelection UseBoneSelection;
	public EGeometrySelectionMethod SelectionMethod;
	public double MinVolumeCubeRoot;
	public double RelativeVolume;
}
