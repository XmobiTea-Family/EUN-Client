﻿namespace XmobiTea.EUN
{
    using XmobiTea.EUN.Common;
    using XmobiTea.EUN.Networking;
    using XmobiTea.EUN.Config;

    using System;

    using UnityEngine;

    public static partial class EzyNetwork
    {
        public const string Version = "1.0.0";
        public static EzyServerSettings.Mode Mode => ezyServerSettings != null ? ezyServerSettings.mode : EzyServerSettings.Mode.OfflineMode;

        public static string UserId { get; private set; }

        public static EzyServerSettings ezyServerSettings { get; private set; }

        private static NetworkingPeer peer;

        private static NetworkingPeerStatistics peerStatistics;

        static EzyNetwork()
        {
            InitEzySocketObject();
            InitEzySocketStatisticsObject();
        }

        private static void InitEzySocketObject()
        {
            ezyServerSettings = Resources.Load(EzyServerSettings.ResourcesPath) as EzyServerSettings;

            peer = new GameObject("EUN NetworkingPeer").AddComponent<NetworkingPeer>();
            GameObject.DontDestroyOnLoad(peer.gameObject);

            peer.InitPeer();
        }

        private static void InitEzySocketStatisticsObject()
        {
            peerStatistics = new NetworkingPeerStatistics(peer);
        }

        public static void Connect(string userId, CustomArray data)
        {
            UserId = userId;

            peer.Connect(UserId, string.Empty, data);
        }

        public static void Send(OperationRequest request, Action<OperationResponse> onResponse = null)
        {
            peer.Enqueue(request, onResponse);
        }

        public static NetworkingPeerStatistics GetPeerStatistics() { return peerStatistics; }

        internal static void SubscriberEzyBehaviour(EzyManagerBehaviour behaviour)
        {
            peer.SubscriberEzyBehaviour(behaviour);
        }

        internal static void UnSubscriberEzyBehaviour(EzyManagerBehaviour behaviour)
        {
            peer.UnSubscriberEzyBehaviour(behaviour);
        }

        internal static void SubscriberEzyView(EzyView view)
        {
            peer.SubscriberEzyView(view);
        }

        internal static void UnSubscriberEzyView(EzyView view)
        {
            peer.UnSubscriberEzyView(view);
        }
    }
}