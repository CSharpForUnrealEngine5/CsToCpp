#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Play Sound task node.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_PlaySound.h")]
public partial class UBTTask_PlaySound : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>CUE to play</summary>
	public USoundCue SoundToPlay;
}
