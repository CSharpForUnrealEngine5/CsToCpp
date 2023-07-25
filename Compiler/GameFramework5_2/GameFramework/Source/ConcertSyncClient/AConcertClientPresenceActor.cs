#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertClientPresenceActor.h")]
///<summary>A ConcertClientPresenceActor is a transient actor representing other client presences during a concert client session.</summary>
public partial class AConcertClientPresenceActor : AActor {
// ConcertClientPresenceActor
	public string PresenceDeviceType;
	public UStaticMeshComponent PresenceMeshComponent;
	public UTextRenderComponent PresenceTextComponent;
	public UMaterialInstanceDynamic PresenceMID;
	public UMaterialInstanceDynamic TextMID;
}
