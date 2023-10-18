namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper methods from FConversationContext</summary>
[CppInclude("ConversationContext.h")]
public partial class UConversationContextHelpers : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the conversation instance object associated with the conversation context provided, or nullptr if not valid</summary>
	public static UConversationInstance GetConversationInstance(FConversationContext Context) { return default; }
	///<summary>Returns the FConversationNodeHandle of the conversation instance associated with this context, or a handle with an invalid FGuid if not possible</summary>
	public static FConversationNodeHandle GetCurrentConversationNodeHandle(FConversationContext Context) { return default; }
	///<summary>Registers an actor as part of the conversation, that actor doesn&#39;t need to have the UConversationParticipantComponent</summary>
	public static void MakeConversationParticipant(FConversationContext Context,AActor ParticipantActor,FGameplayTag ParticipantTag) {}
	///<summary>Constructs and returns a FConversationTaskResult configured with EConversationTaskResultType::AdvanceConversation</summary>
	public static FConversationTaskResult AdvanceConversation(FConversationContext Context) { return default; }
	///<summary>Constructs and returns a FConversationTaskResult configured with EConversationTaskResultType::AdvanceConversationWithChoice</summary>
	public static FConversationTaskResult AdvanceConversationWithChoice(FConversationContext Context,FAdvanceConversationRequest Choice) { return default; }
	///<summary>Constructs and returns a FConversationTaskResult configured with EConversationTaskResultType::PauseConversationAndSendClientChoices</summary>
	public static FConversationTaskResult PauseConversationAndSendClientChoices(FConversationContext Context,FClientConversationMessage Message) { return default; }
	///<summary>Constructs and returns a FConversationTaskResult configured with EConversationTaskResultType::ReturnToLastClientChoice</summary>
	public static FConversationTaskResult ReturnToLastClientChoice(FConversationContext Context) { return default; }
	///<summary>Constructs and returns a FConversationTaskResult configured with EConversationTaskResultType::ReturnToCurrentClientChoice</summary>
	public static FConversationTaskResult ReturnToCurrentClientChoice(FConversationContext Context) { return default; }
	///<summary>Constructs and returns a FConversationTaskResult configured with EConversationTaskResultType::ReturnToConversationStart</summary>
	public static FConversationTaskResult ReturnToConversationStart(FConversationContext Context) { return default; }
	///<summary>Constructs and returns a FConversationTaskResult configured with EConversationTaskResultType::AbortConversation</summary>
	public static FConversationTaskResult AbortConversation(FConversationContext Context) { return default; }
	///<summary>Checks the provided task result against any which would end the conversation e.g. EConversationTaskResultType::Invalid</summary>
	public static bool CanConversationContinue(FConversationTaskResult ConversationTasResult) { return default; }
	///<summary>Returns the conversation participant component belonging to the participant indicated by &#39;ParticipantTag&#39;, or nullptr if not found</summary>
	public static UConversationParticipantComponent GetConversationParticipant(FConversationContext Context,FGameplayTag ParticipantTag) { return default; }
	///<summary>Returns the conversation participant actor indicated by &#39;ParticipantTag&#39;, or nullptr if not found</summary>
	public static AActor GetConversationParticipantActor(FConversationContext Context,FGameplayTag ParticipantTag) { return default; }
	///<summary>Wrapper to find and return any UConversationParticipantComponent belonging to the provided parameter actor</summary>
	public static UConversationParticipantComponent FindConversationComponent(AActor Actor) { return default; }
}
