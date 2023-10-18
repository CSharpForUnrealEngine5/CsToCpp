namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioParameter.h")]
public partial struct FAudioParameter {
	public FName ParamName;
	public float FloatParam;
	public bool BoolParam;
	public int IntParam;
	public UObject ObjectParam;
	public string StringParam;
	public TArray<float> ArrayFloatParam;
	public TArray<bool> ArrayBoolParam;
	public TArray<int> ArrayIntParam;
	public TArray<UObject> ArrayObjectParam;
	public TArray<string> ArrayStringParam;
	public EAudioParameterType ParamType;
	public FName TypeName;
}
