#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureDefines.h")]
///<summary>Options for texture padding mode.</summary>
[CppEnumInNamespace]
public enum ETexturePowerOfTwoSetting {
	None=0,
	PadToPowerOfTwo=1,
	PadToSquarePowerOfTwo=2,
}
