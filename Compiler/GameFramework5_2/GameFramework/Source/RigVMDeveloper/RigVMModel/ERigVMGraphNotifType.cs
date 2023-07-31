#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMNotifications.h")]
///<summary>The Graph Notification Type is used to differentiate</summary>
public enum ERigVMGraphNotifType {
	GraphChanged=0,
	NodeAdded=1,
	NodeRemoved=2,
	NodeSelected=3,
	NodeDeselected=4,
	NodeSelectionChanged=5,
	NodePositionChanged=6,
	NodeSizeChanged=7,
	NodeColorChanged=8,
	PinAdded=9,
	PinRemoved=10,
	PinRenamed=11,
	PinExpansionChanged=12,
	PinWatchedChanged=13,
	PinArraySizeChanged=14,
	PinDefaultValueChanged=15,
	PinDirectionChanged=16,
	PinTypeChanged=17,
	PinIndexChanged=18,
	LinkAdded=19,
	LinkRemoved=20,
	CommentTextChanged=21,
	RerouteCompactnessChanged=22,
	VariableAdded=23,
	VariableRemoved=24,
	VariableRenamed=25,
	InteractionBracketOpened=26,
	InteractionBracketClosed=27,
	InteractionBracketCanceled=28,
	PinBoundVariableChanged=29,
	NodeRenamed=30,
	NodeReferenceChanged=31,
	NodeCategoryChanged=32,
	NodeKeywordsChanged=33,
	NodeDescriptionChanged=34,
	VariableRemappingChanged=35,
	LibraryTemplateChanged=36,
	FunctionAccessChanged=37,
	Invalid=38,
}
