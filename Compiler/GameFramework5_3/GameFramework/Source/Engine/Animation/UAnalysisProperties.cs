namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for properties to be used in analysis. Engine will inherit from this to define structures used for</summary>
[CppInclude("Animation/BlendSpace.h")]
public partial class UAnalysisProperties : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Analysis function for this axis</summary>
	public string Function;
}
