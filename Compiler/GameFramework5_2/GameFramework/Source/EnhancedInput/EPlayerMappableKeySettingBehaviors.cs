#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedActionKeyMapping.h")]
///<summary>Defines which Player Mappable Key Setting to use for a Action Key Mapping.</summary>
public enum EPlayerMappableKeySettingBehaviors {
	InheritSettingsFromAction=0,
	OverrideSettings=1,
	IgnoreSettings=2,
}
