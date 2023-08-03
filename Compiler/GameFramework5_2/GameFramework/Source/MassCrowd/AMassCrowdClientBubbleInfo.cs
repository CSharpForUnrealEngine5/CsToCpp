#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class will allow us to replicate Mass data based on the fidelity required for each player controller. There is one AMassReplicationActor per PlayerController and</summary>
[CppInclude("MassCrowdBubble.h")]
public partial class AMassCrowdClientBubbleInfo : AMassClientBubbleInfoBase {
	public static UClass StaticClass() {return default;}
	///<summary>CrowdSerializer</summary>
	public FMassCrowdClientBubbleSerializer CrowdSerializer;
}
