#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/CustomizableObjectEditorSettings.h")]
public partial class UCustomizableObjectEditorSettings : UObject {
	///<summary>If true, Mutable won&#39;t compile any COs in the Editor.</summary>
	public bool bDisableMutableCompileInEditor;
	///<summary>If true, Mutable will automatically compile, if needed, COs being used by Actors.</summary>
	public bool bEnableAutomaticCompilation;
	///<summary>If true, AutomaticCompilation will happen synchronously.</summary>
	public bool bCompileObjectsSynchronously;
	///<summary>If true, Root Customizable Objects in memory will be compiled, if needed, before starting a PIE session.</summary>
	public bool bCompileRootObjectsOnStartPIE;
}
