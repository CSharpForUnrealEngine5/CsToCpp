namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a mapping between a key activation and the resulting enhanced action</summary>
[CppInclude("EnhancedActionKeyMapping.h")]
public partial struct FEnhancedActionKeyMapping {
	public FPlayerMappableKeyOptions PlayerMappableOptions;
	public TArray<UInputTrigger> Triggers;
	public TArray<UInputModifier> Modifiers;
	public UInputAction Action;
	public FKey Key;
	public bool bShouldBeIgnored;
	public bool bIsPlayerMappable;
	public EPlayerMappableKeySettingBehaviors SettingBehavior;
	public UPlayerMappableKeySettings PlayerMappableKeySettings;
}
