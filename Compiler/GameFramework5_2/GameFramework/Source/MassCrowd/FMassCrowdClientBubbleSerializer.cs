#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdBubble.h")]
///<summary>Mass client bubble, there will be one of these per client and it will handle replicating the fast array of Agents between the server and clients</summary>
public partial struct FMassCrowdClientBubbleSerializer {
// MassCrowdClientBubbleSerializer
	public TArray<FCrowdFastArrayItem> Crowd;
}
