namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Arguments that can be used when creating a new mapping profile</summary>
[CppInclude("UserSettings/EnhancedInputUserSettings.h")]
public partial struct FPlayerMappableKeyProfileCreationArgs {
	public UClass ProfileType;
	public FGameplayTag ProfileIdentifier;
	public FPlatformUserId UserId;
	public FText DisplayName;
	public bool bSetAsCurrentProfile;
}
