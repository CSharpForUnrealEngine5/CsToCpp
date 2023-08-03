#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TexAligner/TexAligner.h")]
public partial class UTexAligner : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The default alignment this aligner represents.</summary>
	public ETexAlign DefTexAlign;
	///<summary>TAxis</summary>
	public byte TAxis;
	///<summary>UTile</summary>
	public float UTile;
	///<summary>VTile</summary>
	public float VTile;
	///<summary>Description for the editor to display.</summary>
	public string Desc;
}
