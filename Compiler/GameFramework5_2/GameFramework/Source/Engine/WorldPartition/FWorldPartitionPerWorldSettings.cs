#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionEditorPerProjectUserSettings.h")]
public partial struct FWorldPartitionPerWorldSettings {
// WorldPartitionPerWorldSettings
	public TArray<FBox> LoadedEditorRegions;
	public TArray<string> LoadedEditorLocationVolumes;
	public TArray<string> NotLoadedDataLayers;
	public TArray<string> LoadedDataLayers;
}
