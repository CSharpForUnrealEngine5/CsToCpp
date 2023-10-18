namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/RuntimeHashSet/RuntimePartitionLevelStreaming.h")]
public partial class URuntimePartitionLevelStreaming : URuntimePartition {
	public static UClass StaticClass() {return default;}
	///<summary>Splits actors into different sublevels based on their actor containers (level instance)</summary>
	public bool bOneLevelPerActorContainer;
}
