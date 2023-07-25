#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedActionKeyMapping.h")]
///<summary>Defines a mapping between a key activation and the resulting enhanced action</summary>
public partial struct FEnhancedActionKeyMapping {
// EnhancedActionKeyMapping
	public FPlayerMappableKeyOptions PlayerMappableOptions;
	public TArray<UInputTrigger> Triggers;
	public TArray<UInputModifier> Modifiers;
	public UInputAction Action;
	public FKey Key;
	public bool bShouldBeIgnored;
	public EPlayerMappableKeySettingBehaviors SettingBehavior;
	public UPlayerMappableKeySettings PlayerMappableKeySettings;
	public bool bIsPlayerMappable;
}
