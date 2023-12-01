using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TeapotInstaller
{
    class Definitions
    {
        public static string STR_SYSPATH = "\\Device\\Harddisk0\\Partition";
        public static string STR_HDD = "HDD:\\";
        public static string STR_TEAPOT = "Teapot:\\";
        public static string STR_TEMPPATH = string.Format("{0}Teapot", Path.GetTempPath());

        public static int HalHaltRoutine = 0x0, // hard poweroff (used by hotplug HDD) HalpPowerDownSystemNow
        HalRebootRoutine = 0x1, // hard reset (video error) HalpRebootSystem
        HalKdRebootRoutine = 0x2, // hard reset (used for dumpwritedump/frozen processor) HalpRebootSystem
        HalFatalErrorRebootRoutine = 0x3, // hard reset HalpRebootSystem
        HalResetSMCRoutine = 0x4, // power off (hard) HalpRebootSystem
        HalPowerDownRoutine = 0x5, // power off (nice) HalpPowerDownSystem
        HalRebootQuiesceRoutine = 0x6, // E79 (lost settings) HalpRebootQuiesceSystem
        HalForceShutdownRoutine = 0x7, // frozen console HalpRequestPowerDownDpc
        HalPowerCycleQuiesceRoutine = 0x8,
        HalMaximumRoutine = 0x9;
    }
}
