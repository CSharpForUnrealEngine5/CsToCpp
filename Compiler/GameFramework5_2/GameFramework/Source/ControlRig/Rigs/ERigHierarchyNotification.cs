#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyDefines.h")]
public enum ERigHierarchyNotification {
	ElementAdded=0,
	ElementRemoved=1,
	ElementRenamed=2,
	ElementSelected=3,
	ElementDeselected=4,
	ParentChanged=5,
	HierarchyReset=6,
	ControlSettingChanged=7,
	ControlVisibilityChanged=8,
	ControlDrivenListChanged=9,
	ControlShapeTransformChanged=10,
	ParentWeightsChanged=11,
	InteractionBracketOpened=12,
	InteractionBracketClosed=13,
	ElementReordered=14,
	Max=15,
}
