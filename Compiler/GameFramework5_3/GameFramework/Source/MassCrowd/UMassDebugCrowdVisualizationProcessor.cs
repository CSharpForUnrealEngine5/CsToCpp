namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A custom visualization processor for debugging mass crowd</summary>
[CppInclude("MassCrowdVisualizationProcessor.h")]
public partial class UMassDebugCrowdVisualizationProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>World</summary>
	public UWorld World;
}
