namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioParameterControllerInterface.h")]
public partial class UAudioParameterControllerInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Resets all parameters to their original values.</summary>
	public virtual void ResetParameters() {}
	///<summary>Executes a named trigger.  Does *not* cache trigger value, so only executes if the sound</summary>
	public virtual void SetTriggerParameter(string InName) {}
	///<summary>Sets a named Boolean</summary>
	public virtual void SetBoolParameter(string InName,bool InBool) {}
	///<summary>Sets a named Boolean Array</summary>
	public virtual void SetBoolArrayParameter(string InName,TArray<bool> InValue) {}
	///<summary>Sets a named Int32</summary>
	public virtual void SetIntParameter(string InName,int InInt) {}
	///<summary>Sets a named Int32 Array</summary>
	public virtual void SetIntArrayParameter(string InName,TArray<int> InValue) {}
	///<summary>Sets a named Float</summary>
	public virtual void SetFloatParameter(string InName,float InFloat) {}
	///<summary>Sets a named Float Array</summary>
	public virtual void SetFloatArrayParameter(string InName,TArray<float> InValue) {}
	///<summary>Sets a named String</summary>
	public virtual void SetStringParameter(string InName,string InValue) {}
	///<summary>Sets a named String Array</summary>
	public virtual void SetStringArrayParameter(string InName,TArray<string> InValue) {}
	///<summary>Sets a named UObject</summary>
	public virtual void SetObjectParameter(string InName,UObject InValue) {}
	///<summary>Sets a named UObject Array</summary>
	public virtual void SetObjectArrayParameter(string InName,TArray<UObject> InValue) {}
	///<summary>Sets an array of parameters as a batch</summary>
	public virtual void SetParameters_Blueprint(TArray<FAudioParameter> InParameters) {}
}
