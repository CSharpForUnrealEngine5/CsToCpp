#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default ControlRig settings.</summary>
[CppInclude("Settings/ControlRigSettings.h")]
public partial class UControlRigSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultShapeLibrary</summary>
	public TSoftObjectPtr<UControlRigShapeLibrary> DefaultShapeLibrary;
}
