#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeSubsystem.h")]
public partial class USoundscapeColorPointHashMap : UObject {
	///<summary>Clears and initializes hash map, sizes grid to HashCellWidth in Uunits</summary>
	public  void InitializeHash(float HashCellSizeIn,FVector GridCenterIn) {}
	///<summary>Clears hash map</summary>
	public  void ClearHash() {}
	///<summary>Returns the number of ColorPoints in a Cell containing the Location</summary>
	public  int NumColorPointsInCell(FVector Location,FGameplayTag ColorPoint) { return default; }
	///<summary>Returns true if ColorPoint added to hash, false if failed (likely location is out of Hash Bounds)</summary>
	public  bool AddColorPointToHash(FVector Location,FGameplayTag ColorPoint) { return default; }
	///<summary>Returns true if ColorPoint added to hash, false if failed (likely location is out of Hash Bounds)</summary>
	public  void AddColorPointArrayToHash(TArray<FVector> Locations,FGameplayTag ColorPoint) {}
	///<summary>Calculates Hash Index</summary>
	public  ulong CalculateHashIndex(FVector Location) { return default; }
	///<summary>Sets ceterpoint of grid to Location</summary>
	public  void SetGridCenterpoint(FVector Location) {}
	///<summary>Color Point Hash Map</summary>
	public TMap<FGameplayTag,USoundscapeColorPointHashCellDensity> ColorPointHashMap;
	///<summary>Hash Cell Width</summary>
	public float HashCellSize;
	///<summary>MaxGridWidth / Hash Cell Size</summary>
	public int GridWidth;
	///<summary>Grid Width Cubed</summary>
	public long NumCells;
	///<summary>Cell Size Inverted</summary>
	public float HashCellFactor;
	///<summary>Current Grid Centerpoint</summary>
	public FVector GridCenter;
	///<summary>Grid Origin Offset</summary>
	public FVector GridOriginOffset;
}
