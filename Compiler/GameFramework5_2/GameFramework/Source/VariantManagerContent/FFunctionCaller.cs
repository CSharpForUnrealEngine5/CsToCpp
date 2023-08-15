namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionCaller.h")]
public partial struct FFunctionCaller {
	public FName FunctionName;
	public TWeakObjectPtr<UObject> FunctionEntry;
	public uint DisplayOrder;
}
