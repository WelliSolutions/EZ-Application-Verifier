using Microsoft.Win32;

namespace ThomasWeller.EasyAppVerif
{
    class LocalDumps
    {
        private readonly string _exeName;
        private readonly string _folder;

        internal LocalDumps(string exeName, string folder)
        {
            _exeName = exeName;
            _folder = folder;
        }

        internal void Enable()
        {
            var key = Registry.LocalMachine.CreateSubKey(Subkey);
            key?.SetValue("DumpCount", 0x00000010, RegistryValueKind.DWord);
            key?.SetValue("DumpType", 0x00000002, RegistryValueKind.DWord);
            key?.SetValue("DumpFolder", _folder, RegistryValueKind.ExpandString);
            key?.Dispose();
        }

        public void Disable()
        {
            Registry.LocalMachine.DeleteSubKeyTree(Subkey, false);
        }

        public string Subkey
        {
            get
            {
                var localdumps = $"SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting\\LocalDumps\\";
                var subkey = $"{localdumps}{_exeName}.exe";
                return subkey;
            }
        }
    }
}
