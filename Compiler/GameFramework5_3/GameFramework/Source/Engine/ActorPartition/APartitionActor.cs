namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor base class for instance containers placed on a grid.</summary>
[CppInclude("ActorPartition/PartitionActor.h")]
public partial class APartitionActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>GridSize</summary>
	public uint GridSize;
}
