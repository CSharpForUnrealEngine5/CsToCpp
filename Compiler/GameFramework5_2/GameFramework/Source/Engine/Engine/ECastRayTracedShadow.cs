namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Ray Tracing Shadows type.</summary>
[CppEnumInNamespace]
public enum ECastRayTracedShadow {
	Disabled=0,
	UseProjectSetting=1,
	Enabled=2,
}
