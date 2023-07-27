#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MIDIDeviceManager.h")]
public partial class UMIDIDeviceManager : UBlueprintFunctionLibrary {
// MIDIDeviceManager
	public static void FindMIDIDevices(TArray<FFoundMIDIDevice> OutMIDIDevices) {}
	public static void FindAllMIDIDeviceInfo(TArray<FMIDIDeviceInfo> OutMIDIInputDevices,TArray<FMIDIDeviceInfo> OutMIDIOutputDevices) {}
	public static void GetMIDIInputDeviceIDByName(string DeviceName,int DeviceID) {}
	public static void GetDefaultMIDIInputDeviceID(int DeviceID) {}
	public static void GetMIDIOutputDeviceIDByName(string DeviceName,int DeviceID) {}
	public static void GetDefaultMIDIOutputDeviceID(int DeviceID) {}
	public static UMIDIDeviceController CreateMIDIDeviceController(int DeviceID,int MIDIBufferSize/*=1024*/) { return default; }
	public static UMIDIDeviceInputController CreateMIDIDeviceInputController(int DeviceID,int MIDIBufferSize/*=1024*/) { return default; }
	public static UMIDIDeviceOutputController CreateMIDIDeviceOutputController(int DeviceID) { return default; }
}
