#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all AR textures that represent the camera depth data</summary>
[CppInclude("ARTextures.h")]
public partial class UARTextureCameraDepth : UARTexture {
	///<summary>The quality of the depth information captured this frame</summary>
	public EARDepthQuality DepthQuality;
	///<summary>The accuracy of the depth information captured this frame</summary>
	public EARDepthAccuracy DepthAccuracy;
	///<summary>Whether or not the depth information is temporally smoothed</summary>
	public bool bIsTemporallySmoothed;
}
