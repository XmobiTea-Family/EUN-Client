﻿namespace EUN.Plugin.WebGL
{
    using System.Runtime.InteropServices;

    public class EzyClientJsBride
    {
        [DllImport("__Internal")]
        public static extern void EzyLibrary();

        [DllImport("__Internal")]
        public static extern void EzyInit(string gameObjectName, string zoneName, string appName);

        [DllImport("__Internal")]
        public static extern void EzyConnect(string userId, string host);

        [DllImport("__Internal")]
        public static extern bool EzySend(string requestData);
    }
}