namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for UObject properties.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerObjectTestStruct {
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
