namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options when querying what keys are mapped to a specific action on the player mappable</summary>
[CppInclude("UserSettings/EnhancedInputUserSettings.h")]
public partial struct FPlayerMappableKeyQueryOptions {
	public FName MappingName;
	public FKey KeyToMatch;
	public EPlayerMappableKeySlot SlotToMatch;
	public bool bMatchBasicKeyTypes;
	public bool bMatchKeyAxisType;
	public EHardwareDevicePrimaryType RequiredDeviceType;
	public int RequiredDeviceFlags;
}
