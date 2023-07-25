#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>Enumerates ways to clear a scene.</summary>
[CppEnumInNamespace]
public enum EClearSceneOptions {
	NoClear=0,
	HardwareClear=1,
	QuadAtMaxZ=2,
}
