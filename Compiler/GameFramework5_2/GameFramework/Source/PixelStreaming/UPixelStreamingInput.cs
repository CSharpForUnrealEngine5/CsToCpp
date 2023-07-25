#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingInputComponent.h")]
///<summary>This component may be attached to an actor to allow UI interactions to be</summary>
public partial class UPixelStreamingInput : UActorComponent {
// PixelStreamingInput
	public void FOnInput(string Descriptor) {}
	public FOnInput OnInputEvent;
	public void SendPixelStreamingResponse(string Descriptor) {}
	public void GetJsonStringValue(string Descriptor,string FieldName,string StringValue,bool Success) {}
	public void AddJsonStringValue(string Descriptor,string FieldName,string StringValue,string NewDescriptor,bool Success) {}
}
