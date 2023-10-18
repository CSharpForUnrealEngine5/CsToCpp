namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A valid snapshot of the widget tree that can be replicated to local instance.</summary>
[CppInclude("Types/UIFWidgetTree.h")]
public partial struct FUIFrameworkWidgetTree {
	public TArray<FUIFrameworkWidgetTreeEntry> Entries;
	public AActor ReplicatedOwner;
}
