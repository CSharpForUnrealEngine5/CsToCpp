namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings controlling how geometry is selected and merged into neighboring geometry</summary>
[CppInclude("FractureToolFixTinyGeo.h")]
public partial class UFractureTinyGeoSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to merge small geometry, or small clusters</summary>
	public EMergeType MergeType;
	///<summary>Only consider bones at the current Fracture Level</summary>
	public bool bOnFractureLevel;
	///<summary>Only auto-consider clusters for merging. Note that leaf nodes can still be consider if manually selected.</summary>
	public bool bOnlyClusters;
	///<summary>Only merge to neighbors with the same parent in the hierarchy</summary>
	public bool bOnlySameParent;
	///<summary>Helper variable to let the EditConditions above check whether the Fracture Level is set to &#39;All&#39;</summary>
	public bool bFractureLevelIsAll;
	///<summary>NeighborSelection</summary>
	public ENeighborSelectionMethod NeighborSelection;
	///<summary>Only merge pieces that are connected in the proximity graph. If unchecked, connected pieces will still be favored, but if none are available the closest disconnected piece can be merged.</summary>
	public bool bOnlyToConnected;
	///<summary>Options for using the current bone selection</summary>
	public EUseBoneSelection UseBoneSelection;
	///<summary>SelectionMethod</summary>
	public EGeometrySelectionMethod SelectionMethod;
	///<summary>If size (cube root of volume) is less than this value, geometry should be merged into neighbors -- i.e. a value of 2 merges geometry smaller than a 2x2x2 cube</summary>
	public double MinVolumeCubeRoot;
	///<summary>If cube root of volume relative to the overall shape&#39;s cube root of volume is less than this, the geometry should be merged into its neighbors.</summary>
	public double RelativeVolume;
}
