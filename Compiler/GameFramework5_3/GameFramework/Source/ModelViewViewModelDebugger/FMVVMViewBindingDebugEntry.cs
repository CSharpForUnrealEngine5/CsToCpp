namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMDebugViewClass.h")]
public partial struct FMVVMViewBindingDebugEntry {
	public FGuid BlueprintViewBindingId;
	public FName FieldId;
	public string SourceFieldPath;
	public string DestinationFieldPath;
	public string ConversionFunctionFieldPath;
	public int CompiledBindingIndex;
}
