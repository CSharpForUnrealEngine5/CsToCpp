namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The event that is transfered over MU.</summary>
[CppInclude("MediaAssetMultiUserManager.h")]
public partial struct FConcertMediaStateChangedEvent {
	public TArray<string> ActorsPathNames;
	public byte State;
}
