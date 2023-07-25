#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AttributeCurve.h")]
public partial struct FAttributeCurve {
// AttributeCurve
	public TArray<FAttributeKey> Keys;
	public FSoftObjectPath ScriptStructPath;
	public UScriptStruct ScriptStruct;
	public bool bShouldInterpolate;
}
