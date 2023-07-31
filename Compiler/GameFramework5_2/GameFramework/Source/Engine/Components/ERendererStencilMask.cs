#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PrimitiveComponent.h")]
///<summary>Exposed enum to parallel RHI&#39;s EStencilMask and show up in the editor. Has a paired struct to convert between the two.</summary>
public enum ERendererStencilMask {
	ERSM_Default=0,
	ERSM_255=1,
	ERSM_1=2,
	ERSM_2=3,
	ERSM_4=4,
	ERSM_8=5,
	ERSM_16=6,
	ERSM_32=7,
	ERSM_64=8,
	ERSM_128=9,
}
