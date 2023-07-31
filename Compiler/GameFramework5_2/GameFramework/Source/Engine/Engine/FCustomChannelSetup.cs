#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for custom channel setup information.</summary>
[CppInclude("Engine/CollisionProfile.h")]
public partial struct FCustomChannelSetup {
	public ECollisionChannel Channel;
	public ECollisionResponse DefaultResponse;
	public bool bTraceType;
	public bool bStaticObject;
	public string Name;
}
