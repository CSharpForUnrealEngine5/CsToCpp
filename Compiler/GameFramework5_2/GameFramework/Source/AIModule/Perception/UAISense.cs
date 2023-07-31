#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense.h")]
public partial class UAISense : UObject {
	///<summary>age past which stimulus of this sense are &quot;forgotten&quot;. (DEPRECATED: This property will be removed in future versions. Use AISenseConfig::MaxAge instead.)</summary>
	public float DefaultExpirationAge;
	///<summary>NotifyType</summary>
	public EAISenseNotifyType NotifyType;
	///<summary>whether this sense is interested in getting notified about new Pawns being spawned</summary>
	public bool bWantsNewPawnNotification;
	///<summary>If true all newly spawned pawns will get auto registered as source for this sense.</summary>
	public bool bAutoRegisterAllPawnsAsSources;
	///<summary>PerceptionSystemInstance</summary>
	public UAIPerceptionSystem PerceptionSystemInstance;
}
