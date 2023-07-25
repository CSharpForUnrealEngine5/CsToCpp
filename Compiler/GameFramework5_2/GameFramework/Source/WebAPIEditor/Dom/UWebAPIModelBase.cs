#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPISchema.h")]
///<summary>Baseclass with common properties for various Schema classes.</summary>
public partial class UWebAPIModelBase : UObject {
// WebAPIModelBase
	public string Description;
	public bool bIsRequired;
	public bool bIsReadOnly;
	public bool bUseMinimumValue;
	public double MinimumValue;
	public bool bUseMaximumValue;
	public double MaximumValue;
	public bool bUsePattern;
	public string Pattern;
}
