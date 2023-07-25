#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/ExposedValueHandler.h")]
///<summary>An exposed value updater</summary>
public partial struct FExposedValueHandler {
// ExposedValueHandler
	public TArray<FExposedValueCopyRecord> CopyRecords;
	public UFunction Function;
	public string BoundFunction;
}
