﻿namespace XmobiTea.EUN.Entity.Response
{
    using XmobiTea.EUN.Common;

    public class ChangeRoomInfoOperationResponse : CustomOperationResponse
    {
        public bool Success { get; private set; }

        public ChangeRoomInfoOperationResponse(OperationResponse operationResponse) : base(operationResponse)
        {
            if (!HasError)
            {
                Success = true;
            }
        }
    }
}
