namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Baseclass with common properties for various Schema classes.</summary>
[CppInclude("Dom/WebAPISchema.h")]
public partial class UWebAPIModelBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Describes this model.</summary>
	public string Description;
	///<summary>By default all properties are optional.</summary>
	public bool bIsRequired;
	///<summary>By default all properties are read &amp; write.</summary>
	public bool bIsReadOnly;
	///<summary>Whether to use Minimum value.</summary>
	public bool bUseMinimumValue;
	///<summary>Minimum value. Can also indicate minimum string length.</summary>
	public double MinimumValue;
	///<summary>Whether to use Maximum value.</summary>
	public bool bUseMaximumValue;
	///<summary>Maximum value. Can also indicate maximum string length.</summary>
	public double MaximumValue;
	///<summary>Whether to use a Regex Pattern for validation.</summary>
	public bool bUsePattern;
	///<summary>Regex Pattern to validate against.</summary>
	public string Pattern;
}
