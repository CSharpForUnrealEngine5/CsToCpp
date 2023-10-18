namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Arguments that can be used when mapping a player key</summary>
[CppInclude("UserSettings/EnhancedInputUserSettings.h")]
public partial struct FMapPlayerKeyArgs {
	public FName MappingName;
	public EPlayerMappableKeySlot Slot;
	public FKey NewKey;
	public FName HardwareDeviceId;
	public FGameplayTag ProfileId;
	public bool bCreateMatchingSlotIfNeeded;
	public bool bDeferOnSettingsChangedBroadcast;
}
