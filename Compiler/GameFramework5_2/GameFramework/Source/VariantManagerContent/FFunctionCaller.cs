namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionCaller.h")]
public partial struct FFunctionCaller {
	public string FunctionName;
	public TWeakObjectPtr<UObject> FunctionEntry;
	public uint DisplayOrder;
}
