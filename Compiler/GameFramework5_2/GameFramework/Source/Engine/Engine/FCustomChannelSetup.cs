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
