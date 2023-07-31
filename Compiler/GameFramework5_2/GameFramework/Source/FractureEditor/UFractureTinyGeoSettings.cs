#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings controlling how geometry is selected and merged into neighboring geometry</summary>
[CppInclude("FractureToolFixTinyGeo.h")]
public partial class UFractureTinyGeoSettings : UFractureToolSettings {
	///<summary>NeighborSelection</summary>
	public ENeighborSelectionMethod NeighborSelection;
	///<summary>Options for using the current bone selection</summary>
	public EUseBoneSelection UseBoneSelection;
	///<summary>SelectionMethod</summary>
	public EGeometrySelectionMethod SelectionMethod;
	///<summary>If volume is less than this value cubed, geometry should be merged into neighbors -- i.e. a value of 2 merges geometry smaller than a 2x2x2 cube</summary>
	public double MinVolumeCubeRoot;
	///<summary>If cube root of volume relative to the overall shape&#39;s cube root of volume is less than this, the geometry should be merged into its neighbors.</summary>
	public double RelativeVolume;
}
