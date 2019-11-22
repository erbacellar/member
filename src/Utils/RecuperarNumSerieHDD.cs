using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

public class RecuperarNumSerieHDD
{
    public static String getSerialHD()
    {
        ManagementClass particaoClass = new ManagementClass("Win32_LogicalDisk");
        particaoClass.Get();
        ManagementObjectCollection particoes = particaoClass.GetInstances();
        String serialHD = "";
        foreach (ManagementObject particao in particoes)
        {
            if (particao["VolumeSerialNumber"] != null)
            {
                serialHD = particao["VolumeSerialNumber"].ToString();
                break;
            }
        }
        return serialHD;
    }
}