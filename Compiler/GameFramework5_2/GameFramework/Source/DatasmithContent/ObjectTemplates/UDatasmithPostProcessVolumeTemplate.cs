namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents an APostProcessVolume</summary>
[CppInclude("ObjectTemplates/DatasmithPostProcessVolumeTemplate.h")]
public partial class UDatasmithPostProcessVolumeTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FDatasmithPostProcessSettingsTemplate Settings;
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>bUnbound</summary>
	public bool bUnbound;
}
