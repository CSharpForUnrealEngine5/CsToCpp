namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
public partial struct FStatColorMapping {
	public string StatName;
	public TArray<FStatColorMapEntry> ColorMap;
	public bool DisableBlend;
}
