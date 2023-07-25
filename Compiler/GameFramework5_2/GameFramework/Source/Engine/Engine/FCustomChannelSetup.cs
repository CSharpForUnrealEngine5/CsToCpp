#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CollisionProfile.h")]
///<summary>Structure for custom channel setup information.</summary>
public partial struct FCustomChannelSetup {
// CustomChannelSetup
	public byte Channel;
	public byte DefaultResponse;
	public bool bTraceType;
	public bool bStaticObject;
	public string Name;
}
