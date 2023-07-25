#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CollisionProfile.h")]
///<summary>Set up and modify collision settings.</summary>
public partial class UCollisionProfile : UDeveloperSettings {
// CollisionProfile
	public TArray<FCollisionResponseTemplate> Profiles;
	public TArray<FCustomChannelSetup> DefaultChannelResponses;
	public TArray<FCustomProfile> EditProfiles;
	public TArray<FRedirector> ProfileRedirects;
	public TArray<FRedirector> CollisionChannelRedirects;
}
