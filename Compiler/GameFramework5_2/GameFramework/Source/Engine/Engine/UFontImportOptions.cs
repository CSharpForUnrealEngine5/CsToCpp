#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds options for importing fonts.</summary>
[CppInclude("Engine/FontImportOptions.h")]
public partial class UFontImportOptions : UObject {
	///<summary>The actual data for this object.  We wrap it in a struct so that we can copy it around between objects.</summary>
	public FFontImportOptionsData Data;
}
