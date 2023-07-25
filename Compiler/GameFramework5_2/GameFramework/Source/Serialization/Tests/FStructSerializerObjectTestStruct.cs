#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Test structure for UObject properties.</summary>
public partial struct FStructSerializerObjectTestStruct {
// StructSerializerObjectTestStruct
	public UClass RawClass;
	public UClass WrappedClass;
	public UClass SubClass;
	public TSoftObjectPtr<UClass> SoftClass;
	public UObject RawObject;
	public UObject WrappedObject;
	public TWeakObjectPtr<UMetaData> WeakObject;
	public TSoftObjectPtr<UMetaData> SoftObject;
	public FSoftClassPath ClassPath;
	public FSoftObjectPath ObjectPath;
}
