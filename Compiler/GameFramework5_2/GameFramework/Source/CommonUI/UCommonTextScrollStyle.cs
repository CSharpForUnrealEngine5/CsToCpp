namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* ---- All properties must be EditDefaultsOnly, BlueprintReadOnly !!! -----</summary>
[CppInclude("CommonTextBlock.h")]
public partial class UCommonTextScrollStyle : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Speed</summary>
	public float Speed;
	///<summary>StartDelay</summary>
	public float StartDelay;
	///<summary>EndDelay</summary>
	public float EndDelay;
	///<summary>FadeInDelay</summary>
	public float FadeInDelay;
	///<summary>FadeOutDelay</summary>
	public float FadeOutDelay;
}
