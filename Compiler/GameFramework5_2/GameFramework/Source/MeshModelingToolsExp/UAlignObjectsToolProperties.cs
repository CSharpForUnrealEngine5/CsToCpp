namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Align Objects Operation</summary>
[CppInclude("AlignObjectsTool.h")]
public partial class UAlignObjectsToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>AlignType</summary>
	public EAlignObjectsAlignTypes AlignType;
	///<summary>AlignTo</summary>
	public EAlignObjectsAlignToOptions AlignTo;
	///<summary>BoxPosition</summary>
	public EAlignObjectsBoxPoint BoxPosition;
	///<summary>bAlignX</summary>
	public bool bAlignX;
	///<summary>bAlignY</summary>
	public bool bAlignY;
	///<summary>bAlignZ</summary>
	public bool bAlignZ;
}
