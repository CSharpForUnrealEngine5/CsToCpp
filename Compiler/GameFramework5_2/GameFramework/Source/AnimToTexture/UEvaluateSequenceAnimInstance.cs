#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple anim instance with a few parameters to be used as inputs when driving it</summary>
[CppInclude("EvaluateSequenceAnimInstance.h")]
public partial class UEvaluateSequenceAnimInstance : UAnimInstance {
	public static UClass StaticClass() {return default;}
	///<summary>SequenceToEvaluate</summary>
	public UAnimSequence SequenceToEvaluate;
	///<summary>TimeToEvaluate</summary>
	public float TimeToEvaluate;
}
