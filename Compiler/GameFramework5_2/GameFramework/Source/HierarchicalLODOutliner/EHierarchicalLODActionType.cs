#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HierarchicalLODType.h")]
public enum EHierarchicalLODActionType {
	InvalidAction=0,
	CreateCluster=1,
	AddActorToCluster=2,
	MoveActorToCluster=3,
	RemoveActorFromCluster=4,
	MergeClusters=5,
	ChildCluster=6,
	MAX=7,
}
