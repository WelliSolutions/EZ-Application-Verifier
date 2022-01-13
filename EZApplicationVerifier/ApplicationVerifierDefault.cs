using Microsoft.Win32;

namespace ThomasWeller.EasyAppVerif
{
    class ApplicationVerifierDefault
    {
        private readonly string _exeName;

        internal ApplicationVerifierDefault(string exeName)
        {
            _exeName = exeName;
        }

        internal void Enable()
        {
            RegistryKey key;
            var subkey = $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\{_exeName}";
            key = Registry.LocalMachine.CreateSubKey(subkey);
            key?.SetValue("VerifierDlls", "vrfcore.dll vfbasics.dll");
            key?.SetValue("GlobalFlag", "0x100");
            key?.SetValue("VerifierFlags", unchecked((int)0x81643027), RegistryValueKind.DWord);
            key?.SetValue("PageHeapFlags", "0x3");
            key?.SetValue("DelayFreeSizeMB", 0x00000040, RegistryValueKind.DWord);
            key = Registry.LocalMachine.CreateSubKey($"{subkey}\\Core-{{E5DCDFAA-3B35-46A8-B370-9D3575A68E53}}");
            key?.SetValue("Propagate", 0x00000000, RegistryValueKind.DWord);
            key?.SetValue("AutoClr", 0x00000000, RegistryValueKind.DWord);
            key?.SetValue("AutoDisableStop", 0x00000001, RegistryValueKind.DWord);
            key?.SetValue("LoggingWithLocksHeld", 0x00000001, RegistryValueKind.DWord);
            key?.SetValue("ExceptionOnStop", 0x00000000, RegistryValueKind.DWord);
            key?.SetValue("MinimumMemoryOverhead", 0x00000000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{subkey}\\Exceptions-{{F86B022F-E589-4e8f-B0DD-6B7AF9D71A59}}");
            key = Registry.LocalMachine.CreateSubKey($"{subkey}\\Handles-{{9760941A-8DA5-4dbe-843B-0EBD376CAB02}}");
            key?.SetValue("Traces", 0x00001000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{subkey}\\Heaps-{{4D056CEB-D8E3-4b85-B148-B543D56D9BDE}}");
            key = Registry.LocalMachine.CreateSubKey($"{subkey}\\Leak-{{81EEC8DA-0E61-4942-8037-9A6C4A86510D}}");
            key?.SetValue("ExcludeDlls", "");
            key?.SetValue("ExcludeUCRT", 0x00000000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{subkey}\\Locks-{{159D60EC-F459-456b-A27B-1076AD59F8F4}}");
            key = Registry.LocalMachine.CreateSubKey($"{subkey}\\Memory-{{8A70B8A4-4FA6-41c3-85EE-595FCB3E1051}}");
            key?.SetValue("ExecWritePage", 0x00000000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{subkey}\\SRWLock-{{6335D1CF-7955-414e-8C6A-1A40AC9357AC}}");
            key = Registry.LocalMachine.CreateSubKey($"{subkey}\\Threadpool-{{F15FC24E-53A0-444D-8D28-F7697EDD9C83}}");
            key?.SetValue("AsyncCheck", 0x00000000, RegistryValueKind.DWord);
            Registry.LocalMachine.CreateSubKey($"{subkey}\\TLS-{{EDDA96DB-D216-467d-BE3C-8603745EDA43}}");
        }

        public void Disable()
        {
            var ifeo = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\";
            Registry.LocalMachine.DeleteSubKeyTree($"{ifeo}{_exeName}", false);
        }
    }
}
