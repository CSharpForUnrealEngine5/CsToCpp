#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense.h")]
public partial class UAISense : UObject {
// AISense
	public float DefaultExpirationAge;
	public EAISenseNotifyType NotifyType;
	public bool bWantsNewPawnNotification;
	public bool bAutoRegisterAllPawnsAsSources;
	public UAIPerceptionSystem PerceptionSystemInstance;
}
