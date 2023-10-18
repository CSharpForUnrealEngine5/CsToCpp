namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AttributeCurve.h")]
public partial struct FAttributeCurve {
	public TArray<FAttributeKey> Keys;
	public FSoftObjectPath ScriptStructPath;
	public UScriptStruct ScriptStruct;
	public bool bShouldInterpolate;
}
