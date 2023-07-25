#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGActorSelector.h")]
public partial struct FPCGActorSelectorSettings {
// PCGActorSelectorSettings
	public EPCGActorFilter ActorFilter;
	public bool bMustOverlapSelf;
	public bool bIncludeChildren;
	public bool bDisableFilter;
	public EPCGActorSelection ActorSelection;
	public string ActorSelectionTag;
	public UClass ActorSelectionClass;
	public bool bSelectMultiple;
}
