#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>Enumerates available options for custom depth.</summary>
[CppEnumInNamespace]
public enum ECustomDepthStencil {
	Disabled=0,
	Enabled=1,
	EnabledOnDemand=2,
	EnabledWithStencil=3,
}
