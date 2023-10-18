namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings controlling how geometry is selected</summary>
[CppInclude("FractureToolSelection.h")]
public partial class UFractureSelectionSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>MouseSelectionMethod</summary>
	public EMouseSelectionMethod MouseSelectionMethod;
	///<summary>What values to use when filtering by volume.  Note all values are presented as cube roots to give more intuitive scales (e.g., to select bones with volume less than a 10x10x10 cube, choose CubeRootOfVolume and MaxVolume=10, rather than needing to multiply out to 1000)</summary>
	public EVolumeSelectionMethod VolumeSelectionMethod;
	///<summary>How to update the selection from the filter</summary>
	public ESelectionOperation SelectionOperation;
	///<summary>Sets the minimum volume (as computed by the Volume Selection Method) that should be included in the filter</summary>
	public double MinVolume;
	///<summary>Sets the maximum volume (as computed by the Volume Selection Method) that should be included in the filter</summary>
	public double MaxVolume;
	///<summary>Sets the minimum volume (as computed by the Volume Selection Method) that should be included in the filter</summary>
	public double MinVolumeFrac;
	///<summary>Sets the maximum volume (as computed by the Volume Selection Method) that should be included in the filter</summary>
	public double MaxVolumeFrac;
	///<summary>Fraction of bones to keep in the selection: If less than 1, bones will be randomly excluded from the selection filter</summary>
	public double KeepFraction;
	///<summary>Seed to use for randomization when deciding which bones to keep w/ the Keep Fraction</summary>
	public int RandomSeed;
}
