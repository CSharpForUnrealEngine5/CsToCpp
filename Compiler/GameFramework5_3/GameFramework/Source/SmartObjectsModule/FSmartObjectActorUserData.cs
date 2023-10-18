namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that can be used to pass data to the find or filtering methods.</summary>
[CppInclude("SmartObjectTypes.h")]
public partial struct FSmartObjectActorUserData {
	public TWeakObjectPtr<AActor> UserActor;
}
