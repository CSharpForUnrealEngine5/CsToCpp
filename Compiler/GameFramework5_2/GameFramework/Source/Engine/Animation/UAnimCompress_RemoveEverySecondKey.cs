#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompress_RemoveEverySecondKey.h")]
public partial class UAnimCompress_RemoveEverySecondKey : UAnimCompress {
	///<summary>Animations with fewer than MinKeys will not lose any keys.</summary>
	public int MinKeys;
	///<summary>If bStartAtSecondKey is true, remove keys 1,3,5,etc.</summary>
	public bool bStartAtSecondKey;
}
