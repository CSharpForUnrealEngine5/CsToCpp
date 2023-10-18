namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings related to geometry collection -&gt; static mesh conversion *</summary>
[CppInclude("FractureToolConvert.h")]
public partial class UFractureReimportSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If checked, materials will be updated on export to ensure that odd-numbered material IDs correspond to internal faces, and this will be used on re-import to assign correct material IDs</summary>
	public bool bOddMaterialsAreInternal;
}
