﻿namespace XmobiTea.EUN.Entity.Request
{
    using XmobiTea.EUN.Common;
    using XmobiTea.EUN.Constant;

    public class GetCurrentLobbyStatsOperationRequest : CustomOperationRequest
    {
        protected override int Code => OperationCode.GetCurrentLobbyStats;

        protected override bool Reliable => true;

        public GetCurrentLobbyStatsOperationRequest(int skip, int limit, int timeout = OperationRequest.DefaultTimeOut) : base(timeout)
        {
            Parameters = new EUNHashtable.Builder()
                .Add(ParameterCode.Skip, skip)
                .Add(ParameterCode.Limit, limit)
                .Build();
        }
    }
}
