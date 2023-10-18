namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set up and modify collision settings.</summary>
[CppInclude("Engine/CollisionProfile.h")]
public partial class UCollisionProfile : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>List of all profiles, engine and game-specific</summary>
	public TArray<FCollisionResponseTemplate> Profiles;
	///<summary>Game-specific overrides to default responses to collision channels</summary>
	public TArray<FCustomChannelSetup> DefaultChannelResponses;
	///<summary>Game-specific overrides to engine profiles</summary>
	public TArray<FCustomProfile> EditProfiles;
	///<summary>Used to handle renaming profiles</summary>
	public TArray<FRedirector> ProfileRedirects;
	///<summary>Used to handle renaming collision channels</summary>
	public TArray<FRedirector> CollisionChannelRedirects;
}
