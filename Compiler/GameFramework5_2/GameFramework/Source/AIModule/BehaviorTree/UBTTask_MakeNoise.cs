namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Make Noise task node.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_MakeNoise.h")]
public partial class UBTTask_MakeNoise : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>Loudnes of generated noise</summary>
	public float Loudnes;
}
