#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for agents that exist in the world. Ticks the agents. Finds avatars for the agents.</summary>
[CppInclude("Sessions/MLAdapterSession.h")]
public partial class UMLAdapterSession : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CachedGameMode</summary>
	public AGameModeBase CachedGameMode;
	///<summary>CachedWorld</summary>
	public UWorld CachedWorld;
	///<summary>See: HashAvatar</summary>
	public TMap<uint,UMLAdapterAgent> AvatarToAgent;
	///<summary>Agents</summary>
	public TArray<UMLAdapterAgent> Agents;
	///<summary>AwaitingAvatar</summary>
	public TArray<UMLAdapterAgent> AwaitingAvatar;
}
