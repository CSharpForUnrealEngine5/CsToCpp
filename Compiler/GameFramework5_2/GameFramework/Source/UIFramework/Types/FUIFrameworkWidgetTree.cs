#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/UIFWidgetTree.h")]
///<summary>A valid snapshot of the widget tree that can be replicated to local instance.</summary>
public partial struct FUIFrameworkWidgetTree {
// UIFrameworkWidgetTree
	public TArray<FUIFrameworkWidgetTreeEntry> Entries;
	public AActor ReplicatedOwner;
}
