#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCreateFollicleMaskOptions.h")]
public partial class UGroomCreateFollicleMaskOptions : UObject {
	///<summary>Follicle mask texture resolution. The resolution will be rounded to the closest power of two.</summary>
	public int Resolution;
	///<summary>Size of the root in the follicle mask (in pixels)</summary>
	public int RootRadius;
	///<summary>Grooms which will be use to create the follicle texture</summary>
	public TArray<FFollicleMaskOptions> Grooms;
}
