#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/BlendableInterface.h")]
///<summary>Where to place a material node in the post processing graph.</summary>
public enum EBlendableLocation {
	BL_AfterTonemapping=0,
	BL_BeforeTonemapping=1,
	BL_BeforeTranslucency=2,
	BL_ReplacingTonemapper=3,
	BL_SSRInput=4,
	BL_MAX=5,
}
