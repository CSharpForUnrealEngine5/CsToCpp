#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Conversation settings.</summary>
[CppInclude("ConversationSettings.h")]
public partial class UConversationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>ConversationInstanceClass</summary>
	public TSoftObjectPtr<UClass> ConversationInstanceClass;
}
