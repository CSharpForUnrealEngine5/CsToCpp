#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test classes for testing different types/combinations of property reflection</summary>
[CppInclude("UnitTests/VMReflection.h")]
public partial class UVMTestClassA : UObject {
	///<summary>AObjectRef</summary>
	public UObject AObjectRef;
	///<summary>ByteProp</summary>
	public byte ByteProp;
	///<summary>UInt16Prop</summary>
	public ushort UInt16Prop;
	///<summary>UInt32Prop</summary>
	public uint UInt32Prop;
	///<summary>UInt64Prop</summary>
	public ulong UInt64Prop;
	///<summary>Int8Prop</summary>
	public short Int8Prop;
	///<summary>Int16Prop</summary>
	public short Int16Prop;
	///<summary>Int32Prop</summary>
	public int Int32Prop;
	///<summary>Int64Prop</summary>
	public long Int64Prop;
	///<summary>FloatProp</summary>
	public float FloatProp;
	///<summary>DoubleProp</summary>
	public double DoubleProp;
	///<summary>bBoolPropA</summary>
	public bool bBoolPropA;
	///<summary>bBoolPropB</summary>
	public bool bBoolPropB;
	///<summary>bBoolPropC</summary>
	public bool bBoolPropC;
	///<summary>bBoolPropD</summary>
	public bool bBoolPropD;
	///<summary>bBoolPropE</summary>
	public bool bBoolPropE;
	///<summary>NameProp</summary>
	public string NameProp;
	///<summary>StringProp</summary>
	public string StringProp;
	///<summary>TextProp</summary>
	public string TextProp;
	///<summary>BytePropArray</summary>
	public byte BytePropArray;
	///<summary>ObjectPropArray</summary>
	public UObject ObjectPropArray;
	///<summary>DynBytePropArray</summary>
	public TArray<byte> DynBytePropArray;
	///<summary>DynBoolPropArray</summary>
	public TArray<bool> DynBoolPropArray;
	///<summary>DynObjectPropArray</summary>
	public TArray<UObject> DynObjectPropArray;
	///<summary>DynNamePropArray</summary>
	public TArray<string> DynNamePropArray;
	///<summary>DynDoublePropArray</summary>
	public TArray<double> DynDoublePropArray;
	///<summary>DynFloatPropArray</summary>
	public TArray<float> DynFloatPropArray;
	///<summary>DynInt16PropArray</summary>
	public TArray<short> DynInt16PropArray;
	///<summary>DynInt64PropArray</summary>
	public TArray<long> DynInt64PropArray;
	///<summary>DynInt8PropArray</summary>
	public TArray<short> DynInt8PropArray;
	///<summary>DynIntPropArray</summary>
	public TArray<int> DynIntPropArray;
	///<summary>DynUInt16PropArray</summary>
	public TArray<ushort> DynUInt16PropArray;
	///<summary>DynUIntPropArray</summary>
	public TArray<uint> DynUIntPropArray;
	///<summary>DynUInt64PropArray</summary>
	public TArray<ulong> DynUInt64PropArray;
	///<summary>DynStringPropArray</summary>
	public TArray<string> DynStringPropArray;
	///<summary>DynTextPropArray</summary>
	public TArray<string> DynTextPropArray;
	///<summary>DynClassPropArray</summary>
	public TArray<UClass> DynClassPropArray;
	///<summary>DynPawnPropArray</summary>
	public TArray<APawn> DynPawnPropArray;
	///<summary>StructProp</summary>
	public FVector StructProp;
	///<summary>StructPropArray</summary>
	public FVector StructPropArray;
	///<summary>DynStructPropArray</summary>
	public TArray<FVector> DynStructPropArray;
}
