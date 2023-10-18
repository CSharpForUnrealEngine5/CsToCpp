namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Zone Shape actor for standalone zone markup.</summary>
[CppInclude("ZoneShapeActor.h")]
public partial class AZoneShape : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>ShapeComponent</summary>
	public UZoneShapeComponent ShapeComponent;
}
