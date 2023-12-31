namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionEditorSpatialHash.h")]
public partial class UWorldPartitionEditorSpatialHash : UWorldPartitionEditorHash {
	public static UClass StaticClass() {return default;}
	///<summary>CellSize</summary>
	public int CellSize;
	///<summary>WorldImage</summary>
	public FSoftObjectPath WorldImage;
	///<summary>WorldImageTopLeftW</summary>
	public FVector2D WorldImageTopLeftW;
	///<summary>WorldImageBottomRightW</summary>
	public FVector2D WorldImageBottomRightW;
}
