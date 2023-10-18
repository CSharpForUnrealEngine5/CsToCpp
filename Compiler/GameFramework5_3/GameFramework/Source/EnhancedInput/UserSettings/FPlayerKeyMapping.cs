namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a single key mapping that is set by the player</summary>
[CppInclude("UserSettings/EnhancedInputUserSettings.h")]
public partial struct FPlayerKeyMapping {
	public FName MappingName;
	public FText DisplayName;
	public FText DisplayCategory;
	public EPlayerMappableKeySlot Slot;
	public bool bIsDirty;
	public FKey DefaultKey;
	public FKey CurrentKey;
	public FHardwareDeviceIdentifier HardwareDeviceId;
	public UInputAction AssociatedInputAction;
}
