namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A ConcertClientPresenceActor is a transient actor representing other client presences during a concert client session.</summary>
[CppInclude("ConcertClientPresenceActor.h")]
public partial class AConcertClientPresenceActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>The device type that this presence represent (i.e Oculus, Vive, Desktop)</summary>
	public string PresenceDeviceType;
	///<summary>The camera mesh component to show visually where the camera is placed</summary>
	public UStaticMeshComponent PresenceMeshComponent;
	///<summary>The text render component to display the associated client&#39;s name</summary>
	public UTextRenderComponent PresenceTextComponent;
	///<summary>Dynamic material for the presence actor</summary>
	public UMaterialInstanceDynamic PresenceMID;
	///<summary>Dynamic material for the presence text</summary>
	public UMaterialInstanceDynamic TextMID;
}
