#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCLASS(config = Engine, defaultconfig)</summary>
[CppInclude("MaterialShaderQualitySettings.h")]
public partial class UMaterialShaderQualitySettings : UObject {
	///<summary>ForwardSettingMap</summary>
	public TMap<string,UShaderPlatformQualitySettings> ForwardSettingMap;
}
