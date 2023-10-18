namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/TextAssetCommandlet.h")]
public enum ETextAssetCommandletMode {
	ResaveText=0,
	ResaveBinary=1,
	RoundTrip=2,
	LoadBinary=3,
	LoadText=4,
	FindMismatchedSerializers=5,
	GenerateSchema=6,
}
