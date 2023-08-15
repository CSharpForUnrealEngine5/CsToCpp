namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeSubsystem.h")]
public partial class USoundscapeSubsystem : UGameInstanceSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>SetState</summary>
	public void SetState(FGameplayTag SoundscapeState) {}
	///<summary>ClearState</summary>
	public void ClearState(FGameplayTag SoundscapeState) {}
	///<summary>RestartSoundscape</summary>
	public void RestartSoundscape() {}
	///<summary>AddPaletteCollection</summary>
	public bool AddPaletteCollection(FName PaletteCollectionName,FSoundscapePaletteCollection PaletteCollection) { return default; }
	///<summary>RemovePaletteCollection</summary>
	public bool RemovePaletteCollection(FName PaletteCollectionName) { return default; }
	///<summary>LoadedPaletteCollectionSet</summary>
	public TSet<USoundscapePalette> LoadedPaletteCollectionSet;
	///<summary>UnloadedPaletteCollections</summary>
	public TMap<FName,FSoundscapePaletteCollection> UnloadedPaletteCollections;
	///<summary>ActivePalettes</summary>
	public TMap<USoundscapePalette,UActiveSoundscapePalette> ActivePalettes;
	///<summary>Add a Color Point Collection to the Subsystem, returns true if successful</summary>
	public void AddColorPointCollection(FName ColorPointCollectionName,FSoundscapeColorPointCollection ColorPointCollection) {}
	///<summary>Remove a Color Point Collection from the Subsystem, returns true if successful</summary>
	public bool RemoveColorPointCollection(FName ColorPointCollectionName) { return default; }
	///<summary>Check Color Point Density for a Location Cell</summary>
	public int CheckColorPointDensity(FVector Location,FGameplayTag ColorPoint) { return default; }
	///<summary>Stored Hash Map Collections</summary>
	public TArray<USoundscapeColorPointHashMapCollection> ColorPointHashMapCollections;
	///<summary>Color Point Hash Maps</summary>
	public USoundscapeColorPointHashMap ColorPointHashMapLOD1;
	///<summary>ColorPointHashMapLOD2</summary>
	public USoundscapeColorPointHashMap ColorPointHashMapLOD2;
	///<summary>ColorPointHashMapLOD3</summary>
	public USoundscapeColorPointHashMap ColorPointHashMapLOD3;
	///<summary>ActiveColorPointHashMap</summary>
	public USoundscapeColorPointHashMap ActiveColorPointHashMap;
}
