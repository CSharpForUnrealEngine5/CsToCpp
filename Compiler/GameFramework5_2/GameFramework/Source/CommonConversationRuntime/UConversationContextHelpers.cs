#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationContext.h")]
///<summary>Wrapper methods from FConversationContext</summary>
public partial class UConversationContextHelpers : UBlueprintFunctionLibrary {
// ConversationContextHelpers
	public static UConversationInstance GetConversationInstance(FConversationContext Context) { return default; }
	public static FConversationNodeHandle GetCurrentConversationNodeHandle(FConversationContext Context) { return default; }
	public static void MakeConversationParticipant(FConversationContext Context,AActor ParticipantActor,FGameplayTag ParticipantTag) {}
	public static FConversationTaskResult AdvanceConversation(FConversationContext Context) { return default; }
	public static FConversationTaskResult AdvanceConversationWithChoice(FConversationContext Context,FAdvanceConversationRequest Choice) { return default; }
	public static FConversationTaskResult PauseConversationAndSendClientChoices(FConversationContext Context,FClientConversationMessage Message) { return default; }
	public static FConversationTaskResult ReturnToLastClientChoice(FConversationContext Context) { return default; }
	public static FConversationTaskResult ReturnToCurrentClientChoice(FConversationContext Context) { return default; }
	public static FConversationTaskResult ReturnToConversationStart(FConversationContext Context) { return default; }
	public static FConversationTaskResult AbortConversation(FConversationContext Context) { return default; }
	public static bool CanConversationContinue(FConversationTaskResult ConversationTasResult) { return default; }
	public static UConversationParticipantComponent GetConversationParticipant(FConversationContext Context,FGameplayTag ParticipantTag) { return default; }
	public static AActor GetConversationParticipantActor(FConversationContext Context,FGameplayTag ParticipantTag) { return default; }
	public static UConversationParticipantComponent FindConversationComponent(AActor Actor) { return default; }
}
