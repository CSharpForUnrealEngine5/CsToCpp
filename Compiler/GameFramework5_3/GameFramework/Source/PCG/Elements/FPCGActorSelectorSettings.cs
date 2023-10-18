namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGActorSelector.h")]
public partial struct FPCGActorSelectorSettings {
	public EPCGActorFilter ActorFilter;
	public bool bMustOverlapSelf;
	public bool bIncludeChildren;
	public bool bDisableFilter;
	public EPCGActorSelection ActorSelection;
	public FName ActorSelectionTag;
	public UClass ActorSelectionClass;
	public bool bSelectMultiple;
	public bool bIgnoreSelfAndChildren;
	public bool bShowActorFilter;
	public bool bShowIncludeChildren;
	public bool bShowActorSelection;
	public bool bShowActorSelectionClass;
	public bool bShowSelectMultiple;
}
