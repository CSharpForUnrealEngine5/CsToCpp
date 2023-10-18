namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Customize Control Rig Editor.</summary>
[CppInclude("Settings/ControlRigSettings.h")]
public partial class UControlRigEditorSettings : URigVMEditorSettings {
	public static UClass StaticClass() {return default;}
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
}
