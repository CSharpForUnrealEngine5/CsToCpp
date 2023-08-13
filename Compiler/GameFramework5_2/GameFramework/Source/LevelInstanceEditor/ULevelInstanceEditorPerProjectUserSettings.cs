namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstanceEditorSettings.h")]
public partial class ULevelInstanceEditorPerProjectUserSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If false, create dialog will not be shown and last settings will be used.</summary>
	public bool bAlwaysShowDialog;
	///<summary>PivotType</summary>
	public ELevelInstancePivotType PivotType;
}
