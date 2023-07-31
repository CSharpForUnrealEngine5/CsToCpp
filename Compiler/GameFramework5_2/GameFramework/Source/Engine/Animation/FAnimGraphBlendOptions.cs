#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blending options for animation graphs in Linked Animation Blueprints.</summary>
[CppInclude("Animation/AnimClassInterface.h")]
public partial struct FAnimGraphBlendOptions {
	public float BlendInTime;
	public UBlendProfile BlendInProfile;
	public float BlendOutTime;
	public UBlendProfile BlendOutProfile;
}
