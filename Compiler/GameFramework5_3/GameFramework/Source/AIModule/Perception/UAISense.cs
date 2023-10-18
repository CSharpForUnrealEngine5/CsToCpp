namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense.h")]
public partial class UAISense : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NotifyType</summary>
	public EAISenseNotifyType NotifyType;
	///<summary>whether this sense is interested in getting notified about new Pawns being spawned</summary>
	public bool bWantsNewPawnNotification;
	///<summary>If true all newly spawned pawns will get auto registered as source for this sense.</summary>
	public bool bAutoRegisterAllPawnsAsSources;
	///<summary>PerceptionSystemInstance</summary>
	public UAIPerceptionSystem PerceptionSystemInstance;
}
