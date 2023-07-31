#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor base class for instance containers placed on a grid.</summary>
[CppInclude("ActorPartition/PartitionActor.h")]
public partial class APartitionActor : AActor {
	///<summary>The grid size this actors was generated for</summary>
	public uint GridSize;
}
