#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AttributeCurve.h")]
public partial struct FAttributeCurve {
	public TArray<FAttributeKey> Keys;
	public FSoftObjectPath ScriptStructPath;
	public UScriptStruct ScriptStruct;
	public bool bShouldInterpolate;
}
