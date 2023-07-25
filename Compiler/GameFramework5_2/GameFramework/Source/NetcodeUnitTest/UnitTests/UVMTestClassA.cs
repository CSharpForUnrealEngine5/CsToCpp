#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UnitTests/VMReflection.h")]
///<summary>Test classes for testing different types/combinations of property reflection</summary>
public partial class UVMTestClassA : UObject {
// VMTestClassA
	public UObject AObjectRef;
	public byte ByteProp;
	public ushort UInt16Prop;
	public uint UInt32Prop;
	public ulong UInt64Prop;
	public short Int8Prop;
	public short Int16Prop;
	public int Int32Prop;
	public long Int64Prop;
	public float FloatProp;
	public double DoubleProp;
	public bool bBoolPropA;
	public bool bBoolPropB;
	public bool bBoolPropC;
	public bool bBoolPropD;
	public bool bBoolPropE;
	public string NameProp;
	public string StringProp;
	public string TextProp;
	public byte BytePropArray;
	public UObject ObjectPropArray;
	public TArray<byte> DynBytePropArray;
	public TArray<bool> DynBoolPropArray;
	public TArray<UObject> DynObjectPropArray;
	public TArray<string> DynNamePropArray;
	public TArray<double> DynDoublePropArray;
	public TArray<float> DynFloatPropArray;
	public TArray<short> DynInt16PropArray;
	public TArray<long> DynInt64PropArray;
	public TArray<short> DynInt8PropArray;
	public TArray<int> DynIntPropArray;
	public TArray<ushort> DynUInt16PropArray;
	public TArray<uint> DynUIntPropArray;
	public TArray<ulong> DynUInt64PropArray;
	public TArray<string> DynStringPropArray;
	public TArray<string> DynTextPropArray;
	public TArray<UClass> DynClassPropArray;
	public TArray<APawn> DynPawnPropArray;
	public FVector StructProp;
	public FVector StructPropArray;
	public TArray<FVector> DynStructPropArray;
}
