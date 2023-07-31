#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioParameterControllerInterface.h")]
public partial class UAudioParameterControllerInterface : UInterface {
	///<summary>Resets all parameters to their original values.</summary>
	public  void ResetParameters() {}
	///<summary>Executes a named trigger.  Does *not* cache trigger value, so only executes if the sound</summary>
	public  void SetTriggerParameter(string InName) {}
	///<summary>Sets a named Boolean</summary>
	public  void SetBoolParameter(string InName,bool InBool) {}
	///<summary>Sets a named Boolean Array</summary>
	public  void SetBoolArrayParameter(string InName,TArray<bool> InValue) {}
	///<summary>Sets a named Int32</summary>
	public  void SetIntParameter(string InName,int InInt) {}
	///<summary>Sets a named Int32 Array</summary>
	public  void SetIntArrayParameter(string InName,TArray<int> InValue) {}
	///<summary>Sets a named Float</summary>
	public  void SetFloatParameter(string InName,float InFloat) {}
	///<summary>Sets a named Float Array</summary>
	public  void SetFloatArrayParameter(string InName,TArray<float> InValue) {}
	///<summary>Sets a named String</summary>
	public  void SetStringParameter(string InName,string InValue) {}
	///<summary>Sets a named String Array</summary>
	public  void SetStringArrayParameter(string InName,TArray<string> InValue) {}
	///<summary>Sets a named UObject</summary>
	public  void SetObjectParameter(string InName,UObject InValue) {}
	///<summary>Sets a named UObject Array</summary>
	public  void SetObjectArrayParameter(string InName,TArray<UObject> InValue) {}
	///<summary>Sets an array of parameters as a batch</summary>
	public  void SetParameters_Blueprint(TArray<FAudioParameter> InParameters) {}
}
