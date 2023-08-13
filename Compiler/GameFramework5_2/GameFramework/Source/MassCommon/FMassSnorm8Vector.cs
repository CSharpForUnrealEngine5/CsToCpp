namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Vector which components are in range [-1..1], encoded in signed bytes.</summary>
[CppInclude("MassCommonTypes.h")]
public partial struct FMassSnorm8Vector {
	public short X;
	public short Y;
	public short Z;
}
