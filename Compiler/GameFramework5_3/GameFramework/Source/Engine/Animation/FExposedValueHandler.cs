namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An exposed value updater</summary>
[CppInclude("Animation/ExposedValueHandler.h")]
public partial struct FExposedValueHandler {
	public TArray<FExposedValueCopyRecord> CopyRecords;
	public UFunction Function;
	public FName BoundFunction;
}
