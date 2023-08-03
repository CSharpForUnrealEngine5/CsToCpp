#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPICompositeModel.h")]
public partial class UWebAPICompositeModel : UWebAPIModelBase {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the composition.</summary>
	public FWebAPITypeNameVariant Name;
	///<summary>Type of composition.</summary>
	public EWebAPIModelCompositionType CompositionType;
	///<summary>Array of one or more types contained in the composition.</summary>
	public TArray<FWebAPITypeNameVariant> Types;
	///<summary>The last generated code as text for debugging.</summary>
	public string GeneratedCodeText;
}
