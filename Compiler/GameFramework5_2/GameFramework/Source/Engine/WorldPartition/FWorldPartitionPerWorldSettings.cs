namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionEditorPerProjectUserSettings.h")]
public partial struct FWorldPartitionPerWorldSettings {
	public TArray<FBox> LoadedEditorRegions;
	public TArray<FName> LoadedEditorLocationVolumes;
	public TArray<FName> NotLoadedDataLayers;
	public TArray<FName> LoadedDataLayers;
}
