namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UMGEditorProjectSettings.h")]
///<summary>Controls the level of support you want to have for widget property binding.</summary>
public enum EPropertyBindingPermissionLevel {
	Allow=0,
	Prevent=1,
	PreventAndWarn=2,
	PreventAndError=3,
}
