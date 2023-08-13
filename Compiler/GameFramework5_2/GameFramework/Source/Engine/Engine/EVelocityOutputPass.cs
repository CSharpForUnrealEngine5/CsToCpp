namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>Enumerates available options for velocity pass.</summary>
[CppEnumInNamespace]
public enum EVelocityOutputPass {
	DepthPass=0,
	BasePass=1,
	AfterBasePass=2,
}
