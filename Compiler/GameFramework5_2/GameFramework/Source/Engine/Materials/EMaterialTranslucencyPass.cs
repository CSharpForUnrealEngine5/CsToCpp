#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/Material.h")]
///<summary>Specifies which separate translucency pass to render in.</summary>
public enum EMaterialTranslucencyPass {
	MTP_BeforeDOF=0,
	MTP_AfterDOF=1,
	MTP_AfterMotionBlur=2,
	MTP_MAX=3,
}
