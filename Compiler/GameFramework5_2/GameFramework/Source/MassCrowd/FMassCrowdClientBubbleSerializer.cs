namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mass client bubble, there will be one of these per client and it will handle replicating the fast array of Agents between the server and clients</summary>
[CppInclude("MassCrowdBubble.h")]
public partial struct FMassCrowdClientBubbleSerializer {
	public TArray<FCrowdFastArrayItem> Crowd;
}
