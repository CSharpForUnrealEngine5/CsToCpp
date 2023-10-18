namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Determines how the refraction account for the coverage with Substrate. It can only be used when Substrate is enabled.</summary>
public enum ERefractionCoverageMode {
	RCM_CoverageIgnored=0,
	RCM_CoverageAccountedFor=1,
}
