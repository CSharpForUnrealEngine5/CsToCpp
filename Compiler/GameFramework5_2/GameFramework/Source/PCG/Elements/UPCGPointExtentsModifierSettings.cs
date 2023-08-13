namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGPointExtentsModifier.h")]
public partial class UPCGPointExtentsModifierSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Extents</summary>
	public FVector Extents;
	///<summary>Mode</summary>
	public EPCGPointExtentsModifierMode Mode;
}
