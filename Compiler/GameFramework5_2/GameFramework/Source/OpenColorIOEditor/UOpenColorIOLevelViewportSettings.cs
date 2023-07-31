#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>List of settings associated to level viewport instances linked with an identifier</summary>
[CppInclude("OpenColorIOEditorSettings.h")]
public partial class UOpenColorIOLevelViewportSettings : UObject {
	///<summary>Settings associated to each viewport that was configured</summary>
	public TArray<FPerViewportDisplaySettingPair> ViewportsSettings;
}
