namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class for a simple camera shake.</summary>
[CppInclude("CompositeCameraShakePattern.h")]
public partial class UCompositeCameraShakePattern : UCameraShakePattern {
	public static UClass StaticClass() {return default;}
	///<summary>The list of child shake patterns</summary>
	public TArray<UCameraShakePattern> ChildPatterns;
}
