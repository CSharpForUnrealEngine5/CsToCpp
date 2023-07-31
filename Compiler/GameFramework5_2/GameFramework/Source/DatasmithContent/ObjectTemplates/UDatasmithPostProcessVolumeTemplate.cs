#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents an APostProcessVolume</summary>
[CppInclude("ObjectTemplates/DatasmithPostProcessVolumeTemplate.h")]
public partial class UDatasmithPostProcessVolumeTemplate : UDatasmithObjectTemplate {
	///<summary>Settings</summary>
	public FDatasmithPostProcessSettingsTemplate Settings;
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>bUnbound</summary>
	public bool bUnbound;
}
