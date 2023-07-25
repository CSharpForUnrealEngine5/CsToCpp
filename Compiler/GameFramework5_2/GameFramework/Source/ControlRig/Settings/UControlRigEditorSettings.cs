#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ControlRigSettings.h")]
///<summary>Customize Control Rig Editor.</summary>
public partial class UControlRigEditorSettings : UDeveloperSettings {
// ControlRigEditorSettings
	public bool bAutoLinkMutableNodes;
	public bool bResetControlsOnCompile;
	public bool bResetControlsOnPinValueInteraction;
	public bool bEnableUndoForPoseInteraction;
	public bool bResetControlTransformsOnCompile;
	public TMap<string,FControlRigSettingsPerPinBool> RigUnitPinExpansion;
	public FLinearColor ConstructionEventBorderColor;
	public FLinearColor BackwardsSolveBorderColor;
	public FLinearColor BackwardsAndForwardsBorderColor;
	public bool bShowStackedHierarchy;
	public int MaxStackSize;
	public string NodeSnippet_1;
	public string NodeSnippet_2;
	public string NodeSnippet_3;
	public string NodeSnippet_4;
	public string NodeSnippet_5;
	public string NodeSnippet_6;
	public string NodeSnippet_7;
	public string NodeSnippet_8;
	public string NodeSnippet_9;
	public string NodeSnippet_0;
}
