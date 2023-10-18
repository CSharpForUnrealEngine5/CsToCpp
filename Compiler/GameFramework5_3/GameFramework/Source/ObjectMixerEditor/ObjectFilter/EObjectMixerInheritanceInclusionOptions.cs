namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectFilter/ObjectMixerEditorObjectFilter.h")]
public enum EObjectMixerInheritanceInclusionOptions {
	None=0,
	IncludeOnlyImmediateParent=1,
	IncludeOnlyImmediateChildren=2,
	IncludeOnlyImmediateParentAndChildren=3,
	IncludeAllParents=4,
	IncludeAllChildren=5,
	IncludeAllParentsAndChildren=6,
	IncludeAllParentsAndOnlyImmediateChildren=7,
	IncludeOnlyImmediateParentAndAllChildren=8,
}
