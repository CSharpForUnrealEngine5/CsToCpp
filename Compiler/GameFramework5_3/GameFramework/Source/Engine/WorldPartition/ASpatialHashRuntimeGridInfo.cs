namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor keeping information regarding a runtime grid</summary>
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial class ASpatialHashRuntimeGridInfo : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>GridSettings</summary>
	public FSpatialHashRuntimeGrid GridSettings;
}
