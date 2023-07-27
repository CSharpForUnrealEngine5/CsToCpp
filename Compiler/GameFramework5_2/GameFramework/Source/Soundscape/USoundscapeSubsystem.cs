#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeSubsystem.h")]
public partial class USoundscapeSubsystem : UGameInstanceSubsystem {
// SoundscapeSubsystem
	public  void SetState(FGameplayTag SoundscapeState) {}
	public  void ClearState(FGameplayTag SoundscapeState) {}
	public  void RestartSoundscape() {}
	public  bool AddPaletteCollection(string PaletteCollectionName,FSoundscapePaletteCollection PaletteCollection) { return default; }
	public  bool RemovePaletteCollection(string PaletteCollectionName) { return default; }
	public TSet<USoundscapePalette> LoadedPaletteCollectionSet;
	public TMap<string,FSoundscapePaletteCollection> UnloadedPaletteCollections;
	public TMap<USoundscapePalette,UActiveSoundscapePalette> ActivePalettes;
	public  void AddColorPointCollection(string ColorPointCollectionName,FSoundscapeColorPointCollection ColorPointCollection) {}
	public  bool RemoveColorPointCollection(string ColorPointCollectionName) { return default; }
	public  int CheckColorPointDensity(FVector Location,FGameplayTag ColorPoint) { return default; }
	public TArray<USoundscapeColorPointHashMapCollection> ColorPointHashMapCollections;
	public USoundscapeColorPointHashMap ColorPointHashMapLOD1;
	public USoundscapeColorPointHashMap ColorPointHashMapLOD2;
	public USoundscapeColorPointHashMap ColorPointHashMapLOD3;
	public USoundscapeColorPointHashMap ActiveColorPointHashMap;
}
