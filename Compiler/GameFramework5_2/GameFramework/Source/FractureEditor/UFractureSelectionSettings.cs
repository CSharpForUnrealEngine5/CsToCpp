#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolSelection.h")]
///<summary>Settings controlling how geometry is selected</summary>
public partial class UFractureSelectionSettings : UFractureToolSettings {
// FractureSelectionSettings
	public EMouseSelectionMethod MouseSelectionMethod;
	public EVolumeSelectionMethod VolumeSelectionMethod;
	public ESelectionOperation SelectionOperation;
	public double MinVolume;
	public double MaxVolume;
	public double MinVolumeFrac;
	public double MaxVolumeFrac;
	public double KeepFraction;
	public int RandomSeed;
}
