#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Customize Control Rig Editor.</summary>
[CppInclude("Settings/ControlRigSettings.h")]
public partial class UControlRigEditorSettings : UDeveloperSettings {
	///<summary>When this is checked mutable nodes (nodes with an execute pin)</summary>
	public bool bAutoLinkMutableNodes;
	///<summary>When this is checked all controls will return to their initial</summary>
	public bool bResetControlsOnCompile;
	///<summary>When this is checked all controls will return to their initial</summary>
	public bool bResetControlsOnPinValueInteraction;
	///<summary>When this is checked any hierarchy interaction within the Control Rig</summary>
	public bool bEnableUndoForPoseInteraction;
	///<summary>When checked controls will be reset during a manual compilation</summary>
	public bool bResetControlTransformsOnCompile;
	///<summary>A map which remembers the expansion setting for each rig unit pin.</summary>
	public TMap<string,FControlRigSettingsPerPinBool> RigUnitPinExpansion;
	///<summary>The border color of the viewport when entering &quot;Construction Event&quot; mode</summary>
	public FLinearColor ConstructionEventBorderColor;
	///<summary>The border color of the viewport when entering &quot;Backwards Solve&quot; mode</summary>
	public FLinearColor BackwardsSolveBorderColor;
	///<summary>The border color of the viewport when entering &quot;Backwards And Forwards&quot; mode</summary>
	public FLinearColor BackwardsAndForwardsBorderColor;
	///<summary>Option to toggle displaying the stacked hierarchy items.</summary>
	public bool bShowStackedHierarchy;
	///<summary>The maximum number of stacked items in the view</summary>
	public int MaxStackSize;
	///<summary>The default node snippet to create when pressing 1 + Left Mouse Button</summary>
	public string NodeSnippet_1;
	///<summary>The default node snippet to create when pressing 2 + Left Mouse Button</summary>
	public string NodeSnippet_2;
	///<summary>The default node snippet to create when pressing 3 + Left Mouse Button</summary>
	public string NodeSnippet_3;
	///<summary>The default node snippet to create when pressing 4 + Left Mouse Button</summary>
	public string NodeSnippet_4;
	///<summary>The default node snippet to create when pressing 5 + Left Mouse Button</summary>
	public string NodeSnippet_5;
	///<summary>The default node snippet to create when pressing 6 + Left Mouse Button</summary>
	public string NodeSnippet_6;
	///<summary>The default node snippet to create when pressing 7 + Left Mouse Button</summary>
	public string NodeSnippet_7;
	///<summary>The default node snippet to create when pressing 8 + Left Mouse Button</summary>
	public string NodeSnippet_8;
	///<summary>The default node snippet to create when pressing 9 + Left Mouse Button</summary>
	public string NodeSnippet_9;
	///<summary>The default node snippet to create when pressing 0 + Left Mouse Button</summary>
	public string NodeSnippet_0;
}
