namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Validated result from FindEntranceLocationForSlot().</summary>
[CppInclude("SmartObjectSubsystem.h")]
public partial struct FSmartObjectSlotEntranceLocationResult {
	public FVector Location;
	public FRotator Rotation;
	public FGameplayTag Tag;
	public FGameplayTagContainer Tags;
	public FSmartObjectSlotEntranceHandle EntranceHandle;
}
