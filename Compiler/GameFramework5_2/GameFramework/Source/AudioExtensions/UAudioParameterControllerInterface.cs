#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioParameterControllerInterface.h")]
public partial class UAudioParameterControllerInterface : UInterface {
// AudioParameterControllerInterface
	public  void ResetParameters() {}
	public  void SetTriggerParameter(string InName) {}
	public  void SetBoolParameter(string InName,bool InBool) {}
	public  void SetBoolArrayParameter(string InName,TArray<bool> InValue) {}
	public  void SetIntParameter(string InName,int InInt) {}
	public  void SetIntArrayParameter(string InName,TArray<int> InValue) {}
	public  void SetFloatParameter(string InName,float InFloat) {}
	public  void SetFloatArrayParameter(string InName,TArray<float> InValue) {}
	public  void SetStringParameter(string InName,string InValue) {}
	public  void SetStringArrayParameter(string InName,TArray<string> InValue) {}
	public  void SetObjectParameter(string InName,UObject InValue) {}
	public  void SetObjectArrayParameter(string InName,TArray<UObject> InValue) {}
	public  void SetParameters_Blueprint(TArray<FAudioParameter> InParameters) {}
}
