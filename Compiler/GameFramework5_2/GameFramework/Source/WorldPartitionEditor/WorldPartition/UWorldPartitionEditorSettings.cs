namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionEditorSettings.h")]
public partial class UWorldPartitionEditorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Commandlet class to use for World Parition conversion</summary>
	public UClass CommandletClass;
	///<summary>Editor grid size used for instance foliage actors in World Partition worlds</summary>
	public int InstancedFoliageGridSize;
	///<summary>Threshold from which minimap generates a warning if its WorldUnitsPerPixel is above this value</summary>
	public int MinimapLowQualityWorldUnitsPerPixelThreshold;
}
