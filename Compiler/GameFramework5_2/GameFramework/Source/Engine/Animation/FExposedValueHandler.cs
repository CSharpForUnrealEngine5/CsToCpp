#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An exposed value updater</summary>
[CppInclude("Animation/ExposedValueHandler.h")]
public partial struct FExposedValueHandler {
	public TArray<FExposedValueCopyRecord> CopyRecords;
	public UFunction Function;
	public string BoundFunction;
}
