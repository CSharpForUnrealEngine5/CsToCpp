#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidRuntimeSettings.h")]
///<summary>Depth buffer precision preferences // IF THIS CHANGES, MAKE SURE TO UPDATE UEDeployAndroid.cs, ConvertDepthBufferIniValue()!</summary>
[CppEnumInNamespace]
public enum EAndroidDepthBufferPreference {
	Default=0,
	Bits16=16,
	Bits24=24,
	Bits32=32,
}
