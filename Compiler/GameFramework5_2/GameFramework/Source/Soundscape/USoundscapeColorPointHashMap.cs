#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeSubsystem.h")]
public partial class USoundscapeColorPointHashMap : UObject {
// SoundscapeColorPointHashMap
	public  void InitializeHash(float HashCellSizeIn,FVector GridCenterIn) {}
	public  void ClearHash() {}
	public  int NumColorPointsInCell(FVector Location,FGameplayTag ColorPoint) { return default; }
	public  bool AddColorPointToHash(FVector Location,FGameplayTag ColorPoint) { return default; }
	public  void AddColorPointArrayToHash(TArray<FVector> Locations,FGameplayTag ColorPoint) {}
	public  ulong CalculateHashIndex(FVector Location) { return default; }
	public  void SetGridCenterpoint(FVector Location) {}
	public TMap<FGameplayTag,USoundscapeColorPointHashCellDensity> ColorPointHashMap;
	public float HashCellSize;
	public int GridWidth;
	public long NumCells;
	public float HashCellFactor;
	public FVector GridCenter;
	public FVector GridOriginOffset;
}
